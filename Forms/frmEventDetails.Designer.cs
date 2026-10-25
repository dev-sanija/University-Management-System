namespace UniEventApp.Forms
{
    partial class frmEventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventDetails));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEventDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLocLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOrgLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOrganizer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(750, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(182, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Event Information";
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.lblTitleLabel.Location = new System.Drawing.Point(35, 85);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(66, 19);
            this.lblTitleLabel.TabIndex = 1;
            this.lblTitleLabel.Text = "Event Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.BorderRadius = 6;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(35, 110);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(680, 40);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescLabel
            // 
            this.lblDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblDescLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescLabel.ForeColor = System.Drawing.Color.Black;
            this.lblDescLabel.Location = new System.Drawing.Point(35, 165);
            this.lblDescLabel.Name = "lblDescLabel";
            this.lblDescLabel.Size = new System.Drawing.Size(124, 19);
            this.lblDescLabel.TabIndex = 3;
            this.lblDescLabel.Text = "Description / Details";
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderRadius = 6;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(35, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(680, 110);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateLabel.ForeColor = System.Drawing.Color.Black;
            this.lblDateLabel.Location = new System.Drawing.Point(35, 315);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(91, 19);
            this.lblDateLabel.TabIndex = 5;
            this.lblDateLabel.Text = "Date and Time";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Animated = true;
            this.txtEventDate.BorderRadius = 6;
            this.txtEventDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEventDate.DefaultText = "";
            this.txtEventDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEventDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txtEventDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtEventDate.Enabled = false;
            this.txtEventDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEventDate.ForeColor = System.Drawing.Color.Black;
            this.txtEventDate.Location = new System.Drawing.Point(35, 340);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.PlaceholderText = "";
            this.txtEventDate.SelectedText = "";
            this.txtEventDate.Size = new System.Drawing.Size(325, 40);
            this.txtEventDate.TabIndex = 6;
            // 
            // lblLocLabel
            // 
            this.lblLocLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLocLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocLabel.ForeColor = System.Drawing.Color.Black;
            this.lblLocLabel.Location = new System.Drawing.Point(390, 315);
            this.lblLocLabel.Name = "lblLocLabel";
            this.lblLocLabel.Size = new System.Drawing.Size(54, 19);
            this.lblLocLabel.TabIndex = 7;
            this.lblLocLabel.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Animated = true;
            this.txtLocation.BorderRadius = 6;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtLocation.Enabled = false;
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(390, 340);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PlaceholderText = "";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(325, 40);
            this.txtLocation.TabIndex = 8;
            // 
            // lblOrgLabel
            // 
            this.lblOrgLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblOrgLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrgLabel.ForeColor = System.Drawing.Color.Black;
            this.lblOrgLabel.Location = new System.Drawing.Point(35, 400);
            this.lblOrgLabel.Name = "lblOrgLabel";
            this.lblOrgLabel.Size = new System.Drawing.Size(62, 19);
            this.lblOrgLabel.TabIndex = 9;
            this.lblOrgLabel.Text = "Organizer";
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Animated = true;
            this.txtOrganizer.BorderRadius = 6;
            this.txtOrganizer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrganizer.DefaultText = "";
            this.txtOrganizer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrganizer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txtOrganizer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtOrganizer.Enabled = false;
            this.txtOrganizer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOrganizer.ForeColor = System.Drawing.Color.Black;
            this.txtOrganizer.Location = new System.Drawing.Point(35, 425);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.PlaceholderText = "";
            this.txtOrganizer.SelectedText = "";
            this.txtOrganizer.Size = new System.Drawing.Size(325, 40);
            this.txtOrganizer.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 6;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnClose.Location = new System.Drawing.Point(445, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 42);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.BorderRadius = 6;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnRegister.Location = new System.Drawing.Point(585, 535);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 42);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register Event";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOrganizer);
            this.Controls.Add(this.lblOrgLabel);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocLabel);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.lblDateLabel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescLabel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitleLabel);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEventDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Details";
            this.Load += new System.EventHandler(this.frmEventDetails_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtEventDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLocLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrgLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtOrganizer;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
    }
}