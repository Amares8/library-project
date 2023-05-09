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
            this.navButtonsPanel = new System.Windows.Forms.Panel();
            this.lendingsNavButton = new System.Windows.Forms.Button();
            this.navTimeLabel = new System.Windows.Forms.Label();
            this.navTopImage = new System.Windows.Forms.PictureBox();
            this.navTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.lendingsPanel = new System.Windows.Forms.Panel();
            this.lendingsDataGridView = new System.Windows.Forms.DataGridView();
            this.lendingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.userSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sideNavPanel.SuspendLayout();
            this.navButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.lendingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendingsDataGridView)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sideNavPanel.Controls.Add(this.navButtonsPanel);
            this.sideNavPanel.Controls.Add(this.navTimeLabel);
            this.sideNavPanel.Controls.Add(this.navTopImage);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(211, 574);
            this.sideNavPanel.TabIndex = 0;
            // 
            // navButtonsPanel
            // 
            this.navButtonsPanel.Controls.Add(this.lendingsNavButton);
            this.navButtonsPanel.Location = new System.Drawing.Point(12, 96);
            this.navButtonsPanel.Name = "navButtonsPanel";
            this.navButtonsPanel.Size = new System.Drawing.Size(173, 274);
            this.navButtonsPanel.TabIndex = 3;
            this.navButtonsPanel.Visible = false;
            // 
            // lendingsNavButton
            // 
            this.lendingsNavButton.Location = new System.Drawing.Point(32, 22);
            this.lendingsNavButton.Name = "lendingsNavButton";
            this.lendingsNavButton.Size = new System.Drawing.Size(107, 38);
            this.lendingsNavButton.TabIndex = 2;
            this.lendingsNavButton.Text = "Wypożyczenia";
            this.lendingsNavButton.UseVisualStyleBackColor = true;
            this.lendingsNavButton.Click += new System.EventHandler(this.lendingsNavButton_Click);
            // 
            // navTimeLabel
            // 
            this.navTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.navTimeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navTimeLabel.Location = new System.Drawing.Point(97, 9);
            this.navTimeLabel.Name = "navTimeLabel";
            this.navTimeLabel.Size = new System.Drawing.Size(114, 66);
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
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginPanel.Controls.Add(this.loginErrorLabel);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(211, 56);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(717, 518);
            this.loginPanel.TabIndex = 1;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(171, 207);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(282, 40);
            this.loginErrorLabel.TabIndex = 3;
            this.loginErrorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(171, 285);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(282, 29);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox.Location = new System.Drawing.Point(171, 250);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(282, 29);
            this.loginTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Location = new System.Drawing.Point(227, 329);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(168, 49);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj się";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // lendingsPanel
            // 
            this.lendingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.lendingsPanel.Controls.Add(this.lendingsDataGridView);
            this.lendingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendingsPanel.Location = new System.Drawing.Point(211, 56);
            this.lendingsPanel.Name = "lendingsPanel";
            this.lendingsPanel.Size = new System.Drawing.Size(717, 518);
            this.lendingsPanel.TabIndex = 4;
            this.lendingsPanel.Visible = false;
            this.lendingsPanel.VisibleChanged += new System.EventHandler(this.lendingsPanel_VisibleChanged);
            // 
            // lendingsDataGridView
            // 
            this.lendingsDataGridView.AllowUserToAddRows = false;
            this.lendingsDataGridView.AllowUserToDeleteRows = false;
            this.lendingsDataGridView.AllowUserToResizeColumns = false;
            this.lendingsDataGridView.AllowUserToResizeRows = false;
            this.lendingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lendingID,
            this.bookName,
            this.customer,
            this.employee,
            this.lendingDate,
            this.returnDate,
            this.finalReturnDate});
            this.lendingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendingsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lendingsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lendingsDataGridView.Name = "lendingsDataGridView";
            this.lendingsDataGridView.ReadOnly = true;
            this.lendingsDataGridView.RowTemplate.Height = 25;
            this.lendingsDataGridView.Size = new System.Drawing.Size(717, 518);
            this.lendingsDataGridView.TabIndex = 0;
            // 
            // lendingID
            // 
            this.lendingID.HeaderText = "ID";
            this.lendingID.Name = "lendingID";
            this.lendingID.ReadOnly = true;
            this.lendingID.Width = 43;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Tytuł";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 57;
            // 
            // customer
            // 
            this.customer.HeaderText = "Klient";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Width = 62;
            // 
            // employee
            // 
            this.employee.HeaderText = "Pracownik";
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            this.employee.Width = 87;
            // 
            // lendingDate
            // 
            this.lendingDate.HeaderText = "Data wypożyczenia";
            this.lendingDate.Name = "lendingDate";
            this.lendingDate.ReadOnly = true;
            this.lendingDate.Width = 121;
            // 
            // returnDate
            // 
            this.returnDate.HeaderText = "Termin zwrotu";
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            this.returnDate.Width = 98;
            // 
            // finalReturnDate
            // 
            this.finalReturnDate.HeaderText = "Data oddania";
            this.finalReturnDate.Name = "finalReturnDate";
            this.finalReturnDate.ReadOnly = true;
            this.finalReturnDate.Width = 94;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.topPanel.Controls.Add(this.currentUserLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(211, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(717, 56);
            this.topPanel.TabIndex = 2;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentUserLabel.Location = new System.Drawing.Point(534, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(141, 44);
            this.currentUserLabel.TabIndex = 0;
            this.currentUserLabel.Text = "as";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userSessionBindingSource
            // 
            this.userSessionBindingSource.DataSource = typeof(Reszke.UserSession);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.lendingsPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sideNavPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "mainForm";
            this.Text = "Biblioteka - Reszke, Zaindin, Wierkin, Wysocki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideNavPanel.ResumeLayout(false);
            this.navButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.lendingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lendingsDataGridView)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userSessionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sideNavPanel;
        private PictureBox navTopImage;
        private Label navTimeLabel;
        private System.Windows.Forms.Timer navTimeTimer;
        private Panel loginPanel;
        private Label loginErrorLabel;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button loginButton;
        private Panel topPanel;
        private Panel lendingsPanel;
        private DataGridView lendingsDataGridView;
        private BindingSource userSessionBindingSource;
        private DataGridViewTextBoxColumn lendingID;
        private DataGridViewTextBoxColumn bookName;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn employee;
        private DataGridViewTextBoxColumn lendingDate;
        private DataGridViewTextBoxColumn returnDate;
        private DataGridViewTextBoxColumn finalReturnDate;
        private Button lendingsNavButton;
        private Panel navButtonsPanel;
        private Label currentUserLabel;
    }
}