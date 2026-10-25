using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniEventApp.Forms
{
    public partial class frmEventDetails : Form
    {
        private int eventId;

        public frmEventDetails(int selectedEventId)
        {
            InitializeComponent();
            eventId = selectedEventId;
        }

        private void frmEventDetails_Load(object sender, EventArgs e)
        {
            LoadEventDetailsData();
        }

        private void LoadEventDetailsData()
        {
            try
            {
                string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=UniEventDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Title, Description, EventDate, Location, OrganizerName FROM Events WHERE EventID = @EventID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", eventId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTitle.Text = reader["Title"].ToString();
                                txtDescription.Text = reader["Description"].ToString();

                                if (DateTime.TryParse(reader["EventDate"].ToString(), out DateTime dt))
                                {
                                    txtEventDate.Text = dt.ToString("yyyy-MM-dd HH:mm");
                                }
                                else
                                {
                                    txtEventDate.Text = reader["EventDate"].ToString();
                                }

                                txtLocation.Text = reader["Location"].ToString();
                                txtOrganizer.Text = reader["OrganizerName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Event details could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load event details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserSession.Username;
                string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=UniEventDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO EventRegistrations (EventID, Username, RegistrationDate) VALUES (@EventID, @Username, @RegDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", eventId);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@RegDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully registered for this event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed (You may already be registered): " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}