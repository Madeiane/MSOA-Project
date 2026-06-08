namespace Sistem_Bancar
{
    partial class EmployeeDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblSistemBancar = new System.Windows.Forms.Label();
            this.btnPendingRequests = new System.Windows.Forms.Panel();
            this.lblBtnPending = new System.Windows.Forms.Label();
            this.picPending = new System.Windows.Forms.PictureBox();
            this.btnAccountOps = new System.Windows.Forms.Panel();
            this.lblBtnAccountOps = new System.Windows.Forms.Label();
            this.picAccountOps = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Panel();
            this.lblBtnLogout = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPending = new System.Windows.Forms.Panel();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingSubtitle = new System.Windows.Forms.Label();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.pnlPendingActions = new System.Windows.Forms.Panel();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnRefreshPending = new System.Windows.Forms.Button();
            this.lblPendingNote = new System.Windows.Forms.Label();
            this.pnlAccountOps = new System.Windows.Forms.Panel();
            this.lblAccountOpsTitle = new System.Windows.Forms.Label();
            this.pnlClientLookup = new System.Windows.Forms.Panel();
            this.lblLookupHint = new System.Windows.Forms.Label();
            this.txtLookupIban = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.pnlAccountDetail = new System.Windows.Forms.Panel();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailIban = new System.Windows.Forms.Label();
            this.lblDetailBalance = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.dgvClientTransactions = new System.Windows.Forms.DataGridView();
            this.pnlOpsButtons = new System.Windows.Forms.Panel();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.btnUnfreeze = new System.Windows.Forms.Button();
            this.btnManualDeposit = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            this.btnPendingRequests.SuspendLayout();
            this.btnAccountOps.SuspendLayout();
            this.btnLogout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.pnlPendingActions.SuspendLayout();
            this.pnlAccountOps.SuspendLayout();
            this.pnlClientLookup.SuspendLayout();
            this.pnlAccountDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientTransactions)).BeginInit();
            this.pnlOpsButtons.SuspendLayout();
            this.SuspendLayout();

            this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.panel1.Controls.Add(this.lblSistemBancar);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Controls.Add(this.btnPendingRequests);
            this.panel1.Controls.Add(this.btnAccountOps);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 720);

            this.lblSistemBancar.AutoSize = false;
            this.lblSistemBancar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSistemBancar.ForeColor = System.Drawing.Color.White;
            this.lblSistemBancar.Location = new System.Drawing.Point(10, 20);
            this.lblSistemBancar.Name = "lblSistemBancar";
            this.lblSistemBancar.Size = new System.Drawing.Size(190, 30);
            this.lblSistemBancar.Text = "Sistem Bancar";
            this.lblSistemBancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblEmployeeName.AutoSize = false;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(160, 180, 210);
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 52);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(190, 20);
            this.lblEmployeeName.Text = "Welcome, ...";

            this.btnPendingRequests.BackColor = System.Drawing.Color.FromArgb(50, 65, 95);
            this.btnPendingRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingRequests.Location = new System.Drawing.Point(0, 90);
            this.btnPendingRequests.Name = "btnPendingRequests";
            this.btnPendingRequests.Size = new System.Drawing.Size(210, 55);
            this.btnPendingRequests.Controls.Add(this.picPending);
            this.btnPendingRequests.Controls.Add(this.lblBtnPending);

            this.picPending.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            this.picPending.Location = new System.Drawing.Point(18, 14);
            this.picPending.Size = new System.Drawing.Size(26, 26);
            this.picPending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnPending.AutoSize = false;
            this.lblBtnPending.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnPending.ForeColor = System.Drawing.Color.White;
            this.lblBtnPending.Location = new System.Drawing.Point(54, 16);
            this.lblBtnPending.Size = new System.Drawing.Size(145, 22);
            this.lblBtnPending.Text = "Pending Requests";

            this.btnAccountOps.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.btnAccountOps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountOps.Location = new System.Drawing.Point(0, 150);
            this.btnAccountOps.Name = "btnAccountOps";
            this.btnAccountOps.Size = new System.Drawing.Size(210, 55);
            this.btnAccountOps.Controls.Add(this.picAccountOps);
            this.btnAccountOps.Controls.Add(this.lblBtnAccountOps);

            this.picAccountOps.Image = System.Drawing.SystemIcons.Shield.ToBitmap();
            this.picAccountOps.Location = new System.Drawing.Point(18, 14);
            this.picAccountOps.Size = new System.Drawing.Size(26, 26);
            this.picAccountOps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnAccountOps.AutoSize = false;
            this.lblBtnAccountOps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnAccountOps.ForeColor = System.Drawing.Color.White;
            this.lblBtnAccountOps.Location = new System.Drawing.Point(54, 16);
            this.lblBtnAccountOps.Size = new System.Drawing.Size(145, 22);
            this.lblBtnAccountOps.Text = "Account Operations";

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 60, 50);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(0, 660);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 55);
            this.btnLogout.Controls.Add(this.picLogout);
            this.btnLogout.Controls.Add(this.lblBtnLogout);

            this.picLogout.Image = System.Drawing.SystemIcons.Warning.ToBitmap();
            this.picLogout.Location = new System.Drawing.Point(18, 14);
            this.picLogout.Size = new System.Drawing.Size(26, 26);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnLogout.AutoSize = false;
            this.lblBtnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnLogout.ForeColor = System.Drawing.Color.White;
            this.lblBtnLogout.Location = new System.Drawing.Point(54, 16);
            this.lblBtnLogout.Size = new System.Drawing.Size(140, 22);
            this.lblBtnLogout.Text = "Logout";

            this.panel2.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.panel2.Controls.Add(this.pnlPending);
            this.panel2.Controls.Add(this.pnlAccountOps);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 720);

            this.pnlPending.BackColor = System.Drawing.Color.Transparent;
            this.pnlPending.Controls.Add(this.lblPendingTitle);
            this.pnlPending.Controls.Add(this.lblPendingSubtitle);
            this.pnlPending.Controls.Add(this.dgvPending);
            this.pnlPending.Controls.Add(this.pnlPendingActions);
            this.pnlPending.Controls.Add(this.lblPendingNote);
            this.pnlPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPending.Location = new System.Drawing.Point(0, 0);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(890, 720);
            this.pnlPending.Visible = true;

            this.lblPendingTitle.AutoSize = false;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.lblPendingTitle.Location = new System.Drawing.Point(25, 20);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(400, 36);
            this.lblPendingTitle.Text = "Pending Account Requests";

            this.lblPendingSubtitle.AutoSize = false;
            this.lblPendingSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPendingSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblPendingSubtitle.Location = new System.Drawing.Point(25, 56);
            this.lblPendingSubtitle.Name = "lblPendingSubtitle";
            this.lblPendingSubtitle.Size = new System.Drawing.Size(500, 18);
            this.lblPendingSubtitle.Text = "Review and approve or reject new account opening requests below.";

            this.dgvPending.Location = new System.Drawing.Point(25, 85);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.Size = new System.Drawing.Size(840, 530);
            this.dgvPending.TabIndex = 1;

            this.pnlPendingActions.BackColor = System.Drawing.Color.Transparent;
            this.pnlPendingActions.Controls.Add(this.btnApprove);
            this.pnlPendingActions.Controls.Add(this.btnReject);
            this.pnlPendingActions.Controls.Add(this.btnRefreshPending);
            this.pnlPendingActions.Location = new System.Drawing.Point(25, 625);
            this.pnlPendingActions.Name = "pnlPendingActions";
            this.pnlPendingActions.Size = new System.Drawing.Size(840, 50);

            this.lblPendingNote.AutoSize = false;
            this.lblPendingNote.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblPendingNote.ForeColor = System.Drawing.Color.FromArgb(150, 160, 180);
            this.lblPendingNote.Location = new System.Drawing.Point(25, 682);
            this.lblPendingNote.Name = "lblPendingNote";
            this.lblPendingNote.Size = new System.Drawing.Size(840, 18);
            this.lblPendingNote.Text = "Select a row before approving or rejecting.";

            this.pnlAccountOps.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountOps.Controls.Add(this.lblAccountOpsTitle);
            this.pnlAccountOps.Controls.Add(this.pnlClientLookup);
            this.pnlAccountOps.Controls.Add(this.pnlAccountDetail);
            this.pnlAccountOps.Controls.Add(this.dgvClientTransactions);
            this.pnlAccountOps.Controls.Add(this.pnlOpsButtons);
            this.pnlAccountOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccountOps.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountOps.Name = "pnlAccountOps";
            this.pnlAccountOps.Size = new System.Drawing.Size(890, 720);
            this.pnlAccountOps.Visible = false;

            this.lblAccountOpsTitle.AutoSize = false;
            this.lblAccountOpsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAccountOpsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.lblAccountOpsTitle.Location = new System.Drawing.Point(25, 20);
            this.lblAccountOpsTitle.Name = "lblAccountOpsTitle";
            this.lblAccountOpsTitle.Size = new System.Drawing.Size(350, 36);
            this.lblAccountOpsTitle.Text = "Account Operations";

            this.pnlClientLookup.BackColor = System.Drawing.Color.White;
            this.pnlClientLookup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientLookup.Controls.Add(this.lblLookupHint);
            this.pnlClientLookup.Controls.Add(this.txtLookupIban);
            this.pnlClientLookup.Controls.Add(this.btnLookup);
            this.pnlClientLookup.Location = new System.Drawing.Point(25, 68);
            this.pnlClientLookup.Name = "pnlClientLookup";
            this.pnlClientLookup.Size = new System.Drawing.Size(840, 54);

            this.lblLookupHint.AutoSize = true;
            this.lblLookupHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLookupHint.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblLookupHint.Location = new System.Drawing.Point(10, 17);
            this.lblLookupHint.Text = "IBAN:";

            this.txtLookupIban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLookupIban.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLookupIban.Location = new System.Drawing.Point(60, 14);
            this.txtLookupIban.Name = "txtLookupIban";
            this.txtLookupIban.Size = new System.Drawing.Size(630, 22);

            this.btnLookup.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookup.FlatAppearance.BorderSize = 0;
            this.btnLookup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLookup.ForeColor = System.Drawing.Color.White;
            this.btnLookup.Location = new System.Drawing.Point(700, 9);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(130, 34);
            this.btnLookup.Text = "Look Up";

            this.pnlAccountDetail.BackColor = System.Drawing.Color.White;
            this.pnlAccountDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccountDetail.Controls.Add(this.lblDetailName);
            this.pnlAccountDetail.Controls.Add(this.lblDetailIban);
            this.pnlAccountDetail.Controls.Add(this.lblDetailBalance);
            this.pnlAccountDetail.Controls.Add(this.lblDetailStatus);
            this.pnlAccountDetail.Location = new System.Drawing.Point(25, 132);
            this.pnlAccountDetail.Name = "pnlAccountDetail";
            this.pnlAccountDetail.Size = new System.Drawing.Size(840, 60);
            this.pnlAccountDetail.Visible = false;

            this.dgvClientTransactions.Location = new System.Drawing.Point(25, 202);
            this.dgvClientTransactions.Name = "dgvClientTransactions";
            this.dgvClientTransactions.Size = new System.Drawing.Size(840, 400);
            this.dgvClientTransactions.Visible = false;

            this.pnlOpsButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpsButtons.Controls.Add(this.btnFreeze);
            this.pnlOpsButtons.Controls.Add(this.btnUnfreeze);
            this.pnlOpsButtons.Controls.Add(this.btnManualDeposit);
            this.pnlOpsButtons.Location = new System.Drawing.Point(25, 612);
            this.pnlOpsButtons.Name = "pnlOpsButtons";
            this.pnlOpsButtons.Size = new System.Drawing.Size(840, 50);
            this.pnlOpsButtons.Visible = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);

            this.panel1.ResumeLayout(false);
            this.btnPendingRequests.ResumeLayout(false);
            this.btnAccountOps.ResumeLayout(false);
            this.btnLogout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlPending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.pnlPendingActions.ResumeLayout(false);
            this.pnlAccountOps.ResumeLayout(false);
            this.pnlClientLookup.ResumeLayout(false);
            this.pnlClientLookup.PerformLayout();
            this.pnlAccountDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientTransactions)).EndInit();
            this.pnlOpsButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSistemBancar;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Panel btnPendingRequests;
        private System.Windows.Forms.Label lblBtnPending;
        private System.Windows.Forms.PictureBox picPending;
        private System.Windows.Forms.Panel btnAccountOps;
        private System.Windows.Forms.Label lblBtnAccountOps;
        private System.Windows.Forms.PictureBox picAccountOps;
        private System.Windows.Forms.Panel btnLogout;
        private System.Windows.Forms.Label lblBtnLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel pnlPending;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingSubtitle;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Panel pnlPendingActions;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefreshPending;
        private System.Windows.Forms.Label lblPendingNote;
        private System.Windows.Forms.Panel pnlAccountOps;
        private System.Windows.Forms.Label lblAccountOpsTitle;
        private System.Windows.Forms.Panel pnlClientLookup;
        private System.Windows.Forms.Label lblLookupHint;
        private System.Windows.Forms.TextBox txtLookupIban;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Panel pnlAccountDetail;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailIban;
        private System.Windows.Forms.Label lblDetailBalance;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.DataGridView dgvClientTransactions;
        private System.Windows.Forms.Panel pnlOpsButtons;
        private System.Windows.Forms.Button btnFreeze;
        private System.Windows.Forms.Button btnUnfreeze;
        private System.Windows.Forms.Button btnManualDeposit;
    }
}