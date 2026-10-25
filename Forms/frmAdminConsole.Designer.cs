namespace UniEventApp.Forms
{
    partial class frmAdminConsole
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminConsole));

            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlAdminHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdminSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogoutAdmin = new Guna.UI2.WinForms.Guna2Button();

            this.pnlAdminTab = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnEventApproval = new Guna.UI2.WinForms.Guna2Button();
            this.btnFacultySettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminSettings = new Guna.UI2.WinForms.Guna2Button();

            // 1. Dashboard & System Events Panel (FR10)
            this.pnlAdminDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDashTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDashboardEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDeleteSystemEvent = new Guna.UI2.WinForms.Guna2Button();

            // 2. User & Pre-Approved Management Panel (FR13, FR14, Algorithm 6)
            this.pnlAdminUserManagement = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtPreApproveID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbPreApproveFaculty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddPreApproved = new Guna.UI2.WinForms.Guna2Button();
            this.txtAuthOrgUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthOrgPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAuthorizeOrganizer = new Guna.UI2.WinForms.Guna2Button();

            // 3. Event Approvals Panel (FR08)
            this.pnlAdmineventApproval = new Guna.UI2.WinForms.Guna2Panel();
            this.lblApprovalTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvPendingEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnApproveEvent = new Guna.UI2.WinForms.Guna2Button();
            this.btnRejectEvent = new Guna.UI2.WinForms.Guna2Button();

            // 4. Faculty Settings Panel (FR13)
            this.pnlAdminFacultySettings = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFacultyTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvFaculties = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtNewFacultyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddFaculty = new Guna.UI2.WinForms.Guna2Button();

            // 5. Profile & Password Reset Panel (NFR04 - supports resetting back to '123')
            this.pnlAdminSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSettingsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProfileUsername = new System.Windows.Forms.Label();
            this.txtOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();

            this.pnlAdminHeader.SuspendLayout();
            this.pnlAdminTab.SuspendLayout();
            this.pnlAdminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardEvents)).BeginInit();
            this.pnlAdminUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlAdmineventApproval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingEvents)).BeginInit();
            this.pnlAdminFacultySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculties)).BeginInit();
            this.pnlAdminSettings.SuspendLayout();
            this.SuspendLayout();

            // 
            // BorderlessForm
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;

            // 
            // Header Panel
            // 
            this.pnlAdminHeader.Controls.Add(this.btnLogoutAdmin);
            this.pnlAdminHeader.Controls.Add(this.txtAdminSearchBox);
            this.pnlAdminHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlAdminHeader.CustomBorderColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.pnlAdminHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlAdminHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminHeader.Name = "pnlAdminHeader";
            this.pnlAdminHeader.Size = new System.Drawing.Size(1200, 65);

            // 
            // Header Title
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 15);
            this.lblHeaderTitle.Text = "Admin Portal";

            // 
            // Search Box
            // 
            this.txtAdminSearchBox.BorderRadius = 6;
            this.txtAdminSearchBox.Location = new System.Drawing.Point(660, 14);
            this.txtAdminSearchBox.PlaceholderText = "Search system records...";
            this.txtAdminSearchBox.Size = new System.Drawing.Size(260, 36);
            this.txtAdminSearchBox.TextChanged += new System.EventHandler(this.txtAdminSearchBox_TextChanged);

            // 
            // Logout Button
            // 
            this.btnLogoutAdmin.BorderRadius = 6;
            this.btnLogoutAdmin.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnLogoutAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogoutAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLogoutAdmin.Location = new System.Drawing.Point(935, 14);
            this.btnLogoutAdmin.Size = new System.Drawing.Size(240, 36);
            this.btnLogoutAdmin.Text = "Log Out";
            this.btnLogoutAdmin.Click += new System.EventHandler(this.btnLogoutAdmin_Click);

            // 
            // Sidebar Navigation Panel
            // 
            this.pnlAdminTab.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlAdminTab.Controls.Add(this.btnAdminSettings);
            this.pnlAdminTab.Controls.Add(this.btnFacultySettings);
            this.pnlAdminTab.Controls.Add(this.btnEventApproval);
            this.pnlAdminTab.Controls.Add(this.btnUserManagement);
            this.pnlAdminTab.Controls.Add(this.btnDashHome);
            this.pnlAdminTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminTab.Location = new System.Drawing.Point(0, 65);
            this.pnlAdminTab.Size = new System.Drawing.Size(240, 685);

            this.btnDashHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashHome.FillColor = System.Drawing.Color.Transparent;
            this.btnDashHome.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDashHome.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnDashHome.Location = new System.Drawing.Point(0, 0);
            this.btnDashHome.Size = new System.Drawing.Size(240, 50);
            this.btnDashHome.Text = "  Dashboard & Events";
            this.btnDashHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashHome.Click += new System.EventHandler(this.btnDashHome_Click);

            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FillColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnUserManagement.Location = new System.Drawing.Point(0, 50);
            this.btnUserManagement.Size = new System.Drawing.Size(240, 50);
            this.btnUserManagement.Text = "  Users & Organizers";
            this.btnUserManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);

            this.btnEventApproval.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventApproval.FillColor = System.Drawing.Color.Transparent;
            this.btnEventApproval.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEventApproval.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnEventApproval.Location = new System.Drawing.Point(0, 100);
            this.btnEventApproval.Size = new System.Drawing.Size(240, 50);
            this.btnEventApproval.Text = "  Event Approvals";
            this.btnEventApproval.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEventApproval.Click += new System.EventHandler(this.btnEventApproval_Click);

            this.btnFacultySettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacultySettings.FillColor = System.Drawing.Color.Transparent;
            this.btnFacultySettings.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnFacultySettings.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnFacultySettings.Location = new System.Drawing.Point(0, 150);
            this.btnFacultySettings.Size = new System.Drawing.Size(240, 50);
            this.btnFacultySettings.Text = "  Faculty Settings";
            this.btnFacultySettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFacultySettings.Click += new System.EventHandler(this.btnFacultySettings_Click);

            this.btnAdminSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnAdminSettings.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAdminSettings.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnAdminSettings.Location = new System.Drawing.Point(0, 200);
            this.btnAdminSettings.Size = new System.Drawing.Size(240, 50);
            this.btnAdminSettings.Text = "  Profile & Security";
            this.btnAdminSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminSettings.Click += new System.EventHandler(this.btnAdminSettings_Click);

            // ---------------------------------------------------------
            // 1. DASHBOARD & EVENTS PANEL (FR10)
            // ---------------------------------------------------------
            this.pnlAdminDashboard.BackColor = System.Drawing.Color.White;
            this.pnlAdminDashboard.Controls.Add(this.lblDashTitle);
            this.pnlAdminDashboard.Controls.Add(this.dgvDashboardEvents);
            this.pnlAdminDashboard.Controls.Add(this.btnDeleteSystemEvent);
            this.pnlAdminDashboard.Location = new System.Drawing.Point(240, 65);
            this.pnlAdminDashboard.Size = new System.Drawing.Size(960, 685);

            this.lblDashTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDashTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDashTitle.Location = new System.Drawing.Point(30, 20);
            this.lblDashTitle.Text = "System Event Records (Admin Management)";

            this.dgvDashboardEvents.AllowUserToAddRows = false;
            this.dgvDashboardEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle1.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle1.ForeColor = System.Drawing.Color.White;
            dgvStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvDashboardEvents.ColumnHeadersDefaultCellStyle = dgvStyle1;
            this.dgvDashboardEvents.ColumnHeadersHeight = 35;
            this.dgvDashboardEvents.Location = new System.Drawing.Point(30, 65);
            this.dgvDashboardEvents.Name = "dgvDashboardEvents";
            this.dgvDashboardEvents.ReadOnly = true;
            this.dgvDashboardEvents.RowHeadersVisible = false;
            this.dgvDashboardEvents.Size = new System.Drawing.Size(900, 510);

            this.btnDeleteSystemEvent.BorderRadius = 6;
            this.btnDeleteSystemEvent.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDeleteSystemEvent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSystemEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSystemEvent.Location = new System.Drawing.Point(750, 590);
            this.btnDeleteSystemEvent.Size = new System.Drawing.Size(180, 40);
            this.btnDeleteSystemEvent.Text = "Delete Event Record";
            this.btnDeleteSystemEvent.Click += new System.EventHandler(this.btnDeleteSystemEvent_Click);

            // ---------------------------------------------------------
            // 2. USER MANAGEMENT & ORGANIZER AUTHORIZATION PANEL (FR13, FR14)
            // ---------------------------------------------------------
            this.pnlAdminUserManagement.BackColor = System.Drawing.Color.White;
            this.pnlAdminUserManagement.Controls.Add(this.lblUserTitle);
            this.pnlAdminUserManagement.Controls.Add(this.dgvUsers);
            this.pnlAdminUserManagement.Controls.Add(this.btnDeleteUser);
            this.pnlAdminUserManagement.Controls.Add(this.txtPreApproveID);
            this.pnlAdminUserManagement.Controls.Add(this.cmbPreApproveFaculty);
            this.pnlAdminUserManagement.Controls.Add(this.btnAddPreApproved);
            this.pnlAdminUserManagement.Controls.Add(this.txtAuthOrgUsername);
            this.pnlAdminUserManagement.Controls.Add(this.txtAuthOrgPassword);
            this.pnlAdminUserManagement.Controls.Add(this.btnAuthorizeOrganizer);
            this.pnlAdminUserManagement.Location = new System.Drawing.Point(240, 65);
            this.pnlAdminUserManagement.Size = new System.Drawing.Size(960, 685);
            this.pnlAdminUserManagement.Visible = false;

            this.lblUserTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUserTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblUserTitle.Location = new System.Drawing.Point(30, 15);
            this.lblUserTitle.Text = "Users, Pre-Approved IDs & Organizer Authorization";

            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle2.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle2.ForeColor = System.Drawing.Color.White;
            dgvStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dgvStyle2;
            this.dgvUsers.ColumnHeadersHeight = 35;
            this.dgvUsers.Location = new System.Drawing.Point(30, 55);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.Size = new System.Drawing.Size(900, 310);

            this.btnDeleteUser.BorderRadius = 6;
            this.btnDeleteUser.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(750, 375);
            this.btnDeleteUser.Size = new System.Drawing.Size(180, 36);
            this.btnDeleteUser.Text = "Delete User Account";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);

            // Pre-Approved Student Controls
            this.txtPreApproveID.BorderRadius = 6;
            this.txtPreApproveID.Location = new System.Drawing.Point(30, 430);
            this.txtPreApproveID.PlaceholderText = "Student ID (e.g., E2510224)";
            this.txtPreApproveID.Size = new System.Drawing.Size(220, 36);

            this.cmbPreApproveFaculty.BorderRadius = 6;
            this.cmbPreApproveFaculty.Location = new System.Drawing.Point(260, 430);
            this.cmbPreApproveFaculty.Size = new System.Drawing.Size(270, 36);

            this.btnAddPreApproved.BorderRadius = 6;
            this.btnAddPreApproved.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnAddPreApproved.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddPreApproved.ForeColor = System.Drawing.Color.White;
            this.btnAddPreApproved.Location = new System.Drawing.Point(545, 430);
            this.btnAddPreApproved.Size = new System.Drawing.Size(185, 36);
            this.btnAddPreApproved.Text = "Add Approved Student ID";
            this.btnAddPreApproved.Click += new System.EventHandler(this.btnAddPreApproved_Click);

            // Authorize Organizer Controls (FR14)
            this.txtAuthOrgUsername.BorderRadius = 6;
            this.txtAuthOrgUsername.Location = new System.Drawing.Point(30, 490);
            this.txtAuthOrgUsername.PlaceholderText = "Organizer Username";
            this.txtAuthOrgUsername.Size = new System.Drawing.Size(220, 36);

            this.txtAuthOrgPassword.BorderRadius = 6;
            this.txtAuthOrgPassword.Location = new System.Drawing.Point(260, 490);
            this.txtAuthOrgPassword.PasswordChar = '●';
            this.txtAuthOrgPassword.PlaceholderText = "Organizer Password";
            this.txtAuthOrgPassword.Size = new System.Drawing.Size(270, 36);

            this.btnAuthorizeOrganizer.BorderRadius = 6;
            this.btnAuthorizeOrganizer.FillColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAuthorizeOrganizer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAuthorizeOrganizer.ForeColor = System.Drawing.Color.White;
            this.btnAuthorizeOrganizer.Location = new System.Drawing.Point(545, 490);
            this.btnAuthorizeOrganizer.Size = new System.Drawing.Size(185, 36);
            this.btnAuthorizeOrganizer.Text = "Authorize Organizer";
            this.btnAuthorizeOrganizer.Click += new System.EventHandler(this.btnAuthorizeOrganizer_Click);

            // ---------------------------------------------------------
            // 3. EVENT APPROVAL PANEL (FR08)
            // ---------------------------------------------------------
            this.pnlAdmineventApproval.BackColor = System.Drawing.Color.White;
            this.pnlAdmineventApproval.Controls.Add(this.lblApprovalTitle);
            this.pnlAdmineventApproval.Controls.Add(this.dgvPendingEvents);
            this.pnlAdmineventApproval.Controls.Add(this.btnApproveEvent);
            this.pnlAdmineventApproval.Controls.Add(this.btnRejectEvent);
            this.pnlAdmineventApproval.Location = new System.Drawing.Point(240, 65);
            this.pnlAdmineventApproval.Size = new System.Drawing.Size(960, 685);
            this.pnlAdmineventApproval.Visible = false;

            this.lblApprovalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblApprovalTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblApprovalTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblApprovalTitle.Location = new System.Drawing.Point(30, 20);
            this.lblApprovalTitle.Text = "Pending Event Submissions Review";

            this.dgvPendingEvents.AllowUserToAddRows = false;
            this.dgvPendingEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle3.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle3.ForeColor = System.Drawing.Color.White;
            dgvStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvPendingEvents.ColumnHeadersDefaultCellStyle = dgvStyle3;
            this.dgvPendingEvents.ColumnHeadersHeight = 35;
            this.dgvPendingEvents.Location = new System.Drawing.Point(30, 65);
            this.dgvPendingEvents.Name = "dgvPendingEvents";
            this.dgvPendingEvents.ReadOnly = true;
            this.dgvPendingEvents.RowHeadersVisible = false;
            this.dgvPendingEvents.Size = new System.Drawing.Size(900, 510);

            this.btnRejectEvent.BorderRadius = 6;
            this.btnRejectEvent.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnRejectEvent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRejectEvent.ForeColor = System.Drawing.Color.White;
            this.btnRejectEvent.Location = new System.Drawing.Point(600, 590);
            this.btnRejectEvent.Size = new System.Drawing.Size(160, 40);
            this.btnRejectEvent.Text = "Reject Event";
            this.btnRejectEvent.Click += new System.EventHandler(this.btnRejectEvent_Click);

            this.btnApproveEvent.BorderRadius = 6;
            this.btnApproveEvent.FillColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnApproveEvent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnApproveEvent.ForeColor = System.Drawing.Color.White;
            this.btnApproveEvent.Location = new System.Drawing.Point(770, 590);
            this.btnApproveEvent.Size = new System.Drawing.Size(160, 40);
            this.btnApproveEvent.Text = "Approve Event";
            this.btnApproveEvent.Click += new System.EventHandler(this.btnApproveEvent_Click);

            // ---------------------------------------------------------
            // 4. FACULTY SETTINGS PANEL (FR13)
            // ---------------------------------------------------------
            this.pnlAdminFacultySettings.BackColor = System.Drawing.Color.White;
            this.pnlAdminFacultySettings.Controls.Add(this.lblFacultyTitle);
            this.pnlAdminFacultySettings.Controls.Add(this.dgvFaculties);
            this.pnlAdminFacultySettings.Controls.Add(this.txtNewFacultyName);
            this.pnlAdminFacultySettings.Controls.Add(this.btnAddFaculty);
            this.pnlAdminFacultySettings.Location = new System.Drawing.Point(240, 65);
            this.pnlAdminFacultySettings.Size = new System.Drawing.Size(960, 685);
            this.pnlAdminFacultySettings.Visible = false;

            this.lblFacultyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFacultyTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFacultyTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFacultyTitle.Location = new System.Drawing.Point(30, 20);
            this.lblFacultyTitle.Text = "University Faculty Directory";

            this.dgvFaculties.AllowUserToAddRows = false;
            this.dgvFaculties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle4.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle4.ForeColor = System.Drawing.Color.White;
            dgvStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvFaculties.ColumnHeadersDefaultCellStyle = dgvStyle4;
            this.dgvFaculties.ColumnHeadersHeight = 35;
            this.dgvFaculties.Location = new System.Drawing.Point(30, 65);
            this.dgvFaculties.Name = "dgvFaculties";
            this.dgvFaculties.ReadOnly = true;
            this.dgvFaculties.RowHeadersVisible = false;
            this.dgvFaculties.Size = new System.Drawing.Size(900, 510);

            this.txtNewFacultyName.BorderRadius = 6;
            this.txtNewFacultyName.Location = new System.Drawing.Point(30, 590);
            this.txtNewFacultyName.PlaceholderText = "Enter new unique faculty name...";
            this.txtNewFacultyName.Size = new System.Drawing.Size(400, 36);

            this.btnAddFaculty.BorderRadius = 6;
            this.btnAddFaculty.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnAddFaculty.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddFaculty.ForeColor = System.Drawing.Color.White;
            this.btnAddFaculty.Location = new System.Drawing.Point(445, 590);
            this.btnAddFaculty.Size = new System.Drawing.Size(160, 36);
            this.btnAddFaculty.Text = "Add Faculty";
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);

            // ---------------------------------------------------------
            // 5. PROFILE & SECURITY SETTINGS PANEL (NFR04)
            // ---------------------------------------------------------
            this.pnlAdminSettings.BackColor = System.Drawing.Color.White;
            this.pnlAdminSettings.Controls.Add(this.lblSettingsTitle);
            this.pnlAdminSettings.Controls.Add(this.lblProfileUsername);
            this.pnlAdminSettings.Controls.Add(this.txtOldPassword);
            this.pnlAdminSettings.Controls.Add(this.txtNewPassword);
            this.pnlAdminSettings.Controls.Add(this.txtConfirmPassword);
            this.pnlAdminSettings.Controls.Add(this.btnResetPassword);
            this.pnlAdminSettings.Location = new System.Drawing.Point(240, 65);
            this.pnlAdminSettings.Size = new System.Drawing.Size(960, 685);
            this.pnlAdminSettings.Visible = false;

            this.lblSettingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSettingsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSettingsTitle.Location = new System.Drawing.Point(30, 20);
            this.lblSettingsTitle.Text = "Admin Security & Password Settings";

            this.lblProfileUsername.AutoSize = true;
            this.lblProfileUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProfileUsername.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblProfileUsername.Location = new System.Drawing.Point(30, 80);
            this.lblProfileUsername.Text = "Logged-in Admin Account: user (or admin)";

            this.txtOldPassword.BorderRadius = 6;
            this.txtOldPassword.Location = new System.Drawing.Point(30, 135);
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.PlaceholderText = "Current Password (e.g. 123)";
            this.txtOldPassword.Size = new System.Drawing.Size(350, 40);

            this.txtNewPassword.BorderRadius = 6;
            this.txtNewPassword.Location = new System.Drawing.Point(30, 195);
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.Size = new System.Drawing.Size(350, 40);

            this.txtConfirmPassword.BorderRadius = 6;
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 255);
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "Confirm New Password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 40);

            this.btnResetPassword.BorderRadius = 6;
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(30, 320);
            this.btnResetPassword.Size = new System.Drawing.Size(200, 42);
            this.btnResetPassword.Text = "Update Password";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);

            // 
            // Form Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlAdminSettings);
            this.Controls.Add(this.pnlAdminFacultySettings);
            this.Controls.Add(this.pnlAdmineventApproval);
            this.Controls.Add(this.pnlAdminUserManagement);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Controls.Add(this.pnlAdminTab);
            this.Controls.Add(this.pnlAdminHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdminConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniEvent Admin Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminConsole_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminConsole_Load);

            this.pnlAdminHeader.ResumeLayout(false);
            this.pnlAdminHeader.PerformLayout();
            this.pnlAdminTab.ResumeLayout(false);
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlAdminDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardEvents)).EndInit();
            this.pnlAdminUserManagement.ResumeLayout(false);
            this.pnlAdminUserManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlAdmineventApproval.ResumeLayout(false);
            this.pnlAdmineventApproval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingEvents)).EndInit();
            this.pnlAdminFacultySettings.ResumeLayout(false);
            this.pnlAdminFacultySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculties)).EndInit();
            this.pnlAdminSettings.ResumeLayout(false);
            this.pnlAdminSettings.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlAdminHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminSearchBox;
        private Guna.UI2.WinForms.Guna2Button btnLogoutAdmin;

        private Guna.UI2.WinForms.Guna2Panel pnlAdminTab;
        private Guna.UI2.WinForms.Guna2Button btnDashHome;
        private Guna.UI2.WinForms.Guna2Button btnUserManagement;
        private Guna.UI2.WinForms.Guna2Button btnEventApproval;
        private Guna.UI2.WinForms.Guna2Button btnFacultySettings;
        private Guna.UI2.WinForms.Guna2Button btnAdminSettings;

        private Guna.UI2.WinForms.Guna2Panel pnlAdminDashboard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDashTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDashboardEvents;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSystemEvent;

        private Guna.UI2.WinForms.Guna2Panel pnlAdminUserManagement;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2TextBox txtPreApproveID;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPreApproveFaculty;
        private Guna.UI2.WinForms.Guna2Button btnAddPreApproved;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthOrgUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthOrgPassword;
        private Guna.UI2.WinForms.Guna2Button btnAuthorizeOrganizer;

        private Guna.UI2.WinForms.Guna2Panel pnlAdmineventApproval;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApprovalTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPendingEvents;
        private Guna.UI2.WinForms.Guna2Button btnApproveEvent;
        private Guna.UI2.WinForms.Guna2Button btnRejectEvent;

        private Guna.UI2.WinForms.Guna2Panel pnlAdminFacultySettings;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFacultyTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFaculties;
        private Guna.UI2.WinForms.Guna2TextBox txtNewFacultyName;
        private Guna.UI2.WinForms.Guna2Button btnAddFaculty;

        private Guna.UI2.WinForms.Guna2Panel pnlAdminSettings;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSettingsTitle;
        private System.Windows.Forms.Label lblProfileUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword;
    }
}