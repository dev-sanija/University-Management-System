using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniEventApp.Forms;

namespace UniEventApp
{
    public partial class frmLogin : Form
    {
        // Connection string matching your UniEventDB LocalDB instance
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=UniEventDB;Integrated Security=True;ConnectRetryCount=3;ConnectRetryInterval=10;";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Note: Ensure your login form textboxes are named txtUsername and txtPassword 
            // (or update these lines to match your exact control names if different).
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT UserID, Username, Role, FacultyID FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                int userId = Convert.ToInt32(dt.Rows[0]["UserID"]);
                                string dbUsername = dt.Rows[0]["Username"].ToString();
                                string role = dt.Rows[0]["Role"].ToString();
                                int? facultyId = dt.Rows[0]["FacultyID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dt.Rows[0]["FacultyID"]);

                                // Route based on role
                                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    frmAdminConsole adminConsole = new frmAdminConsole();
                                    adminConsole.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // Student or Organizer role opens Dashboard with active session data
                                    frmDashboard dashboard = new frmDashboard(userId, dbUsername, role, facultyId);
                                    dashboard.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            // Open dashboard as a Guest (UserID = 0, Role = Guest, no faculty restriction)
            frmDashboard dashboard = new frmDashboard(0, "Guest", "Guest", null);
            dashboard.Show();
            this.Hide();
        }
    }
}