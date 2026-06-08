using System;

namespace Sistem_Bancar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lnkForgotPassword;
        private System.Windows.Forms.Button lnkCreateAccount;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label iconUser;
        private System.Windows.Forms.Label iconPass;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.iconUser = new System.Windows.Forms.Label();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.iconPass = new System.Windows.Forms.Label();
            this.lnkCreateAccount = new System.Windows.Forms.Button();
            this.lnkForgotPassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlPass.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(475, 312);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(171, 38);
            this.Login.TabIndex = 0;
            this.Login.Text = "Sign In";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.user.Location = new System.Drawing.Point(61, 8);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(274, 18);
            this.user.TabIndex = 2;
            this.user.Text = "Username";
            this.user.Enter += new System.EventHandler(this.user_Enter);
            this.user.Leave += new System.EventHandler(this.user_Leave);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.password.Location = new System.Drawing.Point(61, 8);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(274, 18);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblSubtitle);
            this.groupBox1.Controls.Add(this.pnlUser);
            this.groupBox1.Controls.Add(this.pnlPass);
            this.groupBox1.Controls.Add(this.lnkCreateAccount);
            this.groupBox1.Controls.Add(this.lnkForgotPassword);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(34, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(823, 520);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(75)))));
            this.lblTitle.Location = new System.Drawing.Point(443, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 37);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Welcome back";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblSubtitle.Location = new System.Drawing.Point(395, 92);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(317, 15);
            this.lblSubtitle.TabIndex = 21;
            this.lblSubtitle.Text = "Sign in to manage your accounts and transactions securely";
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlUser.Controls.Add(this.iconUser);
            this.pnlUser.Controls.Add(this.user);
            this.pnlUser.Location = new System.Drawing.Point(360, 139);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(386, 38);
            this.pnlUser.TabIndex = 22;
            // 
            // iconUser
            // 
            this.iconUser.AutoSize = true;
            this.iconUser.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.iconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.iconUser.Location = new System.Drawing.Point(10, 8);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(34, 26);
            this.iconUser.TabIndex = 0;
            this.iconUser.Text = "👤";
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlPass.Controls.Add(this.iconPass);
            this.pnlPass.Controls.Add(this.password);
            this.pnlPass.Location = new System.Drawing.Point(360, 191);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(386, 38);
            this.pnlPass.TabIndex = 23;
            // 
            // iconPass
            // 
            this.iconPass.AutoSize = true;
            this.iconPass.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.iconPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.iconPass.Location = new System.Drawing.Point(10, 8);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(34, 26);
            this.iconPass.TabIndex = 0;
            this.iconPass.Text = "🔒";
            // 
            // lnkCreateAccount
            // 
            this.lnkCreateAccount.Location = new System.Drawing.Point(360, 248);
            this.lnkCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.lnkCreateAccount.Name = "lnkCreateAccount";
            this.lnkCreateAccount.Size = new System.Drawing.Size(129, 29);
            this.lnkCreateAccount.TabIndex = 5;
            this.lnkCreateAccount.Text = "Create account";
            this.lnkCreateAccount.UseVisualStyleBackColor = true;
            this.lnkCreateAccount.Click += new System.EventHandler(this.LnkCreateAccount_Click);
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.Location = new System.Drawing.Point(617, 249);
            this.lnkForgotPassword.Margin = new System.Windows.Forms.Padding(2);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(129, 29);
            this.lnkForgotPassword.TabIndex = 6;
            this.lnkForgotPassword.Text = "Reset password";
            this.lnkForgotPassword.UseVisualStyleBackColor = true;
            this.lnkForgotPassword.Click += new System.EventHandler(this.LnkForgotPassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblTagline);
            this.panel1.Controls.Add(this.lblBankName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 485);
            this.panel1.TabIndex = 7;
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.lblTagline.Location = new System.Drawing.Point(52, 293);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(196, 15);
            this.lblTagline.TabIndex = 3;
            this.lblTagline.Text = "Secure banking, modern experience";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBankName.ForeColor = System.Drawing.Color.White;
            this.lblBankName.Location = new System.Drawing.Point(72, 217);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(142, 41);
            this.lblBankName.TabIndex = 2;
            this.lblBankName.Text = "DCBANK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(891, 607);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DCBANK - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

