using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sistem_Bancar.DataAccess;

namespace Sistem_Bancar
{
    public partial class AdminDashboard : Form
    {
        private readonly int _adminUserId;

        public AdminDashboard(int adminUserId)
        {
            _adminUserId = adminUserId;
            InitializeComponent();

            
            ApplyCustomStyles();

            WireNavEvents();
        }

        private void ApplyCustomStyles()
        {
            // Setup Stat Cards
            SetupStatCard(this.pnlStatTotalUsers, this.lblStatTotalUsersTitle, this.lblStatTotalUsersValue, 25, 70, "Total Users", "—");
            SetupStatCard(this.pnlStatTotalTx, this.lblStatTotalTxTitle, this.lblStatTotalTxValue, 215, 70, "Total Transactions", "—");
            SetupStatCard(this.pnlStatSystemStatus, this.lblStatSystemStatusTitle, this.lblStatSystemStatusValue, 405, 70, "System Status", "Online");
            this.lblStatSystemStatusValue.ForeColor = System.Drawing.Color.FromArgb(34, 160, 100);

            // Style DataGridViews
            StyleDataGridView(this.dgvRecentActivity);
            StyleDataGridView(this.dgvUsers);
            StyleDataGridView(this.dgvAllTransactions);

             
            Button btnDeleteUser = new Button();
            StyleActionButton(btnDeleteUser, "Delete User", 660, System.Drawing.Color.FromArgb(180, 40, 40));
            btnDeleteUser.Click += (s, e) => DeleteSelectedUser();
            this.pnlUserActions.Controls.Add(btnDeleteUser);

            // Style Action Buttons
            StyleActionButton(this.btnActivateUser, "Activate", 0, System.Drawing.Color.FromArgb(34, 160, 100));
            StyleActionButton(this.btnDeactivateUser, "Deactivate", 165, System.Drawing.Color.FromArgb(200, 60, 50));
            StyleActionButton(this.btnResetUserPassword, "Reset Password", 330, System.Drawing.Color.FromArgb(220, 140, 30));
            StyleActionButton(this.btnViewUserAccounts, "View Accounts", 495, System.Drawing.Color.FromArgb(30, 42, 68));
        }

        // ── Helper: stat card ──────────────────────────────────────────
        private void SetupStatCard(System.Windows.Forms.Panel card, System.Windows.Forms.Label lblTitle, System.Windows.Forms.Label lblValue, int x, int y, string title, string value)
        {
            card.BackColor = System.Drawing.Color.White;
            card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            card.Location = new System.Drawing.Point(x, y);
            card.Size = new System.Drawing.Size(175, 100);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            lblTitle.AutoSize = false;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            lblTitle.Location = new System.Drawing.Point(12, 14);
            lblTitle.Size = new System.Drawing.Size(150, 18);
            lblTitle.Text = title;

            lblValue.AutoSize = false;
            lblValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            lblValue.Location = new System.Drawing.Point(10, 38);
            lblValue.Size = new System.Drawing.Size(154, 48);
            lblValue.Text = value;
        }

        // ── Helper: style data grid view ──────────────────────────────
        private void StyleDataGridView(System.Windows.Forms.DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 42, 68);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeight = 36;
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 220, 240);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 42, 68);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.FromArgb(220, 225, 235);
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 30;
        }

        // ── Helper: action button ──────────────────────────────────────
        private void StyleActionButton(System.Windows.Forms.Button btn, string text, int x, System.Drawing.Color color)
        {
            btn.BackColor = color;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, 8);
            btn.Name = "btn" + text.Replace(" ", "");
            btn.Size = new System.Drawing.Size(150, 34);
            btn.Text = text;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // ── Wire sidebar click events ──────────────────────────────────
        private void WireNavEvents()
        {
            WireNavPanel(btnOverview, lblBtnOverview, picOverview, ShowOverview);
            WireNavPanel(btnManageUsers, lblBtnManageUsers, picManageUsers, ShowManageUsers);
            WireNavPanel(btnReports, lblBtnReports, picReports, ShowReports);
            WireNavPanel(btnLogout, lblBtnLogout, picLogout, DoLogout);

            btnSearchUser.Click += (s, e) => LoadUsers(txtSearchUser.Text.Trim());
            txtSearchUser.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) LoadUsers(txtSearchUser.Text.Trim()); };
            btnActivateUser.Click += (s, e) => SetUserActive(true);
            btnDeactivateUser.Click += (s, e) => SetUserActive(false);
            btnResetUserPassword.Click += (s, e) => ResetSelectedUserPassword();
            btnViewUserAccounts.Click += (s, e) => ViewSelectedUserAccounts();
            btnApplyFilter.Click += (s, e) => LoadTransactionReport();
            btnExportCsv.Click += (s, e) => ExportTransactionsToCsv();
        }

        private static void WireNavPanel(Panel nav, Label lbl, PictureBox pic, Action action)
        {
            nav.Click += (s, e) => action();
            lbl.Click += (s, e) => action();
            pic.Click += (s, e) => action();
        }

        // ── Form load ──────────────────────────────────────────────────
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var user = Database.GetUserById(_adminUserId);
                if (user != null)
                    lblAdminName.Text = $"Welcome, {user.Username}";
            }
            catch { /* best effort */ }

            ShowOverview();
        }

        // ── Navigation ────────────────────────────────────────────────
        private void ShowOverview()
        {
            SetActive(btnOverview);
            pnlOverview.Visible = true;
            pnlManageUsers.Visible = false;
            pnlReports.Visible = false;
            LoadOverviewStats();
            LoadRecentActivity();
        }

        private void ShowManageUsers()
        {
            SetActive(btnManageUsers);
            pnlOverview.Visible = false;
            pnlManageUsers.Visible = true;
            pnlReports.Visible = false;
            LoadUsers(string.Empty);
        }

        private void ShowReports()
        {
            SetActive(btnReports);
            pnlOverview.Visible = false;
            pnlManageUsers.Visible = false;
            pnlReports.Visible = true;
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            LoadTransactionReport();
        }

        private void DoLogout()
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // ── Highlight active sidebar button ──────────────────────────
        private static readonly System.Drawing.Color ActiveColor = System.Drawing.Color.FromArgb(50, 65, 95);
        private static readonly System.Drawing.Color InactiveColor = System.Drawing.Color.FromArgb(30, 42, 68);

        private void SetActive(Panel active)
        {
            foreach (var p in new[] { btnOverview, btnManageUsers, btnReports })
                p.BackColor = (p == active) ? ActiveColor : InactiveColor;
        }

        // ── Overview ──────────────────────────────────────────────────
        private void LoadOverviewStats()
        {
            try
            {
                lblStatTotalUsersValue.Text = Database.GetTotalUserCount().ToString();
                lblStatTotalTxValue.Text = Database.GetTotalTransactionCount().ToString();
                lblStatSystemStatusValue.Text = "Online";
                lblStatSystemStatusValue.ForeColor = System.Drawing.Color.FromArgb(34, 160, 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentActivity()
        {
            try
            {
                var dt = Database.GetRecentTransactions(50);
                dgvRecentActivity.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Manage Users ──────────────────────────────────────────────
        private void LoadUsers(string filter)
        {
            try
            {
                var dt = Database.GetAllUsers(filter);
                dgvUsers.DataSource = dt;
                if (dgvUsers.Columns.Contains("PasswordHash"))
                    dgvUsers.Columns["PasswordHash"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedUserId()
        {
            if (dgvUsers.CurrentRow == null) return -1;
            var cell = dgvUsers.CurrentRow.Cells["Id"];
            if (cell?.Value == null) return -1;
            return Convert.ToInt32(cell.Value);
        }

        private void SetUserActive(bool active)
        {
            int userId = GetSelectedUserId();
            if (userId < 0)
            {
                MessageBox.Show("Please select a user first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Database.SetUserActive(userId, active);
                MessageBox.Show(active ? "User activated." : "User deactivated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers(txtSearchUser.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteSelectedUser()
        {
            int userId = GetSelectedUserId();
            if (userId < 0)
            {
                MessageBox.Show("Please select a user first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to permanently delete this user, their accounts, and all their transactions? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Database.DeleteUserFull(userId);
                    MessageBox.Show("User and all associated data deleted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers(txtSearchUser.Text.Trim()); // Refresh la tabel
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetSelectedUserPassword()
        {
            int userId = GetSelectedUserId();
            if (userId < 0)
            {
                MessageBox.Show("Please select a user first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newPass = Guid.NewGuid().ToString("N").Substring(0, 10);
            try
            {
                Database.ResetUserPassword(userId, newPass);
                MessageBox.Show($"Password reset. Temporary password: {newPass}", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewSelectedUserAccounts()
        {
            int userId = GetSelectedUserId();
            if (userId < 0)
            {
                MessageBox.Show("Please select a user first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var dt = Database.GetAccountsByUserId(userId);
                var popup = new Form
                {
                    Text = "User Accounts",
                    Size = new System.Drawing.Size(700, 400),
                    StartPosition = FormStartPosition.CenterParent
                };
                var grid = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dt
                };
                popup.Controls.Add(grid);
                popup.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Reports ───────────────────────────────────────────────────
        private void LoadTransactionReport()
        {
            try
            {
                var dt = Database.GetAllTransactions(dtpFrom.Value.Date, dtpTo.Value.Date.AddDays(1).AddTicks(-1));
                dgvAllTransactions.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportTransactionsToCsv()
        {
            if (dgvAllTransactions.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                FileName = $"transactions_{DateTime.Today:yyyy-MM-dd}.csv"
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new StringBuilder();
                    var headers = new System.Collections.Generic.List<string>();
                    foreach (DataGridViewColumn col in dgvAllTransactions.Columns)
                        if (col.Visible) headers.Add($"\"{col.HeaderText}\"");
                    sb.AppendLine(string.Join(",", headers));

                    foreach (DataGridViewRow row in dgvAllTransactions.Rows)
                    {
                        var cells = new System.Collections.Generic.List<string>();
                        foreach (DataGridViewColumn col in dgvAllTransactions.Columns)
                            if (col.Visible) cells.Add($"\"{row.Cells[col.Index].Value}\"");
                        sb.AppendLine(string.Join(",", cells));
                    }

                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}