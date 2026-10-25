using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UniEventApp.Forms
{
    public partial class frmCreateEvent : Form
    {
        private DbHelper db = new DbHelper();

        public frmCreateEvent()
        {
            InitializeComponent();
        }

        private void frmCreateEvent_Load(object sender, EventArgs e)
        {
            LoadFacultiesIntoDropdown();
            dtpEventDate.MinDate = DateTime.Now; // Prevent scheduling past events
        }

        private void LoadFacultiesIntoDropdown()
        {
            try
            {
                DataTable dt = db.ReadData("SELECT FacultyID, FacultyName FROM Faculties");

                // Add an option for "All Faculties"
                DataRow allRow = dt.NewRow();
                allRow["FacultyID"] = DBNull.Value;
                allRow["FacultyName"] = "All Faculties (Public / General)";
                dt.Rows.InsertAt(allRow, 0);

                cmbTargetFaculty.DataSource = dt;
                cmbTargetFaculty.DisplayMember = "FacultyName";
                cmbTargetFaculty.ValueMember = "FacultyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculties: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            // 1. Validation
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter an event title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please specify a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            try
            {
                // 2. Prepare parameters
                string title = txtTitle.Text.Trim();
                string description = txtDescription.Text.Trim();
                DateTime eventDate = dtpEventDate.Value;
                string location = txtLocation.Text.Trim();
                string organizer = UserSession.Username; // Pulled from active session
                int? targetFacultyID = null;

                if (cmbTargetFaculty.SelectedValue != null && cmbTargetFaculty.SelectedValue != DBNull.Value)
                {
                    targetFacultyID = Convert.ToInt32(cmbTargetFaculty.SelectedValue);
                }

                int requiresLogin = chkRequiresLogin.Checked ? 1 : 0;

                // 3. Securely insert via parameterized SqlCommand with direct connection string
                string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=UniEventDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO Events (Title, Description, EventDate, Location, OrganizerName, TargetFacultyID, RequiresLogin) " +
                                   "VALUES (@Title, @Description, @EventDate, @Location, @Organizer, @FacultyID, @RequiresLogin)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@EventDate", eventDate);
                        cmd.Parameters.AddWithValue("@Location", location);
                        cmd.Parameters.AddWithValue("@Organizer", organizer);
                        cmd.Parameters.AddWithValue("@FacultyID", targetFacultyID.HasValue ? (object)targetFacultyID.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@RequiresLogin", requiresLogin);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Event published successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to publish event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}