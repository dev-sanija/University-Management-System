namespace UniEventApp.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTab = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFeed = new Guna.UI2.WinForms.Guna2Panel();
            this.lblunieventmanager = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboSearchFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDashSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlTab.SuspendLayout();
            this.pnlFeed.SuspendLayout();
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
            this.pnlHeader.Controls.Add(this.comboSearchFilter);
            this.pnlHeader.Controls.Add(this.txtSearchBox);
            this.pnlHeader.Controls.Add(this.guna2ImageButton1);
            this.pnlHeader.Controls.Add(this.lblunieventmanager);
            this.pnlHeader.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 67);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.btnDashSettings);
            this.pnlTab.Controls.Add(this.btnDashHome);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTab.Location = new System.Drawing.Point(0, 67);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(240, 644);
            this.pnlTab.TabIndex = 1;
            // 
            // pnlFeed
            // 
            this.pnlFeed.Controls.Add(this.pnlSettings);
            this.pnlFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFeed.Location = new System.Drawing.Point(240, 67);
            this.pnlFeed.Name = "pnlFeed";
            this.pnlFeed.Size = new System.Drawing.Size(944, 644);
            this.pnlFeed.TabIndex = 2;
            // 
            // lblunieventmanager
            // 
            this.lblunieventmanager.BackColor = System.Drawing.Color.Transparent;
            this.lblunieventmanager.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunieventmanager.ForeColor = System.Drawing.Color.Navy;
            this.lblunieventmanager.Location = new System.Drawing.Point(69, 14);
            this.lblunieventmanager.Name = "lblunieventmanager";
            this.lblunieventmanager.Size = new System.Drawing.Size(391, 36);
            this.lblunieventmanager.TabIndex = 0;
            this.lblunieventmanager.Text = "University Event Manager";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Animated = true;
            this.txtSearchBox.BorderRadius = 2;
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Location = new System.Drawing.Point(878, 15);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PlaceholderText = "Search For Events";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(294, 36);
            this.txtSearchBox.TabIndex = 1;
            // 
            // comboSearchFilter
            // 
            this.comboSearchFilter.BackColor = System.Drawing.Color.Transparent;
            this.comboSearchFilter.BorderRadius = 2;
            this.comboSearchFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSearchFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSearchFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboSearchFilter.ItemHeight = 30;
            this.comboSearchFilter.Items.AddRange(new object[] {
            "All",
            "Administrator",
            "Open",
            "Closed"});
            this.comboSearchFilter.Location = new System.Drawing.Point(703, 15);
            this.comboSearchFilter.Name = "comboSearchFilter";
            this.comboSearchFilter.Size = new System.Drawing.Size(169, 36);
            this.comboSearchFilter.TabIndex = 2;
            // 
            // btnDashSettings
            // 
            this.btnDashSettings.Animated = true;
            this.btnDashSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnDashSettings.BorderColor = System.Drawing.Color.Gray;
            this.btnDashSettings.BorderThickness = 1;
            this.btnDashSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashSettings.FillColor = System.Drawing.Color.LightBlue;
            this.btnDashSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDashSettings.ForeColor = System.Drawing.Color.Black;
            this.btnDashSettings.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDashSettings.Image = global::UniEventApp.Properties.Resources.setting;
            this.btnDashSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashSettings.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDashSettings.IndicateFocus = true;
            this.btnDashSettings.Location = new System.Drawing.Point(0, 45);
            this.btnDashSettings.Name = "btnDashSettings";
            this.btnDashSettings.Size = new System.Drawing.Size(240, 45);
            this.btnDashSettings.TabIndex = 1;
            this.btnDashSettings.Text = "Settings";
            this.btnDashSettings.UseTransparentBackground = true;
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
            this.btnDashHome.TabIndex = 0;
            this.btnDashHome.Text = "Dashboard";
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
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(944, 644);
            this.pnlSettings.TabIndex = 0;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlFeed);
            this.Controls.Add(this.pnlTab);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTab.ResumeLayout(false);
            this.pnlFeed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlFeed;
        private Guna.UI2.WinForms.Guna2Panel pnlTab;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblunieventmanager;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button btnDashHome;
        private Guna.UI2.WinForms.Guna2ComboBox comboSearchFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private Guna.UI2.WinForms.Guna2Button btnDashSettings;
        private Guna.UI2.WinForms.Guna2Panel pnlSettings;
    }
}