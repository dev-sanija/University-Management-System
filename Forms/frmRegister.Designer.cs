namespace UniEventApp.Forms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ShadowPanellogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelMain = new System.Windows.Forms.Label();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.txtRegConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegStudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegStudentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegStudentUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShadowPanellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ShadowPanellogin
            // 
            this.ShadowPanellogin.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanellogin.Controls.Add(this.linkLogin);
            this.ShadowPanellogin.Controls.Add(this.btnRegister);
            this.ShadowPanellogin.Controls.Add(this.txtRegConfirmPassword);
            this.ShadowPanellogin.Controls.Add(this.txtRegStudentID);
            this.ShadowPanellogin.Controls.Add(this.txtRegStudentPassword);
            this.ShadowPanellogin.Controls.Add(this.txtRegStudentUsername);
            this.ShadowPanellogin.Controls.Add(this.labelMain);
            this.ShadowPanellogin.FillColor = System.Drawing.Color.White;
            this.ShadowPanellogin.Location = new System.Drawing.Point(210, 50);
            this.ShadowPanellogin.Name = "ShadowPanellogin";
            this.ShadowPanellogin.Radius = 10;
            this.ShadowPanellogin.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanellogin.ShadowShift = 10;
            this.ShadowPanellogin.Size = new System.Drawing.Size(430, 500);
            this.ShadowPanellogin.TabIndex = 0;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(132, 45);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(166, 29);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Registration";
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.IndicateFocus = true;
            this.btnRegister.Location = new System.Drawing.Point(91, 377);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(248, 45);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLogin.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLogin.Location = new System.Drawing.Point(169, 441);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(92, 17);
            this.linkLogin.TabIndex = 7;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Back to Login";
            // 
            // txtRegConfirmPassword
            // 
            this.txtRegConfirmPassword.Animated = true;
            this.txtRegConfirmPassword.BorderRadius = 5;
            this.txtRegConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegConfirmPassword.DefaultText = "";
            this.txtRegConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegConfirmPassword.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegConfirmPassword.IconLeft = global::UniEventApp.Properties.Resources._lock;
            this.txtRegConfirmPassword.Location = new System.Drawing.Point(36, 304);
            this.txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            this.txtRegConfirmPassword.PasswordChar = '*';
            this.txtRegConfirmPassword.PlaceholderText = "Confirm Your Password";
            this.txtRegConfirmPassword.SelectedText = "";
            this.txtRegConfirmPassword.Size = new System.Drawing.Size(358, 48);
            this.txtRegConfirmPassword.TabIndex = 5;
            this.txtRegConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtRegStudentID
            // 
            this.txtRegStudentID.Animated = true;
            this.txtRegStudentID.BorderRadius = 5;
            this.txtRegStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegStudentID.DefaultText = "";
            this.txtRegStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegStudentID.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegStudentID.IconLeft = global::UniEventApp.Properties.Resources.user;
            this.txtRegStudentID.Location = new System.Drawing.Point(36, 101);
            this.txtRegStudentID.Name = "txtRegStudentID";
            this.txtRegStudentID.PlaceholderText = "Enter Your Student ID";
            this.txtRegStudentID.SelectedText = "";
            this.txtRegStudentID.Size = new System.Drawing.Size(358, 48);
            this.txtRegStudentID.TabIndex = 4;
            this.txtRegStudentID.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtRegStudentPassword
            // 
            this.txtRegStudentPassword.Animated = true;
            this.txtRegStudentPassword.BorderRadius = 5;
            this.txtRegStudentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegStudentPassword.DefaultText = "";
            this.txtRegStudentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegStudentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegStudentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegStudentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegStudentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegStudentPassword.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegStudentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegStudentPassword.IconLeft = global::UniEventApp.Properties.Resources._lock;
            this.txtRegStudentPassword.Location = new System.Drawing.Point(36, 236);
            this.txtRegStudentPassword.Name = "txtRegStudentPassword";
            this.txtRegStudentPassword.PasswordChar = '*';
            this.txtRegStudentPassword.PlaceholderText = "Enter Your Password";
            this.txtRegStudentPassword.SelectedText = "";
            this.txtRegStudentPassword.Size = new System.Drawing.Size(358, 48);
            this.txtRegStudentPassword.TabIndex = 3;
            this.txtRegStudentPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtRegStudentUsername
            // 
            this.txtRegStudentUsername.Animated = true;
            this.txtRegStudentUsername.BorderRadius = 5;
            this.txtRegStudentUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegStudentUsername.DefaultText = "";
            this.txtRegStudentUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegStudentUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegStudentUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegStudentUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegStudentUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegStudentUsername.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegStudentUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegStudentUsername.IconLeft = global::UniEventApp.Properties.Resources.user;
            this.txtRegStudentUsername.Location = new System.Drawing.Point(36, 169);
            this.txtRegStudentUsername.Name = "txtRegStudentUsername";
            this.txtRegStudentUsername.PlaceholderText = "Enter Your Username";
            this.txtRegStudentUsername.SelectedText = "";
            this.txtRegStudentUsername.Size = new System.Drawing.Size(358, 48);
            this.txtRegStudentUsername.TabIndex = 2;
            this.txtRegStudentUsername.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.ShadowPanellogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ShadowPanellogin.ResumeLayout(false);
            this.ShadowPanellogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanellogin;
        private System.Windows.Forms.Label labelMain;
        private Guna.UI2.WinForms.Guna2TextBox txtRegStudentUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtRegConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtRegStudentID;
        private Guna.UI2.WinForms.Guna2TextBox txtRegStudentPassword;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLogin;
    }
}