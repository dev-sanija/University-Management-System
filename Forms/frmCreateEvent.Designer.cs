namespace UniEventApp.Forms
{
    partial class frmCreateEvent
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEventDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpEventDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFaculty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbTargetFaculty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkRequiresLogin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnPublish = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(650, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(212, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "New University Event";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(35, 85);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Event Title *";
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.BorderRadius = 6;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTitle.Location = new System.Drawing.Point(35, 110);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "e.g., Annual Tech Symposium 2026";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(580, 40);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(35, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(124, 19);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description / Details";
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderRadius = 6;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(35, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Provide event description, agenda, and instructions...";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(580, 110);
            this.txtDescription.TabIndex = 4;
            // 
            // lblEventDate
            // 
            this.lblEventDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEventDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEventDate.ForeColor = System.Drawing.Color.Black;
            this.lblEventDate.Location = new System.Drawing.Point(35, 315);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(125, 19);
            this.lblEventDate.TabIndex = 5;
            this.lblEventDate.Text = "Event Date & Time *";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Animated = true;
            this.dtpEventDate.BorderRadius = 6;
            this.dtpEventDate.Checked = true;
            this.dtpEventDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEventDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtpEventDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(35, 340);
            this.dtpEventDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEventDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(270, 40);
            this.dtpEventDate.TabIndex = 6;
            this.dtpEventDate.Value = new System.DateTime(2026, 10, 26, 12, 0, 0, 0);
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.Location = new System.Drawing.Point(345, 315);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(64, 19);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location *";
            // 
            // txtLocation
            // 
            this.txtLocation.Animated = true;
            this.txtLocation.BorderRadius = 6;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLocation.Location = new System.Drawing.Point(345, 340);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PlaceholderText = "e.g., Main Auditorium / Lab 304";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(270, 40);
            this.txtLocation.TabIndex = 8;
            // 
            // lblFaculty
            // 
            this.lblFaculty.BackColor = System.Drawing.Color.Transparent;
            this.lblFaculty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFaculty.ForeColor = System.Drawing.Color.Black;
            this.lblFaculty.Location = new System.Drawing.Point(35, 400);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(89, 19);
            this.lblFaculty.TabIndex = 9;
            this.lblFaculty.Text = "Target Faculty";
            // 
            // cmbTargetFaculty
            // 
            this.cmbTargetFaculty.Animated = true;
            this.cmbTargetFaculty.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetFaculty.BorderRadius = 6;
            this.cmbTargetFaculty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetFaculty.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetFaculty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetFaculty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbTargetFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTargetFaculty.ItemHeight = 34;
            this.cmbTargetFaculty.Location = new System.Drawing.Point(35, 425);
            this.cmbTargetFaculty.Name = "cmbTargetFaculty";
            this.cmbTargetFaculty.Size = new System.Drawing.Size(270, 40);
            this.cmbTargetFaculty.TabIndex = 10;
            // 
            // chkRequiresLogin
            // 
            this.chkRequiresLogin.Animated = true;
            this.chkRequiresLogin.AutoSize = true;
            this.chkRequiresLogin.Checked = true;
            this.chkRequiresLogin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.chkRequiresLogin.CheckedState.BorderRadius = 2;
            this.chkRequiresLogin.CheckedState.BorderThickness = 0;
            this.chkRequiresLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.chkRequiresLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequiresLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkRequiresLogin.Location = new System.Drawing.Point(345, 435);
            this.chkRequiresLogin.Name = "chkRequiresLogin";
            this.chkRequiresLogin.Size = new System.Drawing.Size(226, 21);
            this.chkRequiresLogin.TabIndex = 11;
            this.chkRequiresLogin.Text = "Requires User Login / Verification";
            this.chkRequiresLogin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRequiresLogin.UncheckedState.BorderRadius = 2;
            this.chkRequiresLogin.UncheckedState.BorderThickness = 0;
            this.chkRequiresLogin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnPublish
            // 
            this.btnPublish.Animated = true;
            this.btnPublish.BorderRadius = 6;
            this.btnPublish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnPublish.Location = new System.Drawing.Point(455, 590);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(160, 42);
            this.btnPublish.TabIndex = 12;
            this.btnPublish.Text = "Publish Event";
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(315, 590);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 42);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.chkRequiresLogin);
            this.Controls.Add(this.cmbTargetFaculty);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Event";
            this.Load += new System.EventHandler(this.frmCreateEvent_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEventDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEventDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFaculty;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTargetFaculty;
        private Guna.UI2.WinForms.Guna2CheckBox chkRequiresLogin;
        private Guna.UI2.WinForms.Guna2Button btnPublish;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}