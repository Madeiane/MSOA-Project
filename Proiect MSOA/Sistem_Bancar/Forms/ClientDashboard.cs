using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Sistem_Bancar.DataAccess;

namespace Sistem_Bancar
{
    public partial class ClientDashboard : Form
    {
        private readonly int _userId;

        public ClientDashboard(int userId)
        {
            _userId = userId;
            InitializeComponent();
            ApplyCustomStyles();

            // Hook up the selection event to the grid that now lives in the Designer
            dgvAccounts.SelectionChanged += dgvAccounts_SelectionChanged;
        }

        private void ApplyCustomStyles()
        {
            // Style the tables
            StyleDataGridView(dgvAccounts);
            StyleDataGridView(dgvTransactions);

            // Style the Send Transfer Button
            btnSendTransfer.BackColor = System.Drawing.Color.FromArgb(34, 160, 100);
            btnSendTransfer.ForeColor = System.Drawing.Color.White;
            btnSendTransfer.FlatStyle = FlatStyle.Flat;
            btnSendTransfer.FlatAppearance.BorderSize = 0;
            btnSendTransfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 30;
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            dgvTransactions.ColumnCount = 4;
            dgvTransactions.Columns[0].Name = "Date";
            dgvTransactions.Columns[1].Name = "Description";
            dgvTransactions.Columns[2].Name = "Amount";
            dgvTransactions.Columns[3].Name = "Status";

            // set welcome label with actual username if available
            try
            {
                var user = Database.GetUserById(_userId);
                if (user != null && !string.IsNullOrWhiteSpace(user.Username))
                {
                    lblUserName.Text = $"Welcome, {user.Username}";
                }
            }
            catch
            {
                // ignore - don't block load for UI if name cannot be retrieved
            }

            LoadAccountsAndTransactions();
        }

        private void LoadAccountsAndTransactions()
        {
            try
            {
                var accounts = Database.GetAccountsByUserId(_userId);
                if (accounts.Rows.Count == 0)
                {
                    lblBalanceAmount.Text = "$0.00";
                    if (lblSelectedAccountInfo != null) lblSelectedAccountInfo.Text = "No accounts available";
                    return;
                }

                dgvAccounts.DataSource = accounts;
                if (dgvAccounts.Columns.Contains("Id"))
                    dgvAccounts.Columns["Id"].Visible = false;
                if (dgvAccounts.Columns.Contains("AccountNumber"))
                    dgvAccounts.Columns["AccountNumber"].HeaderText = "IBAN";
                if (dgvAccounts.Columns.Contains("Balance"))
                    dgvAccounts.Columns["Balance"].HeaderText = "Balance";
                if (dgvAccounts.Columns.Contains("AccountType"))
                    dgvAccounts.Columns["AccountType"].HeaderText = "Type";

                if (accounts.Rows.Count > 0)
                {
                    // select first row
                    dgvAccounts.ClearSelection();
                    dgvAccounts.Rows[0].Selected = true;

                    int firstAccountId = Convert.ToInt32(accounts.Rows[0]["Id"]);
                    decimal balance = Convert.ToDecimal(accounts.Rows[0]["Balance"]);
                    lblBalanceAmount.Text = $"${balance:N2}";
                    UpdateSelectedAccountInfo(accounts.Rows[0]);
                    LoadTransactionsForAccount(firstAccountId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSelectedAccountInfo(DataRow accountRow)
        {
            if (accountRow == null || lblSelectedAccountInfo == null) return;
            var acc = accountRow["AccountNumber"]?.ToString() ?? "N/A";
            var bal = accountRow.Table.Columns.Contains("Balance") ? Convert.ToDecimal(accountRow["Balance"]) : 0m;
            var type = accountRow.Table.Columns.Contains("AccountType") ? accountRow["AccountType"]?.ToString() : string.Empty;
            lblSelectedAccountInfo.Text = $"Selected: {acc} — {type} — {bal:C2}";
        }

        private void LoadTransactionsForAccount(int accountId)
        {
            try
            {
                var tx = Database.GetTransactionsByAccountId(accountId);
                dgvTransactions.Rows.Clear();
                foreach (DataRow r in tx.Rows)
                {
                    dgvTransactions.Rows.Add(
                        Convert.ToDateTime(r["Date"]).ToString("yyyy-MM-dd"),
                        r["Description"]?.ToString(),
                        Convert.ToDecimal(r["Amount"]).ToString("C2"),
                        r["Status"]?.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNewTransfer.Visible = false;
                dgvTransactions.Visible = true;
                lblBalanceTitle.Visible = true;
                lblBalanceAmount.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pnlNewTransfer.Visible = true;
            dgvTransactions.Visible = false;
            lblBalanceTitle.Visible = false;
            lblBalanceAmount.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNewTransfer.Visible = false;
            dgvTransactions.Visible = true;
            lblBalanceTitle.Visible = true;
            lblBalanceAmount.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void dgvAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null) return;
            if (dgvAccounts.CurrentRow.Cells["Id"].Value == null) return;
            int accountId = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["Id"].Value);
            decimal balance = Convert.ToDecimal(dgvAccounts.CurrentRow.Cells["Balance"].Value);
            lblBalanceAmount.Text = $"${balance:N2}";

            var row = ((DataRowView)dgvAccounts.CurrentRow.DataBoundItem)?.Row;
            if (row != null) UpdateSelectedAccountInfo(row);

            LoadTransactionsForAccount(accountId);
        }

        private void btnSendTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccounts.CurrentRow == null || dgvAccounts.CurrentRow.Cells["Id"].Value == null)
                {
                    MessageBox.Show("Please select a source account from the accounts list.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sourceAccountId = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["Id"].Value);

                var destIban = txtDestinationAccount.Text?.Trim();
                if (string.IsNullOrWhiteSpace(destIban))
                {
                    MessageBox.Show("Please enter destination IBAN.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var destRow = Database.GetAccountByAccountNumber(destIban);
                if (destRow == null)
                {
                    MessageBox.Show("Destination IBAN was not found in our bank.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int destAccountId = Convert.ToInt32(destRow["Id"]);

                string amountText = txtTransferAmount.Text?.Trim();
                decimal amount;
                var parseOk = decimal.TryParse(amountText, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out amount)
                              || decimal.TryParse(amountText, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out amount);

                if (!parseOk || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid amount greater than zero (numbers only).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var srcBalanceObj = dgvAccounts.CurrentRow.Cells["Balance"].Value;
                if (srcBalanceObj != null)
                {
                    var srcBalance = Convert.ToDecimal(srcBalanceObj);
                    if (srcBalance < amount)
                    {
                        MessageBox.Show("Insufficient funds in the selected source account.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string error;
                var ok = Database.TransferBetweenAccounts(sourceAccountId, destAccountId, amount, txtTransferDescription.Text, out error);
                if (!ok)
                {
                    MessageBox.Show(error ?? "Transfer failed.", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Transfer completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccountsAndTransactions();

                pnlNewTransfer.Visible = false;
                dgvTransactions.Visible = true;
                lblBalanceTitle.Visible = true;
                lblBalanceAmount.Visible = true;

                txtDestinationAccount.Text = string.Empty;
                txtTransferAmount.Text = string.Empty;
                txtTransferDescription.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to complete transfer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}