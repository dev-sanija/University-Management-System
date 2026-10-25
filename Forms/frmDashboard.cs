using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniEventApp.Forms
{
    public partial class frmDashboard : Form
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=UniEventDB;Integrated Security=True;ConnectRetryCount=3;ConnectRetryInterval=10;";

        // Session context variables
        private int loggedInUserID;
        private string loggedInUsername;
        private string loggedInRole;
        private int? loggedInFacultyID;

        public frmDashboard(int userId, string username, string role, int? facultyId)
        {
            InitializeComponent();
            loggedInUserID = userId;
            loggedInUsername = username;
            loggedInRole = role;
            loggedInFacultyID = facultyId;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblUserRoleSession.Text = $"{loggedInUsername} ({loggedInRole})";

            // Enforce role-based UI visibility per Interim Report specs
            if (loggedInRole == "Student")
            {
                btnNavSubmitEvent.Visible = false;
                btnNavMyEvents.Visible = false;
            }
            else if (loggedInRole == "Organizer")
            {
                btnNavSubmitEvent.Visible = true;
                btnNavMyEvents.Visible = true;
            }

            PopulateFacultyFilters();
            LoadApprovedEventsFeed();
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

        private void SwitchPanel(Panel targetPanel)
        {
            pnlBrowseEvents.Visible = false;
            pnlMyRegistrations.Visible = false;
            pnlSubmitEvent.Visible = false;
            pnlMyEvents.Visible = false;

            targetPanel.Visible = true;
            targetPanel.BringToFront();
        }

        private void btnNavBrowse_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlBrowseEvents);
            LoadApprovedEventsFeed();
        }

        private void btnNavMyRegs_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlMyRegistrations);
            LoadStudentRegistrations();
        }

        private void btnNavSubmitEvent_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlSubmitEvent);
            PopulateSubmitFacultyDropdown();
        }

        private void btnNavMyEvents_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlMyEvents);
            LoadOrganizerEvents();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        #endregion

        #region --- 1. Browse Events & Registration Logic ---

        private void PopulateFacultyFilters()
        {
            DataTable dt = ExecuteQuery("SELECT FacultyID, FacultyName FROM Faculties");

            DataTable dtFilter = dt.Copy();
            DataRow allRow = dtFilter.NewRow();
            allRow["FacultyID"] = DBNull.Value;
            allRow["FacultyName"] = "All Faculties / Filters";
            dtFilter.Rows.InsertAt(allRow, 0);

            cmbFacultyFilter.DataSource = dtFilter;
            cmbFacultyFilter.DisplayMember = "FacultyName";
            cmbFacultyFilter.ValueMember = "FacultyID";
        }

        private void LoadApprovedEventsFeed()
        {
            string query = @"
                SELECT E.EventID, E.Title, E.Description, E.EventDate, E.Location, 
                       ISNULL(F.FacultyName, 'All Faculties') AS TargetFaculty, E.RequireLogin
                FROM Events E
                LEFT JOIN Faculties F ON E.TargetFacultyID = F.FacultyID
                WHERE E.Status = 'Approved'";

            if (loggedInRole == "Student" && loggedInFacultyID.HasValue)
            {
                query += " AND (E.TargetFacultyID IS NULL OR E.TargetFacultyID = @FacultyID)";
                SqlParameter[] p = { new SqlParameter("@FacultyID", loggedInFacultyID.Value) };
                dgvEventsFeed.DataSource = ExecuteQuery(query, p);
            }
            else
            {
                dgvEventsFeed.DataSource = ExecuteQuery(query);
            }
        }

        private void txtSearchEvents_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtHeaderSearchBox.Text.Trim();
            string query = @"
                SELECT E.EventID, E.Title, E.Description, E.EventDate, E.Location, 
                       ISNULL(F.FacultyName, 'All Faculties') AS TargetFaculty, E.RequireLogin
                FROM Events E
                LEFT JOIN Faculties F ON E.TargetFacultyID = F.FacultyID
                WHERE E.Status = 'Approved' AND E.Title LIKE @Search";

            SqlParameter[] p = { new SqlParameter("@Search", "%" + keyword + "%") };
            dgvEventsFeed.DataSource = ExecuteQuery(query, p);
        }

        private void cmbFacultyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacultyFilter.SelectedValue != null && cmbFacultyFilter.SelectedValue != DBNull.Value)
            {
                int facultyId = Convert.ToInt32(cmbFacultyFilter.SelectedValue);
                string query = @"
                    SELECT E.EventID, E.Title, E.Description, E.EventDate, E.Location, 
                           ISNULL(F.FacultyName, 'All Faculties') AS TargetFaculty, E.RequireLogin
                    FROM Events E
                    LEFT JOIN Faculties F ON E.TargetFacultyID = F.FacultyID
                    WHERE E.Status = 'Approved' AND (E.TargetFacultyID IS NULL OR E.TargetFacultyID = @FacultyID)";

                SqlParameter[] p = { new SqlParameter("@FacultyID", facultyId) };
                dgvEventsFeed.DataSource = ExecuteQuery(query, p);
            }
            else
            {
                LoadApprovedEventsFeed();
            }
        }

        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            if (loggedInRole != "Student" && loggedInRole != "Organizer")
            {
                MessageBox.Show("Please log in as a student to register for events.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvEventsFeed.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dgvEventsFeed.SelectedRows[0].Cells["EventID"].Value);

                string checkQuery = "SELECT COUNT(*) FROM Registrations WHERE StudentID = @StudentID AND EventID = @EventID";
                SqlParameter[] checkParams = {
                    new SqlParameter("@StudentID", loggedInUserID),
                    new SqlParameter("@EventID", eventId)
                };
                DataTable dtCheck = ExecuteQuery(checkQuery, checkParams);
                if (dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                {
                    MessageBox.Show("You are already registered for this event.", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string insertQuery = "INSERT INTO Registrations (StudentID, EventID, RegisteredAt) VALUES (@StudentID, @EventID, GETDATE())";
                SqlParameter[] insertParams = {
                    new SqlParameter("@StudentID", loggedInUserID),
                    new SqlParameter("@EventID", eventId)
                };

                int rows = ExecuteNonQuery(insertQuery, insertParams);
                if (rows > 0)
                {
                    MessageBox.Show("Successfully registered for the event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an event row to register.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region --- 2. My Registrations & Unregistration Logic ---

        private void LoadStudentRegistrations()
        {
            string query = @"
                SELECT R.RegistrationID, E.EventID, E.Title, E.EventDate, E.Location, R.RegisteredAt
                FROM Registrations R
                INNER JOIN Events E ON R.EventID = E.EventID
                WHERE R.StudentID = @StudentID";

            SqlParameter[] p = { new SqlParameter("@StudentID", loggedInUserID) };
            dgvMyRegistrations.DataSource = ExecuteQuery(query, p);
        }

        private void btnUnregisterEvent_Click(object sender, EventArgs e)
        {
            if (dgvMyRegistrations.SelectedRows.Count > 0)
            {
                int regId = Convert.ToInt32(dgvMyRegistrations.SelectedRows[0].Cells["RegistrationID"].Value);

                DialogResult res = MessageBox.Show("Are you sure you want to cancel this registration?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    SqlParameter[] p = { new SqlParameter("@RegID", regId) };
                    ExecuteNonQuery("DELETE FROM Registrations WHERE RegistrationID = @RegID", p);
                    MessageBox.Show("Registration cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentRegistrations();
                }
            }
            else
            {
                MessageBox.Show("Please select a registration row to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region --- 3. Event Submission Logic (Organizer) ---

        private void PopulateSubmitFacultyDropdown()
        {
            DataTable dt = ExecuteQuery("SELECT FacultyID, FacultyName FROM Faculties");
            DataTable dtSubmit = dt.Copy();
            DataRow publicRow = dtSubmit.NewRow();
            publicRow["FacultyID"] = DBNull.Value;
            publicRow["FacultyName"] = "All Faculties (Public Event)";
            dtSubmit.Rows.InsertAt(publicRow, 0);

            cmbTargetFaculty.DataSource = dtSubmit;
            cmbTargetFaculty.DisplayMember = "FacultyName";
            cmbTargetFaculty.ValueMember = "FacultyID";
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            string title = txtEventTitle.Text.Trim();
            string desc = txtEventDesc.Text.Trim();
            string location = txtEventLocation.Text.Trim();
            DateTime eventDate = dtpEventDate.Value;
            bool requireLogin = chkRequireLogin.Checked;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please fill in all mandatory event fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object targetFacultyId = DBNull.Value;
            if (cmbTargetFaculty.SelectedValue != null && cmbTargetFaculty.SelectedValue != DBNull.Value)
            {
                targetFacultyId = cmbTargetFaculty.SelectedValue;
            }

            string query = @"
                INSERT INTO Events (Title, Description, EventDate, Location, CreatedBy, TargetFacultyID, RequireLogin, Status) 
                VALUES (@Title, @Description, @EventDate, @Location, @CreatedBy, @TargetFacultyID, @RequireLogin, 'Pending')";

            SqlParameter[] p = {
                new SqlParameter("@Title", title),
                new SqlParameter("@Description", string.IsNullOrEmpty(desc) ? (object)DBNull.Value : desc),
                new SqlParameter("@EventDate", eventDate),
                new SqlParameter("@Location", location),
                new SqlParameter("@CreatedBy", loggedInUserID),
                new SqlParameter("@TargetFacultyID", targetFacultyId),
                new SqlParameter("@RequireLogin", requireLogin)
            };

            int rows = ExecuteNonQuery(query, p);
            if (rows > 0)
            {
                MessageBox.Show("Event submitted successfully! Awaiting University Admin approval.", "Pending Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEventTitle.Clear();
                txtEventDesc.Clear();
                txtEventLocation.Clear();
            }
        }

        #endregion

        #region --- 4. Organizer Events & Attendee Rosters Logic ---

        private void LoadOrganizerEvents()
        {
            string query = @"
                SELECT EventID, Title, EventDate, Location, Status 
                FROM Events 
                WHERE CreatedBy = @UserID";

            SqlParameter[] p = { new SqlParameter("@UserID", loggedInUserID) };
            dgvMyCreatedEvents.DataSource = ExecuteQuery(query, p);
        }

        private void btnViewAttendees_Click(object sender, EventArgs e)
        {
            if (dgvMyCreatedEvents.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dgvMyCreatedEvents.SelectedRows[0].Cells["EventID"].Value);

                string query = @"
                    SELECT R.RegistrationID, U.Username, U.StudentID, ISNULL(F.FacultyName, 'N/A') AS StudentFaculty, R.RegisteredAt
                    FROM Registrations R
                    INNER JOIN Users U ON R.StudentID = U.UserID
                    LEFT JOIN Faculties F ON U.FacultyID = F.FacultyID
                    WHERE R.EventID = @EventID";

                SqlParameter[] p = { new SqlParameter("@EventID", eventId) };
                dgvAttendees.DataSource = ExecuteQuery(query, p);
            }
            else
            {
                MessageBox.Show("Please select one of your created events to view its attendee roster.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}