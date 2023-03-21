namespace Reszke
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.navTimeLabel = new System.Windows.Forms.Label();
            this.navTopImage = new System.Windows.Forms.PictureBox();
            this.navTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loggedUserLabel = new System.Windows.Forms.Label();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.sideNavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sideNavPanel.Controls.Add(this.navTimeLabel);
            this.sideNavPanel.Controls.Add(this.navTopImage);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(211, 574);
            this.sideNavPanel.TabIndex = 0;
            // 
            // navTimeLabel
            // 
            this.navTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.navTimeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navTimeLabel.Location = new System.Drawing.Point(88, 9);
            this.navTimeLabel.Name = "navTimeLabel";
            this.navTimeLabel.Size = new System.Drawing.Size(123, 68);
            this.navTimeLabel.TabIndex = 1;
            this.navTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // navTopImage
            // 
            this.navTopImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.navTopImage.BackColor = System.Drawing.Color.Transparent;
            this.navTopImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navTopImage.Image = global::Reszke.Properties.Resources.logo;
            this.navTopImage.InitialImage = global::Reszke.Properties.Resources.logo;
            this.navTopImage.Location = new System.Drawing.Point(3, 0);
            this.navTopImage.Name = "navTopImage";
            this.navTopImage.Size = new System.Drawing.Size(97, 75);
            this.navTopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navTopImage.TabIndex = 0;
            this.navTopImage.TabStop = false;
            // 
            // navTimeTimer
            // 
            this.navTimeTimer.Enabled = true;
            this.navTimeTimer.Interval = 500;
            this.navTimeTimer.Tick += new System.EventHandler(this.navTimeTimer_Tick);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(394, 91);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 23);
            this.login.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(394, 120);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(394, 149);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 35);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loggedUserLabel
            // 
            this.loggedUserLabel.AutoSize = true;
            this.loggedUserLabel.Location = new System.Drawing.Point(397, 202);
            this.loggedUserLabel.Name = "loggedUserLabel";
            this.loggedUserLabel.Size = new System.Drawing.Size(78, 15);
            this.loggedUserLabel.TabIndex = 4;
            this.loggedUserLabel.Text = "not logged in";
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(580, 91);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(100, 23);
            this.newPasswordBox.TabIndex = 5;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(580, 138);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(100, 35);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "zmien haslo";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 574);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.loggedUserLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.sideNavPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "mainForm";
            this.Text = "Biblioteka - Reszke, Zaindin, Wierkin, Wysocki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideNavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sideNavPanel;
        private PictureBox navTopImage;
        private Label navTimeLabel;
        private System.Windows.Forms.Timer navTimeTimer;
        private TextBox login;
        private TextBox password;
        private Button loginButton;
        private Label loggedUserLabel;
        private TextBox newPasswordBox;
        private Button changePasswordButton;
    }
}