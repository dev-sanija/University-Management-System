using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UniEventApp.Forms
{
    public partial class frmAdminConsole : Form
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=UniEventDB;Integrated Security=True;ConnectRetryCount=3;ConnectRetryInterval=10;";

        // Active Admin session handle (Defaults to 'user' for 123 login)
        private string activeAdminUsername = "user";

        public frmAdminConsole(string adminUsername = "user")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(adminUsername))
            {
                activeAdminUsername = adminUsername;
            }
        }

        private void frmAdminConsole_Load(object sender, EventArgs e)
        {
            lblProfileUsername.Text = $"Logged-in Admin Account: {activeAdminUsername}";
            LoadSystemEvents();
            LoadUserData();
            LoadPendingEventsData();
            LoadFacultyData();
            PopulateFacultyDropdown();
        }

        #region --- Database Helper Methods ---

        private DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Execution Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsAffected;
        }

        #endregion

        #region --- Navigation Panel Switching ---

        private void ShowPanel(Panel panelToShow)
        {
            pnlAdminDashboard.Visible = false;
            pnlAdminUserManagement.Visible = false;
            pnlAdmineventApproval.Visible = false;
            pnlAdminFacultySettings.Visible = false;
            pnlAdminSettings.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void btnDashHome_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdminDashboard);
            LoadSystemEvents();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdminUserManagement);
            LoadUserData();
        }

        private void btnEventApproval_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdmineventApproval);
            LoadPendingEventsData();
        }

        private void btnFacultySettings_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdminFacultySettings);
            LoadFacultyData();
        }

        private void btnAdminSettings_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdminSettings);
            lblProfileUsername.Text = $"Logged-in Admin Account: {activeAdminUsername}";
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        #endregion

        #region --- Tab 1: System Event Management (FR10) ---

        private void LoadSystemEvents()
        {
            string query = @"
                SELECT E.EventID, E.Title, E.EventDate, E.Location, E.Status, 
                       U.Username AS Organizer, ISNULL(F.FacultyName, 'All Faculties') AS TargetFaculty
                FROM Events E
                INNER JOIN Users U ON E.CreatedBy = U.UserID
                LEFT JOIN Faculties F ON E.TargetFacultyID = F.FacultyID
                ORDER BY E.EventID DESC";

            dgvDashboardEvents.DataSource = ExecuteQuery(query);
        }

        private void btnDeleteSystemEvent_Click(object sender, EventArgs e)
        {
            if (dgvDashboardEvents.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dgvDashboardEvents.SelectedRows[0].Cells["EventID"].Value);
                string title = dgvDashboardEvents.SelectedRows[0].Cells["Title"].Value.ToString();

                DialogResult res = MessageBox.Show($"Are you sure you want to delete event '{title}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    SqlParameter[] p = { new SqlParameter("@EventID", eventId) };
                    ExecuteNonQuery("DELETE FROM Events WHERE EventID = @EventID", p);
                    MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSystemEvents();
                }
            }
            else
            {
                MessageBox.Show("Please select an event row from the table.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region --- Tab 2: User Management, Pre-Approved IDs & Organizer Authorization (FR13, FR14, Algorithm 6) ---

        private void LoadUserData()
        {
            string query = @"
                SELECT U.UserID, U.Username, U.Role, U.StudentID, ISNULL(F.FacultyName, 'N/A') AS Faculty
                FROM Users U
                LEFT JOIN Faculties F ON U.FacultyID = F.FacultyID";

            dgvUsers.DataSource = ExecuteQuery(query);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();

                if (username.Equals("user", StringComparison.OrdinalIgnoreCase) || username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Primary admin accounts cannot be deleted.", "Protected Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete account '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlParameter[] p = { new SqlParameter("@UserID", userId) };
                    ExecuteNonQuery("DELETE FROM Users WHERE UserID = @UserID", p);
                    MessageBox.Show("User account deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserData();
                }
            }
            else
            {
                MessageBox.Show("Please select a user row first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopulateFacultyDropdown()
        {
            DataTable dt = ExecuteQuery("SELECT FacultyID, FacultyName FROM Faculties");
            cmbPreApproveFaculty.DataSource = dt;
            cmbPreApproveFaculty.DisplayMember = "FacultyName";
            cmbPreApproveFaculty.ValueMember = "FacultyID";
        }

        private void btnAddPreApproved_Click(object sender, EventArgs e)
        {
            string studentId = txtPreApproveID.Text.Trim();
            if (string.IsNullOrEmpty(studentId) || cmbPreApproveFaculty.SelectedValue == null)
            {
                MessageBox.Show("Please enter a Student ID and select a faculty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int facultyId = Convert.ToInt32(cmbPreApproveFaculty.SelectedValue);
            string query = "INSERT INTO PreApprovedStudents (StudentID, FacultyID, IsRegistered) VALUES (@StudentID, @FacultyID, 0)";
            SqlParameter[] p = {
                new SqlParameter("@StudentID", studentId),
                new SqlParameter("@FacultyID", facultyId)
            };

            int result = ExecuteNonQuery(query, p);
            if (result > 0)
            {
                MessageBox.Show("Student ID added to university eligibility list successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPreApproveID.Clear();
            }
        }

        private void btnAuthorizeOrganizer_Click(object sender, EventArgs e)
        {
            string orgUser = txtAuthOrgUsername.Text.Trim();
            string orgPass = txtAuthOrgPassword.Text.Trim();

            if (string.IsNullOrEmpty(orgUser) || string.IsNullOrEmpty(orgPass))
            {
                MessageBox.Show("Please enter both username and password for the organizer account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Users (Username, Password, Role, StudentID, FacultyID) VALUES (@Username, @Password, 'Organizer', NULL, NULL)";
            SqlParameter[] p = {
                new SqlParameter("@Username", orgUser),
                new SqlParameter("@Password", orgPass)
            };

            int rows = ExecuteNonQuery(query, p);
            if (rows > 0)
            {
                MessageBox.Show("Organizer account authorized and created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAuthOrgUsername.Clear();
                txtAuthOrgPassword.Clear();
                LoadUserData();
            }
        }

        #endregion

        #region --- Tab 3: Event Approvals (FR08) ---

        private void LoadPendingEventsData()
        {
            string query = @"
                SELECT E.EventID, E.Title, E.Description, E.EventDate, E.Location, U.Username AS SubmittedBy
                FROM Events E
                INNER JOIN Users U ON E.CreatedBy = U.UserID
                WHERE E.Status = 'Pending'";

            dgvPendingEvents.DataSource = ExecuteQuery(query);
        }

        private void btnApproveEvent_Click(object sender, EventArgs e)
        {
            UpdateEventStatus("Approved");
        }

        private void btnRejectEvent_Click(object sender, EventArgs e)
        {
            UpdateEventStatus("Rejected");
        }

        private void UpdateEventStatus(string newStatus)
        {
            if (dgvPendingEvents.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dgvPendingEvents.SelectedRows[0].Cells["EventID"].Value);
                SqlParameter[] p = {
                    new SqlParameter("@Status", newStatus),
                    new SqlParameter("@EventID", eventId)
                };

                ExecuteNonQuery("UPDATE Events SET Status = @Status WHERE EventID = @EventID", p);
                MessageBox.Show($"Event successfully marked as {newStatus}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingEventsData();
                LoadSystemEvents();
            }
            else
            {
                MessageBox.Show("Please select an event row from the pending table.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region --- Tab 4: Faculty Settings (FR13) ---

        private void LoadFacultyData()
        {
            dgvFaculties.DataSource = ExecuteQuery("SELECT FacultyID, FacultyName FROM Faculties");
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            string facultyName = txtNewFacultyName.Text.Trim();
            if (string.IsNullOrEmpty(facultyName))
            {
                MessageBox.Show("Faculty name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlParameter[] p = { new SqlParameter("@FacultyName", facultyName) };
            int rows = ExecuteNonQuery("INSERT INTO Faculties (FacultyName) VALUES (@FacultyName)", p);

            if (rows > 0)
            {
                MessageBox.Show("Faculty added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewFacultyName.Clear();
                LoadFacultyData();
                PopulateFacultyDropdown();
            }
        }

        #endregion

        #region --- Tab 5: Profile & Password Reset (NFR04 - Supports changing back to '123') ---

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPassword.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please complete all password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verify current password against database for active admin account
            SqlParameter[] checkP = {
                new SqlParameter("@Username", activeAdminUsername),
                new SqlParameter("@Password", oldPass)
            };
            DataTable dt = ExecuteQuery("SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password", checkP);

            if (dt.Rows.Count > 0)
            {
                SqlParameter[] updateP = {
                    new SqlParameter("@NewPassword", newPass),
                    new SqlParameter("@Username", activeAdminUsername)
                };
                ExecuteNonQuery("UPDATE Users SET Password = @NewPassword WHERE Username = @Username", updateP);

                MessageBox.Show("Password updated successfully! (You can change it back anytime using this form).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect current password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region --- Search & Exit ---

        private void txtAdminSearchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtAdminSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadSystemEvents();
                return;
            }

            string searchSql = @"
                SELECT E.EventID, E.Title, E.EventDate, E.Location, E.Status, 
                       U.Username AS Organizer, ISNULL(F.FacultyName, 'All Faculties') AS TargetFaculty
                FROM Events E
                INNER JOIN Users U ON E.CreatedBy = U.UserID
                LEFT JOIN Faculties F ON E.TargetFacultyID = F.FacultyID
                WHERE E.Title LIKE @Search OR E.Location LIKE @Search OR U.Username LIKE @Search";

            SqlParameter[] p = { new SqlParameter("@Search", "%" + keyword + "%") };
            dgvDashboardEvents.DataSource = ExecuteQuery(searchSql, p);
        }

        private void frmAdminConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}