namespace Sistem_Bancar
{
    partial class ClientDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sep3 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.sep2 = new System.Windows.Forms.Panel();
            this.btnNewTransfer = new System.Windows.Forms.Button();
            this.sep1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBalanceCard = new System.Windows.Forms.Panel();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.lblSelectedAccountInfo = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.pnlNewTransfer = new System.Windows.Forms.Panel();
            this.btnSendTransfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransferDescription = new System.Windows.Forms.TextBox();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.txtDestinationAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();

            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBalanceCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.pnlNewTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.sep3);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.sep2);
            this.panel1.Controls.Add(this.btnNewTransfer);
            this.panel1.Controls.Add(this.sep1);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 600);
            this.panel1.TabIndex = 0;

            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(9, 530);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(192, 46);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button3_Click);

            // sep3
            this.sep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.sep3.Location = new System.Drawing.Point(9, 284);
            this.sep3.Margin = new System.Windows.Forms.Padding(2);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(192, 2);
            this.sep3.TabIndex = 6;

            // btnHistory
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(9, 234);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(192, 46);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "   History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.button4_Click);

            // sep2
            this.sep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.sep2.Location = new System.Drawing.Point(9, 224);
            this.sep2.Margin = new System.Windows.Forms.Padding(2);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(192, 2);
            this.sep2.TabIndex = 4;

            // btnNewTransfer
            this.btnNewTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.btnNewTransfer.FlatAppearance.BorderSize = 0;
            this.btnNewTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransfer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewTransfer.ForeColor = System.Drawing.Color.White;
            this.btnNewTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransfer.Image")));
            this.btnNewTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTransfer.Location = new System.Drawing.Point(9, 174);
            this.btnNewTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewTransfer.Name = "btnNewTransfer";
            this.btnNewTransfer.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNewTransfer.Size = new System.Drawing.Size(192, 46);
            this.btnNewTransfer.TabIndex = 3;
            this.btnNewTransfer.Text = "   New Transfer";
            this.btnNewTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTransfer.UseVisualStyleBackColor = false;
            this.btnNewTransfer.Click += new System.EventHandler(this.button2_Click_1);

            // sep1
            this.sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.sep1.Location = new System.Drawing.Point(9, 164);
            this.sep1.Margin = new System.Windows.Forms.Padding(2);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(192, 2);
            this.sep1.TabIndex = 2;

            // btnDashboard
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(9, 114);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(192, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);

            // panelLogo
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.lblBankName);
            this.panelLogo.Controls.Add(this.lblUserName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 98);
            this.panelLogo.TabIndex = 0;

            // lblBankName
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBankName.ForeColor = System.Drawing.Color.White;
            this.lblBankName.Location = new System.Drawing.Point(15, 15);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(136, 25);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Sistem Bancar";

            // lblUserName
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.lblUserName.Location = new System.Drawing.Point(15, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Welcome, ...";

            // panel2 (Content Area)
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.pnlBalanceCard);
            this.panel2.Controls.Add(this.dgvAccounts);
            this.panel2.Controls.Add(this.pnlNewTransfer);
            this.panel2.Controls.Add(this.dgvTransactions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 600);
            this.panel2.TabIndex = 5;

            // pnlBalanceCard
            this.pnlBalanceCard.BackColor = System.Drawing.Color.White;
            this.pnlBalanceCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBalanceCard.Controls.Add(this.lblBalanceAmount);
            this.pnlBalanceCard.Controls.Add(this.lblBalanceTitle);
            this.pnlBalanceCard.Controls.Add(this.lblSelectedAccountInfo);
            this.pnlBalanceCard.Location = new System.Drawing.Point(20, 20);
            this.pnlBalanceCard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBalanceCard.Name = "pnlBalanceCard";
            this.pnlBalanceCard.Size = new System.Drawing.Size(600, 70);
            this.pnlBalanceCard.TabIndex = 0;

            // lblBalanceTitle
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBalanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblBalanceTitle.Location = new System.Drawing.Point(12, 10);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(106, 19);
            this.lblBalanceTitle.TabIndex = 0;
            this.lblBalanceTitle.Text = "Current Balance";

            // lblSelectedAccountInfo
            this.lblSelectedAccountInfo.AutoSize = true;
            this.lblSelectedAccountInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblSelectedAccountInfo.Location = new System.Drawing.Point(13, 35);
            this.lblSelectedAccountInfo.Name = "lblSelectedAccountInfo";
            this.lblSelectedAccountInfo.Size = new System.Drawing.Size(171, 15);
            this.lblSelectedAccountInfo.TabIndex = 2;
            this.lblSelectedAccountInfo.Text = "Selected: (no account selected)";

            // lblBalanceAmount
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.lblBalanceAmount.Location = new System.Drawing.Point(400, 18);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(134, 32);
            this.lblBalanceAmount.TabIndex = 1;
            this.lblBalanceAmount.Text = "$12,450.50";

            // dgvAccounts
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(20, 105);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Size = new System.Drawing.Size(600, 150);
            this.dgvAccounts.TabIndex = 6;

            // pnlNewTransfer
            this.pnlNewTransfer.BackColor = System.Drawing.Color.White;
            this.pnlNewTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewTransfer.Controls.Add(this.btnSendTransfer);
            this.pnlNewTransfer.Controls.Add(this.label3);
            this.pnlNewTransfer.Controls.Add(this.label2);
            this.pnlNewTransfer.Controls.Add(this.txtTransferDescription);
            this.pnlNewTransfer.Controls.Add(this.txtTransferAmount);
            this.pnlNewTransfer.Controls.Add(this.txtDestinationAccount);
            this.pnlNewTransfer.Controls.Add(this.label1);
            this.pnlNewTransfer.Location = new System.Drawing.Point(20, 270);
            this.pnlNewTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNewTransfer.Name = "pnlNewTransfer";
            this.pnlNewTransfer.Size = new System.Drawing.Size(600, 310);
            this.pnlNewTransfer.TabIndex = 3;
            this.pnlNewTransfer.Visible = false;

            // label1 (IBAN)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number (IBAN):";

            // txtDestinationAccount
            this.txtDestinationAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestinationAccount.Location = new System.Drawing.Point(23, 40);
            this.txtDestinationAccount.Name = "txtDestinationAccount";
            this.txtDestinationAccount.Size = new System.Drawing.Size(300, 25);
            this.txtDestinationAccount.TabIndex = 1;

            // label2 (Sum)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount:";

            // txtTransferAmount
            this.txtTransferAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTransferAmount.Location = new System.Drawing.Point(23, 100);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(150, 25);
            this.txtTransferAmount.TabIndex = 2;

            // label3 (Details)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Details:";

            // txtTransferDescription
            this.txtTransferDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTransferDescription.Location = new System.Drawing.Point(23, 160);
            this.txtTransferDescription.Name = "txtTransferDescription";
            this.txtTransferDescription.Size = new System.Drawing.Size(550, 25);
            this.txtTransferDescription.TabIndex = 3;

            // btnSendTransfer
            this.btnSendTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendTransfer.Location = new System.Drawing.Point(420, 230);
            this.btnSendTransfer.Name = "btnSendTransfer";
            this.btnSendTransfer.Size = new System.Drawing.Size(153, 46);
            this.btnSendTransfer.TabIndex = 6;
            this.btnSendTransfer.Text = "Send Transfer";
            this.btnSendTransfer.UseVisualStyleBackColor = true;
            this.btnSendTransfer.Click += new System.EventHandler(this.btnSendTransfer_Click);

            // dgvTransactions
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(20, 270);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(600, 310);
            this.dgvTransactions.TabIndex = 2;

            // ClientDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDashboard";
            this.Load += new System.EventHandler(this.ClientDashboard_Load);

            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlBalanceCard.ResumeLayout(false);
            this.pnlBalanceCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.pnlNewTransfer.ResumeLayout(false);
            this.pnlNewTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel sep1;
        private System.Windows.Forms.Button btnNewTransfer;
        private System.Windows.Forms.Panel sep2;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel sep3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBalanceCard;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label lblBalanceTitle;
        private System.Windows.Forms.Label lblSelectedAccountInfo;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Panel pnlNewTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinationAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTransferDescription;
        private System.Windows.Forms.Button btnSendTransfer;
    }
}