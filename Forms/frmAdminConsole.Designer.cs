namespace UniEventApp.Forms
{
    partial class frmAdminConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminConsole));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlAdminHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAdminTab = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAdminDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdminSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlAdminUserManagement = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAdmineventApproval = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAdminFacultySettings = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAdminHeader.SuspendLayout();
            this.pnlAdminTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlAdminHeader
            // 
            this.pnlAdminHeader.Controls.Add(this.txtAdminSearchBox);
            this.pnlAdminHeader.Controls.Add(this.guna2ImageButton1);
            this.pnlAdminHeader.Controls.Add(this.guna2HtmlLabel1);
            this.pnlAdminHeader.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlAdminHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlAdminHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminHeader.Name = "pnlAdminHeader";
            this.pnlAdminHeader.Size = new System.Drawing.Size(1184, 67);
            this.pnlAdminHeader.TabIndex = 0;
            // 
            // pnlAdminTab
            // 
            this.pnlAdminTab.Controls.Add(this.guna2Button3);
            this.pnlAdminTab.Controls.Add(this.guna2Button2);
            this.pnlAdminTab.Controls.Add(this.guna2Button1);
            this.pnlAdminTab.Controls.Add(this.btnDashHome);
            this.pnlAdminTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminTab.Location = new System.Drawing.Point(0, 67);
            this.pnlAdminTab.Name = "pnlAdminTab";
            this.pnlAdminTab.Size = new System.Drawing.Size(240, 644);
            this.pnlAdminTab.TabIndex = 1;
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnlAdminDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlAdminDashboard.Location = new System.Drawing.Point(237, 67);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(947, 644);
            this.pnlAdminDashboard.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(69, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(202, 36);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Admin Portal";
            // 
            // txtAdminSearchBox
            // 
            this.txtAdminSearchBox.Animated = true;
            this.txtAdminSearchBox.BorderRadius = 2;
            this.txtAdminSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminSearchBox.DefaultText = "";
            this.txtAdminSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdminSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdminSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdminSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminSearchBox.Location = new System.Drawing.Point(878, 15);
            this.txtAdminSearchBox.Name = "txtAdminSearchBox";
            this.txtAdminSearchBox.PlaceholderText = "Search For Events";
            this.txtAdminSearchBox.SelectedText = "";
            this.txtAdminSearchBox.Size = new System.Drawing.Size(294, 36);
            this.txtAdminSearchBox.TabIndex = 3;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.LightBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button3.Image = global::UniEventApp.Properties.Resources.faculty;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(20, 0);
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(0, 135);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(240, 45);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Faculty Settings";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.TextOffset = new System.Drawing.Point(30, 0);
            this.guna2Button3.UseTransparentBackground = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.LightBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button2.Image = global::UniEventApp.Properties.Resources.event_check;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(20, 0);
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(0, 90);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(240, 45);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Event Approval";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(30, 0);
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.LightBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button1.Image = global::UniEventApp.Properties.Resources.user_manage;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(20, 0);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(0, 45);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(240, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "User Management";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(30, 0);
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // btnDashHome
            // 
            this.btnDashHome.Animated = true;
            this.btnDashHome.BackColor = System.Drawing.Color.Transparent;
            this.btnDashHome.BorderColor = System.Drawing.Color.Gray;
            this.btnDashHome.BorderThickness = 1;
            this.btnDashHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashHome.FillColor = System.Drawing.Color.LightBlue;
            this.btnDashHome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDashHome.ForeColor = System.Drawing.Color.Black;
            this.btnDashHome.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDashHome.Image = global::UniEventApp.Properties.Resources.home;
            this.btnDashHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashHome.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDashHome.IndicateFocus = true;
            this.btnDashHome.Location = new System.Drawing.Point(0, 0);
            this.btnDashHome.Name = "btnDashHome";
            this.btnDashHome.Size = new System.Drawing.Size(240, 45);
            this.btnDashHome.TabIndex = 1;
            this.btnDashHome.Text = "Dashboard";
            this.btnDashHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashHome.TextOffset = new System.Drawing.Point(30, 0);
            this.btnDashHome.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::UniEventApp.Properties.Resources.apprentice;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(17, 11);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(46, 46);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // pnlAdminUserManagement
            // 
            this.pnlAdminUserManagement.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnlAdminUserManagement.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlAdminUserManagement.Location = new System.Drawing.Point(237, 67);
            this.pnlAdminUserManagement.Name = "pnlAdminUserManagement";
            this.pnlAdminUserManagement.Size = new System.Drawing.Size(947, 644);
            this.pnlAdminUserManagement.TabIndex = 0;
            // 
            // pnlAdmineventApproval
            // 
            this.pnlAdmineventApproval.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnlAdmineventApproval.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlAdmineventApproval.Location = new System.Drawing.Point(237, 67);
            this.pnlAdmineventApproval.Name = "pnlAdmineventApproval";
            this.pnlAdmineventApproval.Size = new System.Drawing.Size(944, 644);
            this.pnlAdmineventApproval.TabIndex = 0;
            // 
            // pnlAdminFacultySettings
            // 
            this.pnlAdminFacultySettings.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnlAdminFacultySettings.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlAdminFacultySettings.Location = new System.Drawing.Point(237, 67);
            this.pnlAdminFacultySettings.Name = "pnlAdminFacultySettings";
            this.pnlAdminFacultySettings.Size = new System.Drawing.Size(947, 644);
            this.pnlAdminFacultySettings.TabIndex = 1;
            // 
            // frmAdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlAdminTab);
            this.Controls.Add(this.pnlAdminHeader);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Controls.Add(this.pnlAdmineventApproval);
            this.Controls.Add(this.pnlAdminUserManagement);
            this.Controls.Add(this.pnlAdminFacultySettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdminConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminConsole_FormClosed);
            this.pnlAdminHeader.ResumeLayout(false);
            this.pnlAdminHeader.PerformLayout();
            this.pnlAdminTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlAdminHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlAdminDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlAdminTab;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnDashHome;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminSearchBox;
        private Guna.UI2.WinForms.Guna2Panel pnlAdminUserManagement;
        private Guna.UI2.WinForms.Guna2Panel pnlAdmineventApproval;
        private Guna.UI2.WinForms.Guna2Panel pnlAdminFacultySettings;
    }
}