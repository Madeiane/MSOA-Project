using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Sistem_Bancar.DataAccess;
using Sistem_Bancar.Models;

namespace Sistem_Bancar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(245, 246, 248);
            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = Color.FromArgb(40, 44, 52 );
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            panel1.BackColor = Color.FromArgb(18, 38, 70);
            lblBankName.ForeColor = Color.White;
            lblTagline.ForeColor = Color.FromArgb(200, 210, 220);

            // title styling
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblTitle.ForeColor = Color.FromArgb(20, 46, 75);
            lblSubtitle.ForeColor = Color.FromArgb(110, 120, 135);

            // input panels styling
            pnlUser.BackColor = Color.FromArgb(248, 249, 250);
            pnlPass.BackColor = Color.FromArgb(248, 249, 250);

            // placeholders
            user.ForeColor = Color.FromArgb(90, 95, 105);
            password.ForeColor = Color.FromArgb(90, 95, 105);

            // create rounded buttons and inputs
            Login.FlatStyle = FlatStyle.Flat;
            Login.FlatAppearance.BorderSize = 0;
            Login.BackColor = Color.FromArgb(2, 116, 255);
            Login.ForeColor = Color.White;
            Login.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RoundControl(Login, 8);

            lnkCreateAccount.FlatStyle = FlatStyle.Flat;
            lnkCreateAccount.BackColor = Color.FromArgb(238, 243, 248);
            lnkCreateAccount.ForeColor = Color.FromArgb(26, 92, 190);
            RoundControl(lnkCreateAccount, 6);

            lnkForgotPassword.FlatStyle = FlatStyle.Flat;
            lnkForgotPassword.BackColor = Color.FromArgb(238, 243, 248);
            lnkForgotPassword.ForeColor = Color.FromArgb(26, 92, 190);
            RoundControl(lnkForgotPassword, 6);

            // round input panels
            RoundControl(pnlUser, 8);
            RoundControl(pnlPass, 8);

            // make password textbox hide by default when not placeholder
            password.UseSystemPasswordChar = false;

            // icon labels styling
            iconUser.BackColor = Color.Transparent;
            iconPass.BackColor = Color.Transparent;

            // focus visuals
            user.GotFocus += (s, ev) => pnlUser.BackColor = Color.White;
            user.LostFocus += (s, ev) => pnlUser.BackColor = Color.FromArgb(248, 249, 250);
            password.GotFocus += (s, ev) => pnlPass.BackColor = Color.White;
            password.LostFocus += (s, ev) => pnlPass.BackColor = Color.FromArgb(248, 249, 250);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void RoundControl(Control c, int radius)
        {
            var gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            gp.AddArc(new Rectangle(c.Width - radius, 0, radius, radius), -90, 90);
            gp.AddArc(new Rectangle(c.Width - radius, c.Height - radius, radius, radius), 0, 90);
            gp.AddArc(new Rectangle(0, c.Height - radius, radius, radius), 90, 90);
            gp.CloseAllFigures();
            c.Region = new Region(gp);
            c.Resize += (s, e) =>
            {
                var cc = s as Control;
                if (cc.Width < radius || cc.Height < radius) return;
                var gpn = new GraphicsPath();
                gpn.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                gpn.AddArc(new Rectangle(cc.Width - radius, 0, radius, radius), -90, 90);
                gpn.AddArc(new Rectangle(cc.Width - radius, cc.Height - radius, radius, radius), 0, 90);
                gpn.AddArc(new Rectangle(0, cc.Height - radius, radius, radius), 90, 90);
                gpn.CloseAllFigures();
                cc.Region = new Region(gpn);
            };
        }

        private void LnkCreateAccount_Click(object sender, EventArgs e)
        {
            using (var frm = new CreateAccountForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void LnkForgotPassword_Click(object sender, EventArgs e)
        {
            using (var frm = new ForgotPasswordForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = user.Text.Trim();
            string passwordInput = password.Text.Trim();

            if (username == "User" || passwordInput == "Passsword")
            {
                MessageBox.Show("Please enter your credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("Please enter both username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User dbUser;
            try
            {
                dbUser = Database.AuthenticateUser(username, passwordInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbUser != null)
            {
                MessageBox.Show("Login successful! Access granted as: " + dbUser.Role, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                switch (dbUser.Role)
                {
                    case "Customer":
                        ClientDashboard clientForm = new ClientDashboard(dbUser.Id);
                        clientForm.Show();
                        break;

                    case "Employee":
                        EmployeeDashboard employeeForm = new EmployeeDashboard(dbUser.Id);
                        employeeForm.Show();
                        break;

                    case "Admin":
                        AdminDashboard adminForm = new AdminDashboard(dbUser.Id);
                        adminForm.Show();
                        break;

                    default:
                        MessageBox.Show("Role not recognized by the system.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Clear();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Username")
            {
                user.Text = "";
                user.ForeColor = Color.FromArgb(20, 46, 75);
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(user.Text))
            {
                user.Text = "Username";
                user.ForeColor = Color.FromArgb(90, 95, 105);
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
                password.ForeColor = Color.FromArgb(20, 46, 75);
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                password.Text = "Password";
                password.UseSystemPasswordChar = false;
                password.ForeColor = Color.FromArgb(90, 95, 105);
            }
        }

        private void lnkForgotPassword_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A password reset link has been simulated. In a production system, an email would be sent to your registered address.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkCreateAccount_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Registration system is currently offline. Please contact a bank officer to create an account.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void Form1_Load_1(object sender, EventArgs e)
        //{

        //}
    }
}