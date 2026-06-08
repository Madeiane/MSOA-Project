using Sistem_Bancar.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Sistem_Bancar.DataAccess
{
    public static class Database
    {
        // lazy runtime lookup to avoid compile-time/static-init problems
        private static string _conn;
        public static string Conn
        {
            get
            {
                if (_conn == null)
                {
                    var cs = System.Configuration.ConfigurationManager
                              .ConnectionStrings["BankDB"]?.ConnectionString;
                    if (string.IsNullOrEmpty(cs))
                    {
                        throw new InvalidOperationException(
                            "Connection string 'BankDB' not found. Add it to App.config/Web.config and ensure the project references System.Configuration.");
                    }
                    _conn = cs;
                }
                return _conn;
            }
        }

        public static User AuthenticateUser(string username, string password)
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, Username, Password, Role FROM dbo.Users WHERE Username = @u AND Password = @p", cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        return new User
                        {
                            Id = rdr.GetInt32(0),
                            Username = rdr.GetString(1),
                            Password = rdr.GetString(2),
                            Role = rdr.GetString(3)
                        };
                    }
                }
            }
            return null;
        }

        public static User GetUserByUsername(string username)
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, Username, Password, Role FROM dbo.Users WHERE Username = @u", cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        return new User
                        {
                            Id = rdr.GetInt32(0),
                            Username = rdr.GetString(1),
                            Password = rdr.GetString(2),
                            Role = rdr.GetString(3)
                        };
                    }
                }
            }
            return null;
        }

        // new helper: get user by id (used to show welcome name)
        public static User GetUserById(int userId)
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, Username, Password, Role FROM dbo.Users WHERE Id = @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                cn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        return new User
                        {
                            Id = rdr.GetInt32(0),
                            Username = rdr.GetString(1),
                            Password = rdr.GetString(2),
                            Role = rdr.GetString(3)
                        };
                    }
                }
            }
            return null;
        }

        public static int CreateUser(string username, string password, string role)
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("INSERT INTO dbo.Users (Username, Password, Role) VALUES (@u, @p, @r); SELECT SCOPE_IDENTITY()", cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@r", role);
                cn.Open();
                var id = cmd.ExecuteScalar();
                return Convert.ToInt32(id);
            }
        }
        //  (ex: RO49BANC1234567890123456)
        public static string GenerateRandomIban()
        {
            Random rand = new Random();
            string countryCode = "RO";
            string controlDigits = rand.Next(10, 99).ToString(); // 2 cifre de control
            string bankCode = "BANC"; 

            StringBuilder accountDigits = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                accountDigits.Append(rand.Next(0, 10)); // 16 cifre aleatorii pentru cont
            }

            return $"{countryCode}{controlDigits}{bankCode}{accountDigits.ToString()}";
        }


        public static void CreateBankAccount(int userId, string accountNumber, string accountType)
        {
            using (var cn = new System.Data.SqlClient.SqlConnection(Conn))
            
            using (var cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Accounts (UserId, AccountNumber, Balance, AccountType) VALUES (@uid, @acc, 5000.00, @type)", cn))
            {
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@acc", accountNumber);
                cmd.Parameters.AddWithValue("@type", accountType);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteUserFull(int userId)
        {
            using (var cn = new SqlConnection(Conn))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        
                        using (var cmd = new SqlCommand(@"
                    DELETE FROM dbo.Transactions 
                    WHERE SourceAccountId IN (SELECT Id FROM dbo.Accounts WHERE UserId = @uid)
                       OR DestinationAccountNumber IN (SELECT AccountNumber FROM dbo.Accounts WHERE UserId = @uid)", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.ExecuteNonQuery();
                        }

                        
                        using (var cmd = new SqlCommand("DELETE FROM dbo.Accounts WHERE UserId = @uid", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.ExecuteNonQuery();
                        }

                        
                        using (var cmd = new SqlCommand("DELETE FROM dbo.Users WHERE Id = @uid", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.ExecuteNonQuery();
                        }

                        tr.Commit();
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }
        public static bool UpdateUserPassword(string username, string newPassword)
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("UPDATE dbo.Users SET Password = @p WHERE Username = @u", cn))
            {
                cmd.Parameters.AddWithValue("@p", newPassword);
                cmd.Parameters.AddWithValue("@u", username);
                cn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public static DataTable GetAccountsByUserId(int userId)
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, UserId, AccountNumber, Balance, AccountType FROM dbo.Accounts WHERE UserId = @uid", cn))
            {
                cmd.Parameters.AddWithValue("@uid", userId);
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // new helper: get account by account number (IBAN)
        public static DataRow GetAccountByAccountNumber(string accountNumber)
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, UserId, AccountNumber, Balance, AccountType FROM dbo.Accounts WHERE AccountNumber = @acc", cn))
            {
                cmd.Parameters.AddWithValue("@acc", accountNumber);
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static DataTable GetTransactionsByAccountId(int accountId)
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Date, Description, Amount, Status FROM dbo.Transactions WHERE SourceAccountId = @aid ORDER BY Date DESC", cn))
            {
                cmd.Parameters.AddWithValue("@aid", accountId);
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // new helper: perform a transfer between accounts inside a DB transaction
        // returns true if successful; error message is set on failure
        public static bool TransferBetweenAccounts(int sourceAccountId, int destinationAccountId, decimal amount, string description, out string error)
        {
            error = null;
            if (sourceAccountId == destinationAccountId)
            {
                error = "Source and destination accounts cannot be the same.";
                return false;
            }

            if (amount <= 0)
            {
                error = "Amount must be greater than zero.";
                return false;
            }

            using (var cn = new SqlConnection(Conn))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
               
                        string srcIban = "";
                        using (var cmd = new SqlCommand("SELECT Balance, AccountNumber FROM dbo.Accounts WHERE Id = @sid", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@sid", sourceAccountId);
                            using (var rdr = cmd.ExecuteReader())
                            {
                                if (!rdr.Read())
                                {
                                    error = "Source account not found.";
                                    tr.Rollback();
                                    return false;
                                }
                                var srcBalance = Convert.ToDecimal(rdr["Balance"]);
                                srcIban = rdr["AccountNumber"].ToString();

                                if (srcBalance < amount)
                                {
                                    error = "Insufficient funds in source account.";
                                    tr.Rollback();
                                    return false;
                                }
                            }
                        }

                        
                        string destIban = "";
                        using (var cmd = new SqlCommand("SELECT AccountNumber FROM dbo.Accounts WHERE Id = @did", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@did", destinationAccountId);
                            var obj = cmd.ExecuteScalar();
                            if (obj == null)
                            {
                                error = "Destination account not found.";
                                tr.Rollback();
                                return false;
                            }
                            destIban = obj.ToString();
                        }

                        
                        using (var cmd = new SqlCommand("UPDATE dbo.Accounts SET Balance = Balance - @amt WHERE Id = @sid", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@amt", amount);
                            cmd.Parameters.AddWithValue("@sid", sourceAccountId);
                            cmd.ExecuteNonQuery();
                        }

                       
                        using (var cmd = new SqlCommand("UPDATE dbo.Accounts SET Balance = Balance + @amt WHERE Id = @did", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@amt", amount);
                            cmd.Parameters.AddWithValue("@did", destinationAccountId);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new SqlCommand("INSERT INTO dbo.Transactions (SourceAccountId, DestinationAccountNumber, Date, Amount, Description, Status) VALUES (@s, @d, GETDATE(), @amt, @desc, 'Completed')", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@s", sourceAccountId);
                            cmd.Parameters.AddWithValue("@d", destIban);
                            cmd.Parameters.AddWithValue("@amt", -amount);
                            cmd.Parameters.AddWithValue("@desc", description ?? string.Empty);
                            cmd.ExecuteNonQuery();
                        }

                        
                        using (var cmd = new SqlCommand("INSERT INTO dbo.Transactions (SourceAccountId, DestinationAccountNumber, Date, Amount, Description, Status) VALUES (@s, @d, GETDATE(), @amt, @desc, 'Completed')", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@s", destinationAccountId);
                            cmd.Parameters.AddWithValue("@d", srcIban); // Destinatarul vede IBAN-ul sursei
                            cmd.Parameters.AddWithValue("@amt", amount);
                            cmd.Parameters.AddWithValue("@desc", description ?? string.Empty);
                            cmd.ExecuteNonQuery();
                        }

                        tr.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try { tr.Rollback(); } catch { }
                        error = "Database error during transfer: " + ex.Message;
                        return false;
                    }
                }
            }
        
    }
        

        public static DataTable GetRequests()
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, CustomerName, RequestType, Details, Status FROM dbo.Requests ORDER BY Id DESC", cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetAllUsers()
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, Username, Role FROM dbo.Users ORDER BY Username", cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public static int GetTotalUsers()
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.Users", cn))
            {
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetTotalTransactions()
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.Transactions", cn))
            {
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // ==========================================
        // METODE NOI PENTRU EMPLOYEE DASHBOARD
        // ==========================================
        public static DataTable GetPendingAccountRequests()
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, CustomerName, RequestType, Details, Status FROM dbo.Requests WHERE Status = 'Pending' ORDER BY Id ASC", cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public static void ProcessAccountRequest(int requestId, bool approve, int employeeId)
        {
            string newStatus = approve ? "Approved" : "Rejected";
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("UPDATE dbo.Requests SET Status = @s WHERE Id = @id", cn))
            {
                cmd.Parameters.AddWithValue("@s", newStatus);
                cmd.Parameters.AddWithValue("@id", requestId);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ManualDeposit(int accountId, decimal amount, string description)
        {
            using (var cn = new SqlConnection(Conn))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand("UPDATE dbo.Accounts SET Balance = Balance + @amt WHERE Id = @id", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@amt", amount);
                            cmd.Parameters.AddWithValue("@id", accountId);
                            cmd.ExecuteNonQuery();
                        }
                        using (var cmd = new SqlCommand("INSERT INTO dbo.Transactions (SourceAccountId, DestinationAccountNumber, Amount, Description, Date, Status) VALUES (@s, 'SYSTEM_DEPOSIT', @amt, @desc, SYSUTCDATETIME(), 'Completed')", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@s", accountId);
                            cmd.Parameters.AddWithValue("@amt", amount);
                            cmd.Parameters.AddWithValue("@desc", description);
                            cmd.ExecuteNonQuery();
                        }
                        tr.Commit();
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void SetAccountFrozen(int accountId, bool freeze)
        {
            string status = freeze ? "Frozen" : "Active";
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("UPDATE dbo.Accounts SET Status = @s WHERE Id = @id", cn))
            {
                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@id", accountId);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ==========================================
        // METODE NOI PENTRU ADMIN DASHBOARD
        // ==========================================
        public static int GetTotalUserCount() => GetTotalUsers();
        public static int GetTotalTransactionCount() => GetTotalTransactions();

        public static DataTable GetRecentTransactions(int limit)
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT TOP (@limit) Id, SourceAccountId, DestinationAccountNumber, Amount, Date, Status FROM dbo.Transactions ORDER BY Date DESC", cn))
            {
                cmd.Parameters.AddWithValue("@limit", limit);
                using (var da = new SqlDataAdapter(cmd)) da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetAllTransactions(DateTime fromDate, DateTime toDate)
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("SELECT Id, SourceAccountId, DestinationAccountNumber, Amount, Date, Status FROM dbo.Transactions WHERE Date >= @startDate AND Date <= @endDate ORDER BY Date DESC", cn))
            {
                cmd.Parameters.AddWithValue("@startDate", fromDate);
                cmd.Parameters.AddWithValue("@endDate", toDate);
                using (var da = new SqlDataAdapter(cmd)) da.Fill(dt);
            }
            return dt;
        }

        public static void SetUserActive(int userId, bool isActive)
        {
            string status = isActive ? "Active" : "Inactive";
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("UPDATE dbo.Users SET Status = @s WHERE Id = @id", cn))
            {
                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@id", userId);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ResetUserPassword(int userId, string newPassword)
        {
            using (var cn = new SqlConnection(Conn))
            using (var cmd = new SqlCommand("UPDATE dbo.Users SET Password = @p WHERE Id = @id", cn))
            {
                cmd.Parameters.AddWithValue("@p", newPassword);
                cmd.Parameters.AddWithValue("@id", userId);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllUsers(string searchFilter)
        {
            var dt = new DataTable();
            using (var cn = new SqlConnection(Conn))
            {
                string query = "SELECT Id, Username, Role, Status FROM dbo.Users";
                if (!string.IsNullOrEmpty(searchFilter))
                {
                    query += " WHERE Username LIKE @search";
                }
                using (var cmd = new SqlCommand(query, cn))
                {
                    if (!string.IsNullOrEmpty(searchFilter))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchFilter + "%");
                    }
                    using (var da = new SqlDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }
    }
}