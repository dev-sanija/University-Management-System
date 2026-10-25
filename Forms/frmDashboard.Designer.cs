namespace UniEventApp.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dgvStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);

            // Header
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDashboardTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUserRoleSession = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHeaderSearchBox = new Guna.UI2.WinForms.Guna2TextBox();

            // Sidebar
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNavBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavMyRegs = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavSubmitEvent = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavMyEvents = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();

            // 1. Browse Events Panel (Shared)
            this.pnlBrowseEvents = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrowseTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFacultyFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvEventsFeed = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRegisterEvent = new Guna.UI2.WinForms.Guna2Button();

            // 2. My Registrations Panel (Student)
            this.pnlMyRegistrations = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRegsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvMyRegistrations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUnregisterEvent = new Guna.UI2.WinForms.Guna2Button();

            // 3. Submit Event Panel (Organizer)
            this.pnlSubmitEvent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubmitTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEventTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEventDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEventLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpEventDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTargetFaculty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkRequireLogin = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lblRequireLoginText = new System.Windows.Forms.Label();
            this.btnSaveEvent = new Guna.UI2.WinForms.Guna2Button();

            // 4. Organizer Events & Rosters Panel (Organizer)
            this.pnlMyEvents = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMyEventsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvMyCreatedEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvAttendees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnViewAttendees = new Guna.UI2.WinForms.Guna2Button();

            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlBrowseEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventsFeed)).BeginInit();
            this.pnlMyRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRegistrations)).BeginInit();
            this.pnlSubmitEvent.SuspendLayout();
            this.pnlMyEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCreatedEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendees)).BeginInit();
            this.SuspendLayout();

            // 
            // BorderlessForm
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblDashboardTitle);
            this.pnlHeader.Controls.Add(this.lblUserRoleSession);
            this.pnlHeader.Controls.Add(this.txtHeaderSearchBox);
            this.pnlHeader.CustomBorderColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.pnlHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 65);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblDashboardTitle.Location = new System.Drawing.Point(25, 15);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(190, 34);
            this.lblDashboardTitle.Text = "UniEvent Portal";

            // 
            // lblUserRoleSession
            // 
            this.lblUserRoleSession.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRoleSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserRoleSession.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblUserRoleSession.Location = new System.Drawing.Point(595, 22);
            this.lblUserRoleSession.Name = "lblUserRoleSession";
            this.lblUserRoleSession.Size = new System.Drawing.Size(150, 21);
            this.lblUserRoleSession.Text = "Welcome, User (Role)";

            // 
            // txtHeaderSearchBox
            // 
            this.txtHeaderSearchBox.BorderRadius = 6;
            this.txtHeaderSearchBox.Location = new System.Drawing.Point(860, 14);
            this.txtHeaderSearchBox.Name = "txtHeaderSearchBox";
            this.txtHeaderSearchBox.PlaceholderText = "Search events...";
            this.txtHeaderSearchBox.Size = new System.Drawing.Size(295, 36);
            this.txtHeaderSearchBox.TabIndex = 2;
            this.txtHeaderSearchBox.TextChanged += new System.EventHandler(this.txtSearchEvents_TextChanged);

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnNavMyEvents);
            this.pnlSidebar.Controls.Add(this.btnNavSubmitEvent);
            this.pnlSidebar.Controls.Add(this.btnNavMyRegs);
            this.pnlSidebar.Controls.Add(this.btnNavBrowse);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 65);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 646);
            this.pnlSidebar.TabIndex = 1;

            // Navigation Buttons (Styled with Premium Flat UI & Hover Effects)
            this.btnNavBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavBrowse.FillColor = System.Drawing.Color.Transparent;
            this.btnNavBrowse.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavBrowse.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavBrowse.Location = new System.Drawing.Point(0, 0);
            this.btnNavBrowse.Size = new System.Drawing.Size(230, 50);
            this.btnNavBrowse.Text = "    Browse Events";
            this.btnNavBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavBrowse.Click += new System.EventHandler(this.btnNavBrowse_Click);

            this.btnNavMyRegs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMyRegs.FillColor = System.Drawing.Color.Transparent;
            this.btnNavMyRegs.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavMyRegs.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavMyRegs.Location = new System.Drawing.Point(0, 50);
            this.btnNavMyRegs.Size = new System.Drawing.Size(230, 50);
            this.btnNavMyRegs.Text = "    My Registrations";
            this.btnNavMyRegs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavMyRegs.Click += new System.EventHandler(this.btnNavMyRegs_Click);

            this.btnNavSubmitEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSubmitEvent.FillColor = System.Drawing.Color.Transparent;
            this.btnNavSubmitEvent.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavSubmitEvent.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavSubmitEvent.Location = new System.Drawing.Point(0, 100);
            this.btnNavSubmitEvent.Size = new System.Drawing.Size(230, 50);
            this.btnNavSubmitEvent.Text = "    Submit Event";
            this.btnNavSubmitEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavSubmitEvent.Click += new System.EventHandler(this.btnNavSubmitEvent_Click);

            this.btnNavMyEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMyEvents.FillColor = System.Drawing.Color.Transparent;
            this.btnNavMyEvents.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNavMyEvents.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavMyEvents.Location = new System.Drawing.Point(0, 150);
            this.btnNavMyEvents.Size = new System.Drawing.Size(230, 50);
            this.btnNavMyEvents.Text = "    My Events & Rosters";
            this.btnNavMyEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavMyEvents.Click += new System.EventHandler(this.btnNavMyEvents_Click);

            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnLogout.Location = new System.Drawing.Point(0, 596);
            this.btnLogout.Size = new System.Drawing.Size(230, 50);
            this.btnLogout.Text = "    Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ---------------------------------------------------------
            // 1. BROWSE EVENTS PANEL
            // ---------------------------------------------------------
            this.pnlBrowseEvents.BackColor = System.Drawing.Color.White;
            this.pnlBrowseEvents.Controls.Add(this.lblBrowseTitle);
            this.pnlBrowseEvents.Controls.Add(this.cmbFacultyFilter);
            this.pnlBrowseEvents.Controls.Add(this.dgvEventsFeed);
            this.pnlBrowseEvents.Controls.Add(this.btnRegisterEvent);
            this.pnlBrowseEvents.Location = new System.Drawing.Point(230, 65);
            this.pnlBrowseEvents.Name = "pnlBrowseEvents";
            this.pnlBrowseEvents.Size = new System.Drawing.Size(954, 646);

            this.lblBrowseTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrowseTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrowseTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBrowseTitle.Location = new System.Drawing.Point(30, 20);
            this.lblBrowseTitle.Text = "Approved University Events Feed";

            this.cmbFacultyFilter.BorderRadius = 6;
            this.cmbFacultyFilter.Location = new System.Drawing.Point(30, 65);
            this.cmbFacultyFilter.Size = new System.Drawing.Size(300, 36);
            this.cmbFacultyFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFacultyFilter_SelectedIndexChanged);

            this.dgvEventsFeed.AllowUserToAddRows = false;
            this.dgvEventsFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle1.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle1.ForeColor = System.Drawing.Color.White;
            dgvStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvEventsFeed.ColumnHeadersDefaultCellStyle = dgvStyle1;
            this.dgvEventsFeed.ColumnHeadersHeight = 35;
            this.dgvEventsFeed.Location = new System.Drawing.Point(30, 115);
            this.dgvEventsFeed.Name = "dgvEventsFeed";
            this.dgvEventsFeed.ReadOnly = true;
            this.dgvEventsFeed.RowHeadersVisible = false;
            this.dgvEventsFeed.Size = new System.Drawing.Size(895, 450);

            this.btnRegisterEvent.BorderRadius = 6;
            this.btnRegisterEvent.FillColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnRegisterEvent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegisterEvent.ForeColor = System.Drawing.Color.White;
            this.btnRegisterEvent.Location = new System.Drawing.Point(765, 580);
            this.btnRegisterEvent.Size = new System.Drawing.Size(160, 40);
            this.btnRegisterEvent.Text = "Register for Event";
            this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);

            // ---------------------------------------------------------
            // 2. MY REGISTRATIONS PANEL
            // ---------------------------------------------------------
            this.pnlMyRegistrations.BackColor = System.Drawing.Color.White;
            this.pnlMyRegistrations.Controls.Add(this.lblRegsTitle);
            this.pnlMyRegistrations.Controls.Add(this.dgvMyRegistrations);
            this.pnlMyRegistrations.Controls.Add(this.btnUnregisterEvent);
            this.pnlMyRegistrations.Location = new System.Drawing.Point(230, 65);
            this.pnlMyRegistrations.Name = "pnlMyRegistrations";
            this.pnlMyRegistrations.Size = new System.Drawing.Size(954, 646);
            this.pnlMyRegistrations.Visible = false;

            this.lblRegsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRegsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRegsTitle.Location = new System.Drawing.Point(30, 20);
            this.lblRegsTitle.Text = "My Event Registrations";

            this.dgvMyRegistrations.AllowUserToAddRows = false;
            this.dgvMyRegistrations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle2.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle2.ForeColor = System.Drawing.Color.White;
            dgvStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvMyRegistrations.ColumnHeadersDefaultCellStyle = dgvStyle2;
            this.dgvMyRegistrations.ColumnHeadersHeight = 35;
            this.dgvMyRegistrations.Location = new System.Drawing.Point(30, 75);
            this.dgvMyRegistrations.Name = "dgvMyRegistrations";
            this.dgvMyRegistrations.ReadOnly = true;
            this.dgvMyRegistrations.RowHeadersVisible = false;
            this.dgvMyRegistrations.Size = new System.Drawing.Size(895, 490);

            this.btnUnregisterEvent.BorderRadius = 6;
            this.btnUnregisterEvent.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnUnregisterEvent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUnregisterEvent.ForeColor = System.Drawing.Color.White;
            this.btnUnregisterEvent.Location = new System.Drawing.Point(745, 580);
            this.btnUnregisterEvent.Size = new System.Drawing.Size(180, 40);
            this.btnUnregisterEvent.Text = "Cancel Registration";
            this.btnUnregisterEvent.Click += new System.EventHandler(this.btnUnregisterEvent_Click);

            // ---------------------------------------------------------
            // 3. SUBMIT EVENT PANEL (Organizer)
            // ---------------------------------------------------------
            this.pnlSubmitEvent.BackColor = System.Drawing.Color.White;
            this.pnlSubmitEvent.Controls.Add(this.lblSubmitTitle);
            this.pnlSubmitEvent.Controls.Add(this.txtEventTitle);
            this.pnlSubmitEvent.Controls.Add(this.txtEventDesc);
            this.pnlSubmitEvent.Controls.Add(this.txtEventLocation);
            this.pnlSubmitEvent.Controls.Add(this.dtpEventDate);
            this.pnlSubmitEvent.Controls.Add(this.cmbTargetFaculty);
            this.pnlSubmitEvent.Controls.Add(this.chkRequireLogin);
            this.pnlSubmitEvent.Controls.Add(this.lblRequireLoginText);
            this.pnlSubmitEvent.Controls.Add(this.btnSaveEvent);
            this.pnlSubmitEvent.Location = new System.Drawing.Point(230, 65);
            this.pnlSubmitEvent.Name = "pnlSubmitEvent";
            this.pnlSubmitEvent.Size = new System.Drawing.Size(954, 646);
            this.pnlSubmitEvent.Visible = false;

            this.lblSubmitTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmitTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSubmitTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSubmitTitle.Location = new System.Drawing.Point(30, 20);
            this.lblSubmitTitle.Text = "Submit New Event for Approval";

            this.txtEventTitle.BorderRadius = 6;
            this.txtEventTitle.Location = new System.Drawing.Point(30, 80);
            this.txtEventTitle.PlaceholderText = "Event Title";
            this.txtEventTitle.Size = new System.Drawing.Size(500, 40);

            this.txtEventDesc.BorderRadius = 6;
            this.txtEventDesc.Location = new System.Drawing.Point(30, 140);
            this.txtEventDesc.Multiline = true;
            this.txtEventDesc.PlaceholderText = "Full Event Description";
            this.txtEventDesc.Size = new System.Drawing.Size(500, 100);

            this.txtEventLocation.BorderRadius = 6;
            this.txtEventLocation.Location = new System.Drawing.Point(30, 260);
            this.txtEventLocation.PlaceholderText = "Location / Venue";
            this.txtEventLocation.Size = new System.Drawing.Size(500, 40);

            this.dtpEventDate.BorderRadius = 6;
            this.dtpEventDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(30, 320);
            this.dtpEventDate.Size = new System.Drawing.Size(500, 40);

            this.cmbTargetFaculty.BorderRadius = 6;
            this.cmbTargetFaculty.Location = new System.Drawing.Point(30, 380);
            this.cmbTargetFaculty.Size = new System.Drawing.Size(500, 40);

            this.chkRequireLogin.Location = new System.Drawing.Point(35, 442);
            this.chkRequireLogin.Size = new System.Drawing.Size(20, 20);

            this.lblRequireLoginText.AutoSize = true;
            this.lblRequireLoginText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRequireLoginText.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRequireLoginText.Location = new System.Drawing.Point(65, 442);
            this.lblRequireLoginText.Text = "Require login for full details";

            this.btnSaveEvent.BorderRadius = 6;
            this.btnSaveEvent.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnSaveEvent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveEvent.ForeColor = System.Drawing.Color.White;
            this.btnSaveEvent.Location = new System.Drawing.Point(350, 500);
            this.btnSaveEvent.Size = new System.Drawing.Size(180, 42);
            this.btnSaveEvent.Text = "Submit Event";
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);

            // ---------------------------------------------------------
            // 4. MY EVENTS & ATTENDEE ROSTERS PANEL (Organizer)
            // ---------------------------------------------------------
            this.pnlMyEvents.BackColor = System.Drawing.Color.White;
            this.pnlMyEvents.Controls.Add(this.lblMyEventsTitle);
            this.pnlMyEvents.Controls.Add(this.dgvMyCreatedEvents);
            this.pnlMyEvents.Controls.Add(this.dgvAttendees);
            this.pnlMyEvents.Controls.Add(this.btnViewAttendees);
            this.pnlMyEvents.Location = new System.Drawing.Point(230, 65);
            this.pnlMyEvents.Name = "pnlMyEvents";
            this.pnlMyEvents.Size = new System.Drawing.Size(954, 646);
            this.pnlMyEvents.Visible = false;

            this.lblMyEventsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMyEventsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMyEventsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMyEventsTitle.Location = new System.Drawing.Point(30, 20);
            this.lblMyEventsTitle.Text = "My Events & Attendee Rosters";

            this.dgvMyCreatedEvents.AllowUserToAddRows = false;
            this.dgvMyCreatedEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle3.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle3.ForeColor = System.Drawing.Color.White;
            dgvStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvMyCreatedEvents.ColumnHeadersDefaultCellStyle = dgvStyle3;
            this.dgvMyCreatedEvents.ColumnHeadersHeight = 35;
            this.dgvMyCreatedEvents.Location = new System.Drawing.Point(30, 70);
            this.dgvMyCreatedEvents.Name = "dgvMyCreatedEvents";
            this.dgvMyCreatedEvents.ReadOnly = true;
            this.dgvMyCreatedEvents.RowHeadersVisible = false;
            this.dgvMyCreatedEvents.Size = new System.Drawing.Size(895, 230);

            this.btnViewAttendees.BorderRadius = 6;
            this.btnViewAttendees.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnViewAttendees.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewAttendees.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendees.Location = new System.Drawing.Point(745, 310);
            this.btnViewAttendees.Size = new System.Drawing.Size(180, 36);
            this.btnViewAttendees.Text = "View Attendee Roster";
            this.btnViewAttendees.Click += new System.EventHandler(this.btnViewAttendees_Click);

            this.dgvAttendees.AllowUserToAddRows = false;
            this.dgvAttendees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvStyle4.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dgvStyle4.ForeColor = System.Drawing.Color.White;
            dgvStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvAttendees.ColumnHeadersDefaultCellStyle = dgvStyle4;
            this.dgvAttendees.ColumnHeadersHeight = 35;
            this.dgvAttendees.Location = new System.Drawing.Point(30, 355);
            this.dgvAttendees.Name = "dgvAttendees";
            this.dgvAttendees.ReadOnly = true;
            this.dgvAttendees.RowHeadersVisible = false;
            this.dgvAttendees.Size = new System.Drawing.Size(895, 250);

            // 
            // frmDashboard Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlMyEvents);
            this.Controls.Add(this.pnlSubmitEvent);
            this.Controls.Add(this.pnlMyRegistrations);
            this.Controls.Add(this.pnlBrowseEvents);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniEvent Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashboard_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlBrowseEvents.ResumeLayout(false);
            this.pnlBrowseEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventsFeed)).EndInit();
            this.pnlMyRegistrations.ResumeLayout(false);
            this.pnlMyRegistrations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRegistrations)).EndInit();
            this.pnlSubmitEvent.ResumeLayout(false);
            this.pnlSubmitEvent.PerformLayout();
            this.pnlMyEvents.ResumeLayout(false);
            this.pnlMyEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCreatedEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDashboardTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserRoleSession;
        private Guna.UI2.WinForms.Guna2TextBox txtHeaderSearchBox;

        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnNavBrowse;
        private Guna.UI2.WinForms.Guna2Button btnNavMyRegs;
        private Guna.UI2.WinForms.Guna2Button btnNavSubmitEvent;
        private Guna.UI2.WinForms.Guna2Button btnNavMyEvents;
        private Guna.UI2.WinForms.Guna2Button btnLogout;

        private Guna.UI2.WinForms.Guna2Panel pnlBrowseEvents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrowseTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFacultyFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEventsFeed;
        private Guna.UI2.WinForms.Guna2Button btnRegisterEvent;

        private Guna.UI2.WinForms.Guna2Panel pnlMyRegistrations;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegsTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMyRegistrations;
        private Guna.UI2.WinForms.Guna2Button btnUnregisterEvent;

        private Guna.UI2.WinForms.Guna2Panel pnlSubmitEvent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubmitTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtEventTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtEventDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtEventLocation;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEventDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTargetFaculty;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkRequireLogin;
        private System.Windows.Forms.Label lblRequireLoginText;
        private Guna.UI2.WinForms.Guna2Button btnSaveEvent;

        private Guna.UI2.WinForms.Guna2Panel pnlMyEvents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMyEventsTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMyCreatedEvents;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAttendees;
        private Guna.UI2.WinForms.Guna2Button btnViewAttendees;
    }
}