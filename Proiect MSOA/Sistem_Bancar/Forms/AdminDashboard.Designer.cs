namespace Sistem_Bancar
{
    partial class AdminDashboard
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
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblSistemBancar = new System.Windows.Forms.Label();
            this.btnOverview = new System.Windows.Forms.Panel();
            this.lblBtnOverview = new System.Windows.Forms.Label();
            this.picOverview = new System.Windows.Forms.PictureBox();
            this.btnManageUsers = new System.Windows.Forms.Panel();
            this.lblBtnManageUsers = new System.Windows.Forms.Label();
            this.picManageUsers = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.Panel();
            this.lblBtnReports = new System.Windows.Forms.Label();
            this.picReports = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Panel();
            this.lblBtnLogout = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.lblOverviewTitle = new System.Windows.Forms.Label();
            this.pnlStatTotalUsers = new System.Windows.Forms.Panel();
            this.lblStatTotalUsersTitle = new System.Windows.Forms.Label();
            this.lblStatTotalUsersValue = new System.Windows.Forms.Label();
            this.pnlStatTotalTx = new System.Windows.Forms.Panel();
            this.lblStatTotalTxTitle = new System.Windows.Forms.Label();
            this.lblStatTotalTxValue = new System.Windows.Forms.Label();
            this.pnlStatSystemStatus = new System.Windows.Forms.Panel();
            this.lblStatSystemStatusTitle = new System.Windows.Forms.Label();
            this.lblStatSystemStatusValue = new System.Windows.Forms.Label();
            this.lblRecentActivityTitle = new System.Windows.Forms.Label();
            this.dgvRecentActivity = new System.Windows.Forms.DataGridView();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.lblManageUsersTitle = new System.Windows.Forms.Label();
            this.pnlUserSearchBar = new System.Windows.Forms.Panel();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlUserActions = new System.Windows.Forms.Panel();
            this.btnActivateUser = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.btnViewUserAccounts = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.dgvAllTransactions = new System.Windows.Forms.DataGridView();
            this.pnlReportFilters = new System.Windows.Forms.Panel();
            this.lblFilterFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            this.btnOverview.SuspendLayout();
            this.btnManageUsers.SuspendLayout();
            this.btnReports.SuspendLayout();
            this.btnLogout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.pnlStatTotalUsers.SuspendLayout();
            this.pnlStatTotalTx.SuspendLayout();
            this.pnlStatSystemStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).BeginInit();
            this.pnlManageUsers.SuspendLayout();
            this.pnlUserSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlUserActions.SuspendLayout();
            this.pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransactions)).BeginInit();
            this.pnlReportFilters.SuspendLayout();
            this.SuspendLayout();

            this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.panel1.Controls.Add(this.lblSistemBancar);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.btnOverview);
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 720);
            this.panel1.TabIndex = 0;

            this.lblSistemBancar.AutoSize = false;
            this.lblSistemBancar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSistemBancar.ForeColor = System.Drawing.Color.White;
            this.lblSistemBancar.Location = new System.Drawing.Point(10, 20);
            this.lblSistemBancar.Name = "lblSistemBancar";
            this.lblSistemBancar.Size = new System.Drawing.Size(190, 30);
            this.lblSistemBancar.Text = "Sistem Bancar";
            this.lblSistemBancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblAdminName.AutoSize = false;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(160, 180, 210);
            this.lblAdminName.Location = new System.Drawing.Point(10, 52);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(190, 20);
            this.lblAdminName.Text = "Welcome, Admin";

            this.btnOverview.BackColor = System.Drawing.Color.FromArgb(50, 65, 95);
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.Location = new System.Drawing.Point(0, 90);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(210, 55);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.Controls.Add(this.picOverview);
            this.btnOverview.Controls.Add(this.lblBtnOverview);

            this.picOverview.Image = System.Drawing.SystemIcons.Shield.ToBitmap();
            this.picOverview.Location = new System.Drawing.Point(18, 14);
            this.picOverview.Name = "picOverview";
            this.picOverview.Size = new System.Drawing.Size(26, 26);
            this.picOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnOverview.AutoSize = false;
            this.lblBtnOverview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnOverview.ForeColor = System.Drawing.Color.White;
            this.lblBtnOverview.Location = new System.Drawing.Point(54, 16);
            this.lblBtnOverview.Name = "lblBtnOverview";
            this.lblBtnOverview.Size = new System.Drawing.Size(140, 22);
            this.lblBtnOverview.Text = "Overview";

            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 150);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(210, 55);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Controls.Add(this.picManageUsers);
            this.btnManageUsers.Controls.Add(this.lblBtnManageUsers);

            this.picManageUsers.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            this.picManageUsers.Location = new System.Drawing.Point(18, 14);
            this.picManageUsers.Name = "picManageUsers";
            this.picManageUsers.Size = new System.Drawing.Size(26, 26);
            this.picManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnManageUsers.AutoSize = false;
            this.lblBtnManageUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnManageUsers.ForeColor = System.Drawing.Color.White;
            this.lblBtnManageUsers.Location = new System.Drawing.Point(54, 16);
            this.lblBtnManageUsers.Name = "lblBtnManageUsers";
            this.lblBtnManageUsers.Size = new System.Drawing.Size(140, 22);
            this.lblBtnManageUsers.Text = "Manage Users";

            this.btnReports.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Location = new System.Drawing.Point(0, 210);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 55);
            this.btnReports.TabIndex = 3;
            this.btnReports.Controls.Add(this.picReports);
            this.btnReports.Controls.Add(this.lblBtnReports);

            this.picReports.Image = System.Drawing.SystemIcons.Asterisk.ToBitmap();
            this.picReports.Location = new System.Drawing.Point(18, 14);
            this.picReports.Name = "picReports";
            this.picReports.Size = new System.Drawing.Size(26, 26);
            this.picReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnReports.AutoSize = false;
            this.lblBtnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnReports.ForeColor = System.Drawing.Color.White;
            this.lblBtnReports.Location = new System.Drawing.Point(54, 16);
            this.lblBtnReports.Name = "lblBtnReports";
            this.lblBtnReports.Size = new System.Drawing.Size(140, 22);
            this.lblBtnReports.Text = "Reports";

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 60, 50);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(0, 660);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 55);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Controls.Add(this.picLogout);
            this.btnLogout.Controls.Add(this.lblBtnLogout);

            this.picLogout.Image = System.Drawing.SystemIcons.Warning.ToBitmap();
            this.picLogout.Location = new System.Drawing.Point(18, 14);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(26, 26);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblBtnLogout.AutoSize = false;
            this.lblBtnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBtnLogout.ForeColor = System.Drawing.Color.White;
            this.lblBtnLogout.Location = new System.Drawing.Point(54, 16);
            this.lblBtnLogout.Name = "lblBtnLogout";
            this.lblBtnLogout.Size = new System.Drawing.Size(140, 22);
            this.lblBtnLogout.Text = "Logout";

            this.panel2.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.panel2.Controls.Add(this.pnlOverview);
            this.panel2.Controls.Add(this.pnlManageUsers);
            this.panel2.Controls.Add(this.pnlReports);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 720);
            this.panel2.TabIndex = 1;

            this.pnlOverview.BackColor = System.Drawing.Color.Transparent;
            this.pnlOverview.Controls.Add(this.lblOverviewTitle);
            this.pnlOverview.Controls.Add(this.pnlStatTotalUsers);
            this.pnlOverview.Controls.Add(this.pnlStatTotalTx);
            this.pnlOverview.Controls.Add(this.pnlStatSystemStatus);
            this.pnlOverview.Controls.Add(this.lblRecentActivityTitle);
            this.pnlOverview.Controls.Add(this.dgvRecentActivity);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(890, 720);
            this.pnlOverview.Visible = true;

            this.lblOverviewTitle.AutoSize = false;
            this.lblOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOverviewTitle.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.lblOverviewTitle.Location = new System.Drawing.Point(25, 20);
            this.lblOverviewTitle.Name = "lblOverviewTitle";
            this.lblOverviewTitle.Size = new System.Drawing.Size(300, 36);
            this.lblOverviewTitle.Text = "Admin Overview";

            this.pnlStatTotalUsers.Name = "pnlStatTotalUsers";
            this.pnlStatTotalTx.Name = "pnlStatTotalTx";
            this.pnlStatSystemStatus.Name = "pnlStatSystemStatus";

            this.lblRecentActivityTitle.AutoSize = false;
            this.lblRecentActivityTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivityTitle.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.lblRecentActivityTitle.Location = new System.Drawing.Point(25, 200);
            this.lblRecentActivityTitle.Name = "lblRecentActivityTitle";
            this.lblRecentActivityTitle.Size = new System.Drawing.Size(250, 26);
            this.lblRecentActivityTitle.Text = "Recent Activity";

            this.dgvRecentActivity.Location = new System.Drawing.Point(25, 230);
            this.dgvRecentActivity.Name = "dgvRecentActivity";
            this.dgvRecentActivity.Size = new System.Drawing.Size(840, 450);
            this.dgvRecentActivity.TabIndex = 10;

            this.pnlManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.pnlManageUsers.Controls.Add(this.lblManageUsersTitle);
            this.pnlManageUsers.Controls.Add(this.pnlUserSearchBar);
            this.pnlManageUsers.Controls.Add(this.dgvUsers);
            this.pnlManageUsers.Controls.Add(this.pnlUserActions);
            this.pnlManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(890, 720);
            this.pnlManageUsers.Visible = false;

            this.lblManageUsersTitle.AutoSize = false;
            this.lblManageUsersTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblManageUsersTitle.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.lblManageUsersTitle.Location = new System.Drawing.Point(25, 20);
            this.lblManageUsersTitle.Name = "lblManageUsersTitle";
            this.lblManageUsersTitle.Size = new System.Drawing.Size(300, 36);
            this.lblManageUsersTitle.Text = "Manage Users";

            this.pnlUserSearchBar.BackColor = System.Drawing.Color.White;
            this.pnlUserSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserSearchBar.Controls.Add(this.txtSearchUser);
            this.pnlUserSearchBar.Controls.Add(this.btnSearchUser);
            this.pnlUserSearchBar.Location = new System.Drawing.Point(25, 70);
            this.pnlUserSearchBar.Name = "pnlUserSearchBar";
            this.pnlUserSearchBar.Size = new System.Drawing.Size(840, 44);

            this.txtSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchUser.Location = new System.Drawing.Point(10, 10);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(680, 22);

            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(700, 5);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(130, 32);
            this.btnSearchUser.Text = "Search";

            this.dgvUsers.Location = new System.Drawing.Point(25, 125);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(840, 420);
            this.dgvUsers.TabIndex = 20;

            this.pnlUserActions.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserActions.Controls.Add(this.btnActivateUser);
            this.pnlUserActions.Controls.Add(this.btnDeactivateUser);
            this.pnlUserActions.Controls.Add(this.btnResetUserPassword);
            this.pnlUserActions.Controls.Add(this.btnViewUserAccounts);
            this.pnlUserActions.Location = new System.Drawing.Point(25, 555);
            this.pnlUserActions.Name = "pnlUserActions";
            this.pnlUserActions.Size = new System.Drawing.Size(840, 50);

            this.pnlReports.BackColor = System.Drawing.Color.Transparent;
            this.pnlReports.Controls.Add(this.lblReportsTitle);
            this.pnlReports.Controls.Add(this.pnlReportFilters);
            this.pnlReports.Controls.Add(this.dgvAllTransactions);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(890, 720);
            this.pnlReports.Visible = false;

            this.lblReportsTitle.AutoSize = false;
            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.lblReportsTitle.Location = new System.Drawing.Point(25, 20);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(300, 36);
            this.lblReportsTitle.Text = "Transaction Reports";

            this.pnlReportFilters.BackColor = System.Drawing.Color.White;
            this.pnlReportFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportFilters.Controls.Add(this.lblFilterFrom);
            this.pnlReportFilters.Controls.Add(this.dtpFrom);
            this.pnlReportFilters.Controls.Add(this.lblFilterTo);
            this.pnlReportFilters.Controls.Add(this.dtpTo);
            this.pnlReportFilters.Controls.Add(this.btnApplyFilter);
            this.pnlReportFilters.Controls.Add(this.btnExportCsv);
            this.pnlReportFilters.Location = new System.Drawing.Point(25, 68);
            this.pnlReportFilters.Name = "pnlReportFilters";
            this.pnlReportFilters.Size = new System.Drawing.Size(840, 54);

            this.lblFilterFrom.AutoSize = true;
            this.lblFilterFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterFrom.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblFilterFrom.Location = new System.Drawing.Point(10, 17);
            this.lblFilterFrom.Text = "From:";

            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(52, 13);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 22);

            this.lblFilterTo.AutoSize = true;
            this.lblFilterTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterTo.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblFilterTo.Location = new System.Drawing.Point(185, 17);
            this.lblFilterTo.Text = "To:";

            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(210, 13);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 22);

            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(345, 10);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(110, 32);
            this.btnApplyFilter.Text = "Apply Filter";

            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(34, 160, 100);
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.FlatAppearance.BorderSize = 0;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.Location = new System.Drawing.Point(465, 10);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(110, 32);
            this.btnExportCsv.Text = "Export CSV";

            this.dgvAllTransactions.Location = new System.Drawing.Point(25, 132);
            this.dgvAllTransactions.Name = "dgvAllTransactions";
            this.dgvAllTransactions.Size = new System.Drawing.Size(840, 540);
            this.dgvAllTransactions.TabIndex = 30;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);

            this.panel1.ResumeLayout(false);
            this.btnOverview.ResumeLayout(false);
            this.btnManageUsers.ResumeLayout(false);
            this.btnReports.ResumeLayout(false);
            this.btnLogout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.pnlStatTotalUsers.ResumeLayout(false);
            this.pnlStatTotalTx.ResumeLayout(false);
            this.pnlStatSystemStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).EndInit();
            this.pnlManageUsers.ResumeLayout(false);
            this.pnlUserSearchBar.ResumeLayout(false);
            this.pnlUserSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlUserActions.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransactions)).EndInit();
            this.pnlReportFilters.ResumeLayout(false);
            this.pnlReportFilters.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSistemBancar;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel btnOverview;
        private System.Windows.Forms.Label lblBtnOverview;
        private System.Windows.Forms.PictureBox picOverview;
        private System.Windows.Forms.Panel btnManageUsers;
        private System.Windows.Forms.Label lblBtnManageUsers;
        private System.Windows.Forms.PictureBox picManageUsers;
        private System.Windows.Forms.Panel btnReports;
        private System.Windows.Forms.Label lblBtnReports;
        private System.Windows.Forms.PictureBox picReports;
        private System.Windows.Forms.Panel btnLogout;
        private System.Windows.Forms.Label lblBtnLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Label lblOverviewTitle;
        private System.Windows.Forms.Panel pnlStatTotalUsers;
        private System.Windows.Forms.Label lblStatTotalUsersTitle;
        private System.Windows.Forms.Label lblStatTotalUsersValue;
        private System.Windows.Forms.Panel pnlStatTotalTx;
        private System.Windows.Forms.Label lblStatTotalTxTitle;
        private System.Windows.Forms.Label lblStatTotalTxValue;
        private System.Windows.Forms.Panel pnlStatSystemStatus;
        private System.Windows.Forms.Label lblStatSystemStatusTitle;
        private System.Windows.Forms.Label lblStatSystemStatusValue;
        private System.Windows.Forms.Label lblRecentActivityTitle;
        private System.Windows.Forms.DataGridView dgvRecentActivity;
        private System.Windows.Forms.Panel pnlManageUsers;
        private System.Windows.Forms.Label lblManageUsersTitle;
        private System.Windows.Forms.Panel pnlUserSearchBar;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlUserActions;
        private System.Windows.Forms.Button btnActivateUser;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetUserPassword;
        private System.Windows.Forms.Button btnViewUserAccounts;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Panel pnlReportFilters;
        private System.Windows.Forms.Label lblFilterFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFilterTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.DataGridView dgvAllTransactions;
    }
}