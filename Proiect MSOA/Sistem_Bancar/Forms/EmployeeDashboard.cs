using System;
using System.Data;
using System.Windows.Forms;
using Sistem_Bancar.DataAccess;

namespace Sistem_Bancar
{
    public partial class EmployeeDashboard : Form
    {
        private readonly int _employeeUserId;
        private int _currentAccountId = -1;

        public EmployeeDashboard(int employeeUserId)
        {
            _employeeUserId = employeeUserId;
            InitializeComponent();

            //
            ApplyCustomStyles();

            WireNavEvents();
        }

        private void ApplyCustomStyles()
        {
            // Pending Requests Styling
            StyleDataGridView(this.dgvPending);
            StyleButton(this.btnApprove, "✔  Approve", 0, System.Drawing.Color.FromArgb(34, 160, 100));
            StyleButton(this.btnReject, "✘  Reject", 165, System.Drawing.Color.FromArgb(200, 60, 50));
            StyleButton(this.btnRefreshPending, "↺  Refresh", 330, System.Drawing.Color.FromArgb(30, 42, 68));

            // Account Operations Styling
            SetupDetailLabel(this.lblDetailName, 10, "Owner: —", System.Drawing.FontStyle.Bold);
            SetupDetailLabel(this.lblDetailIban, 200, "IBAN: —", System.Drawing.FontStyle.Regular);
            SetupDetailLabel(this.lblDetailBalance, 500, "Balance: —", System.Drawing.FontStyle.Regular);
            SetupDetailLabel(this.lblDetailStatus, 680, "Status: —", System.Drawing.FontStyle.Regular);

            StyleDataGridView(this.dgvClientTransactions);

            StyleButton(this.btnFreeze, "❄  Freeze Account", 0, System.Drawing.Color.FromArgb(30, 100, 180));
            StyleButton(this.btnUnfreeze, "✔  Unfreeze Account", 175, System.Drawing.Color.FromArgb(34, 160, 100));
            StyleButton(this.btnManualDeposit, "＋  Manual Deposit", 350, System.Drawing.Color.FromArgb(30, 42, 68));
        }

        // ── Helpers ──────────────────────────────────────────────────
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

        private void StyleButton(System.Windows.Forms.Button btn, string text, int x, System.Drawing.Color color)
        {
            btn.BackColor = color;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, 8);
            btn.Size = new System.Drawing.Size(160, 34);
            btn.Text = text;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void SetupDetailLabel(System.Windows.Forms.Label lbl, int x, string text, System.Drawing.FontStyle style)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, style);
            lbl.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            lbl.Location = new System.Drawing.Point(x, 20);
            lbl.Size = new System.Drawing.Size(180, 20);
            lbl.Text = text;
        }

        // ── Wire sidebar click events ─────────────────────────────────
        private void WireNavEvents()
        {
            WireNavPanel(btnPendingRequests, lblBtnPending, picPending, ShowPending);
            WireNavPanel(btnAccountOps, lblBtnAccountOps, picAccountOps, ShowAccountOps);
            WireNavPanel(btnLogout, lblBtnLogout, picLogout, DoLogout);

            btnApprove.Click += (s, e) => HandleRequest(true);
            btnReject.Click += (s, e) => HandleRequest(false);
            btnRefreshPending.Click += (s, e) => LoadPendingRequests();
            btnLookup.Click += (s, e) => LookupAccount();
            txtLookupIban.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) LookupAccount(); };
            btnFreeze.Click += (s, e) => SetAccountFrozen(true);
            btnUnfreeze.Click += (s, e) => SetAccountFrozen(false);
            btnManualDeposit.Click += (s, e) => DoManualDeposit();
        }

        private static void WireNavPanel(Panel nav, Label lbl, PictureBox pic, Action action)
        {
            nav.Click += (s, e) => action();
            lbl.Click += (s, e) => action();
            pic.Click += (s, e) => action();
        }

        // ── Form load ─────────────────────────────────────────────────
        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var user = Database.GetUserById(_employeeUserId);
                if (user != null)
                    lblEmployeeName.Text = $"Welcome, {user.Username}";
            }
            catch { /* best effort */ }

            ShowPending();
        }

        // ── Navigation ───────────────────────────────────────────────
        private static readonly System.Drawing.Color ActiveColor = System.Drawing.Color.FromArgb(50, 65, 95);
        private static readonly System.Drawing.Color InactiveColor = System.Drawing.Color.FromArgb(30, 42, 68);

        private void SetActive(Panel active)
        {
            foreach (var p in new[] { btnPendingRequests, btnAccountOps })
                p.BackColor = (p == active) ? ActiveColor : InactiveColor;
        }

        private void ShowPending()
        {
            SetActive(btnPendingRequests);
            pnlPending.Visible = true;
            pnlAccountOps.Visible = false;
            LoadPendingRequests();
        }

        private void ShowAccountOps()
        {
            SetActive(btnAccountOps);
            pnlPending.Visible = false;
            pnlAccountOps.Visible = true;
        }

        private void DoLogout()
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // ── Pending Requests ─────────────────────────────────────────
        private void LoadPendingRequests()
        {
            try
            {
                var dt = Database.GetPendingAccountRequests();
                dgvPending.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedRequestId()
        {
            if (dgvPending.CurrentRow == null) return -1;
            var cell = dgvPending.CurrentRow.Cells["Id"];
            if (cell?.Value == null) return -1;
            return Convert.ToInt32(cell.Value);
        }

        private void HandleRequest(bool approve)
        {
            int requestId = GetSelectedRequestId();
            if (requestId < 0)
            {
                MessageBox.Show("Please select a request first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string action = approve ? "approve" : "reject";
            var confirm = MessageBox.Show($"Are you sure you want to {action} this request?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Database.ProcessAccountRequest(requestId, approve, _employeeUserId);
                MessageBox.Show($"Request {(approve ? "approved" : "rejected")} successfully.",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Account Operations ────────────────────────────────────────
        private void LookupAccount()
        {
            var iban = txtLookupIban.Text.Trim();
            if (string.IsNullOrWhiteSpace(iban))
            {
                MessageBox.Show("Please enter an IBAN.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var accountRow = Database.GetAccountByAccountNumber(iban);
                if (accountRow == null)
                {
                    MessageBox.Show("No account found with that IBAN.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlAccountDetail.Visible = false;
                    dgvClientTransactions.Visible = false;
                    pnlOpsButtons.Visible = false;
                    return;
                }

                _currentAccountId = Convert.ToInt32(accountRow["Id"]);

                // populate detail strip
                lblDetailName.Text = "Owner: " + (accountRow.Table.Columns.Contains("OwnerName")
                                            ? accountRow["OwnerName"]?.ToString() : "N/A");
                lblDetailIban.Text = "IBAN: " + accountRow["AccountNumber"]?.ToString();
                lblDetailBalance.Text = "Balance: " + Convert.ToDecimal(accountRow["Balance"]).ToString("C2");
                lblDetailStatus.Text = "Status: " + (accountRow.Table.Columns.Contains("Status")
                                            ? accountRow["Status"]?.ToString() : "Active");

                pnlAccountDetail.Visible = true;

                // load transactions
                var tx = Database.GetTransactionsByAccountId(_currentAccountId);
                dgvClientTransactions.DataSource = tx;
                dgvClientTransactions.Visible = true;

                pnlOpsButtons.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lookup failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetAccountFrozen(bool freeze)
        {
            if (_currentAccountId < 0)
            {
                MessageBox.Show("Look up an account first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Database.SetAccountFrozen(_currentAccountId, freeze);
                MessageBox.Show(freeze ? "Account frozen." : "Account unfrozen.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LookupAccount(); // refresh detail strip
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoManualDeposit()
        {
            if (_currentAccountId < 0)
            {
                MessageBox.Show("Look up an account first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter amount to deposit:", "Manual Deposit", "0.00");
            if (string.IsNullOrWhiteSpace(input)) return;

            if (!decimal.TryParse(input, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.InvariantCulture, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Database.ManualDeposit(_currentAccountId, amount, $"Manual deposit by employee #{_employeeUserId}");
                MessageBox.Show($"Deposited {amount:C2} successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LookupAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deposit failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}