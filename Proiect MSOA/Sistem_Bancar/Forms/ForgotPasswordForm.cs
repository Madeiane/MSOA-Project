using System;
using System.Drawing;
using System.Windows.Forms;
using Sistem_Bancar.DataAccess;

namespace Sistem_Bancar
{
    public class ForgotPasswordForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtNewPassword;
        private Button btnReset;
        private Button btnCancel;

        public ForgotPasswordForm()
        {
            Text = "Reset password";
            Size = new Size(380, 220);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;

            Label lblUser = new Label { Text = "Username", Left = 20, Top = 20, Width = 100 };
            txtUsername = new TextBox { Left = 20, Top = 44, Width = 320 };

            Label lblNew = new Label { Text = "New password", Left = 20, Top = 80, Width = 120 };
            txtNewPassword = new TextBox { Left = 20, Top = 104, Width = 320, UseSystemPasswordChar = true };

            btnReset = new Button { Text = "Reset password", Left = 200, Top = 140, Width = 140, BackColor = Color.FromArgb(0, 123, 255), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnReset.Click += BtnReset_Click;

            btnCancel = new Button { Text = "Cancel", Left = 40, Top = 140, Width = 120 };
            btnCancel.Click += (s, e) => Close();

            Controls.AddRange(new Control[] { lblUser, txtUsername, lblNew, txtNewPassword, btnReset, btnCancel });
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string newPass = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Please fill all fields", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var existing = Database.GetUserByUsername(user);
                if (existing == null)
                {
                    MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ok = Database.UpdateUserPassword(user, newPass);
                if (ok)
                {
                    MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}