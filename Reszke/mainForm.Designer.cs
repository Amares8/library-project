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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.navButtonsPanel = new System.Windows.Forms.Panel();
            this.statisticsNavButton = new System.Windows.Forms.Button();
            this.employeesNavButton = new System.Windows.Forms.Button();
            this.customersNavButton = new System.Windows.Forms.Button();
            this.booksNavButton = new System.Windows.Forms.Button();
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
            this.lendingsBottomPanel = new System.Windows.Forms.Panel();
            this.deleteLendingButton = new System.Windows.Forms.Button();
            this.returnLendingButton = new System.Windows.Forms.Button();
            this.newLendingButton = new System.Windows.Forms.Button();
            this.lendingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendingStatusExtended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.userSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendingsFiltersLabel = new System.Windows.Forms.Label();
            this.lendedFilterButton = new System.Windows.Forms.Button();
            this.overdueFilterButton = new System.Windows.Forms.Button();
            this.returnedFilterButton = new System.Windows.Forms.Button();
            this.allFilterButton = new System.Windows.Forms.Button();
            this.sideNavPanel.SuspendLayout();
            this.navButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.lendingsPanel.SuspendLayout();
            this.lendingsBottomPanel.SuspendLayout();
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
            this.navButtonsPanel.Controls.Add(this.statisticsNavButton);
            this.navButtonsPanel.Controls.Add(this.employeesNavButton);
            this.navButtonsPanel.Controls.Add(this.customersNavButton);
            this.navButtonsPanel.Controls.Add(this.booksNavButton);
            this.navButtonsPanel.Controls.Add(this.lendingsNavButton);
            this.navButtonsPanel.Location = new System.Drawing.Point(12, 96);
            this.navButtonsPanel.Name = "navButtonsPanel";
            this.navButtonsPanel.Size = new System.Drawing.Size(173, 365);
            this.navButtonsPanel.TabIndex = 3;
            this.navButtonsPanel.Visible = false;
            // 
            // statisticsNavButton
            // 
            this.statisticsNavButton.Location = new System.Drawing.Point(32, 245);
            this.statisticsNavButton.Name = "statisticsNavButton";
            this.statisticsNavButton.Size = new System.Drawing.Size(107, 38);
            this.statisticsNavButton.TabIndex = 3;
            this.statisticsNavButton.Text = "Statystyki";
            this.statisticsNavButton.UseVisualStyleBackColor = true;
            // 
            // employeesNavButton
            // 
            this.employeesNavButton.Location = new System.Drawing.Point(32, 192);
            this.employeesNavButton.Name = "employeesNavButton";
            this.employeesNavButton.Size = new System.Drawing.Size(107, 38);
            this.employeesNavButton.TabIndex = 3;
            this.employeesNavButton.Text = "Pracownicy";
            this.employeesNavButton.UseVisualStyleBackColor = true;
            // 
            // customersNavButton
            // 
            this.customersNavButton.Location = new System.Drawing.Point(32, 139);
            this.customersNavButton.Name = "customersNavButton";
            this.customersNavButton.Size = new System.Drawing.Size(107, 38);
            this.customersNavButton.TabIndex = 3;
            this.customersNavButton.Text = "Klienci";
            this.customersNavButton.UseVisualStyleBackColor = true;
            // 
            // booksNavButton
            // 
            this.booksNavButton.Location = new System.Drawing.Point(32, 86);
            this.booksNavButton.Name = "booksNavButton";
            this.booksNavButton.Size = new System.Drawing.Size(107, 38);
            this.booksNavButton.TabIndex = 3;
            this.booksNavButton.Text = "Książki";
            this.booksNavButton.UseVisualStyleBackColor = true;
            // 
            // lendingsNavButton
            // 
            this.lendingsNavButton.Location = new System.Drawing.Point(32, 30);
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
            this.lendingsPanel.Controls.Add(this.lendingsBottomPanel);
            this.lendingsPanel.Controls.Add(this.lendingsDataGridView);
            this.lendingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendingsPanel.Location = new System.Drawing.Point(211, 56);
            this.lendingsPanel.Name = "lendingsPanel";
            this.lendingsPanel.Size = new System.Drawing.Size(717, 518);
            this.lendingsPanel.TabIndex = 4;
            this.lendingsPanel.Visible = false;
            this.lendingsPanel.VisibleChanged += new System.EventHandler(this.lendingsPanel_VisibleChanged);
            // 
            // lendingsBottomPanel
            // 
            this.lendingsBottomPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lendingsBottomPanel.Controls.Add(this.allFilterButton);
            this.lendingsBottomPanel.Controls.Add(this.returnedFilterButton);
            this.lendingsBottomPanel.Controls.Add(this.overdueFilterButton);
            this.lendingsBottomPanel.Controls.Add(this.lendedFilterButton);
            this.lendingsBottomPanel.Controls.Add(this.lendingsFiltersLabel);
            this.lendingsBottomPanel.Controls.Add(this.deleteLendingButton);
            this.lendingsBottomPanel.Controls.Add(this.returnLendingButton);
            this.lendingsBottomPanel.Controls.Add(this.newLendingButton);
            this.lendingsBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lendingsBottomPanel.Location = new System.Drawing.Point(0, 410);
            this.lendingsBottomPanel.Name = "lendingsBottomPanel";
            this.lendingsBottomPanel.Size = new System.Drawing.Size(717, 108);
            this.lendingsBottomPanel.TabIndex = 1;
            // 
            // deleteLendingButton
            // 
            this.deleteLendingButton.Location = new System.Drawing.Point(268, 56);
            this.deleteLendingButton.Name = "deleteLendingButton";
            this.deleteLendingButton.Size = new System.Drawing.Size(103, 40);
            this.deleteLendingButton.TabIndex = 0;
            this.deleteLendingButton.Text = "Usuń";
            this.deleteLendingButton.UseVisualStyleBackColor = true;
            this.deleteLendingButton.Click += new System.EventHandler(this.deleteLendingButton_Click);
            // 
            // returnLendingButton
            // 
            this.returnLendingButton.Location = new System.Drawing.Point(142, 56);
            this.returnLendingButton.Name = "returnLendingButton";
            this.returnLendingButton.Size = new System.Drawing.Size(103, 40);
            this.returnLendingButton.TabIndex = 0;
            this.returnLendingButton.Text = "Oddaj";
            this.returnLendingButton.UseVisualStyleBackColor = true;
            this.returnLendingButton.Click += new System.EventHandler(this.returnLendingButton_Click);
            // 
            // newLendingButton
            // 
            this.newLendingButton.Location = new System.Drawing.Point(17, 56);
            this.newLendingButton.Name = "newLendingButton";
            this.newLendingButton.Size = new System.Drawing.Size(103, 40);
            this.newLendingButton.TabIndex = 0;
            this.newLendingButton.Text = "Wypożycz";
            this.newLendingButton.UseVisualStyleBackColor = true;
            this.newLendingButton.Click += new System.EventHandler(this.newLendingButton_Click);
            // 
            // lendingsDataGridView
            // 
            this.lendingsDataGridView.AllowUserToAddRows = false;
            this.lendingsDataGridView.AllowUserToDeleteRows = false;
            this.lendingsDataGridView.AllowUserToResizeRows = false;
            this.lendingsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lendingsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lendingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.bookName,
            this.bookAuthor,
            this.customer,
            this.employee,
            this.lendingDate,
            this.returnDate,
            this.finalReturnDate,
            this.lendingStatus,
            this.lendingStatusExtended});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lendingsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.lendingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendingsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lendingsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lendingsDataGridView.MultiSelect = false;
            this.lendingsDataGridView.Name = "lendingsDataGridView";
            this.lendingsDataGridView.ReadOnly = true;
            this.lendingsDataGridView.RowHeadersVisible = false;
            this.lendingsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.lendingsDataGridView.RowTemplate.Height = 25;
            this.lendingsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lendingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lendingsDataGridView.Size = new System.Drawing.Size(717, 518);
            this.lendingsDataGridView.TabIndex = 0;
            this.lendingsDataGridView.SelectionChanged += new System.EventHandler(this.lendingsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 68.52792F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // bookName
            // 
            this.bookName.FillWeight = 85.32957F;
            this.bookName.HeaderText = "Tytuł";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // bookAuthor
            // 
            this.bookAuthor.FillWeight = 85.32957F;
            this.bookAuthor.HeaderText = "Autor";
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.FillWeight = 85.32957F;
            this.customer.HeaderText = "Klient";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // employee
            // 
            this.employee.FillWeight = 85.32957F;
            this.employee.HeaderText = "Pracownik";
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            // 
            // lendingDate
            // 
            this.lendingDate.FillWeight = 85.32957F;
            this.lendingDate.HeaderText = "Data wypożyczenia";
            this.lendingDate.Name = "lendingDate";
            this.lendingDate.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.FillWeight = 85.32957F;
            this.returnDate.HeaderText = "Termin zwrotu";
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // finalReturnDate
            // 
            this.finalReturnDate.FillWeight = 85.32957F;
            this.finalReturnDate.HeaderText = "Data oddania";
            this.finalReturnDate.Name = "finalReturnDate";
            this.finalReturnDate.ReadOnly = true;
            // 
            // lendingStatus
            // 
            this.lendingStatus.FillWeight = 82.09976F;
            this.lendingStatus.HeaderText = "Status";
            this.lendingStatus.Name = "lendingStatus";
            this.lendingStatus.ReadOnly = true;
            // 
            // lendingStatusExtended
            // 
            this.lendingStatusExtended.HeaderText = "status_extended";
            this.lendingStatusExtended.Name = "lendingStatusExtended";
            this.lendingStatusExtended.ReadOnly = true;
            this.lendingStatusExtended.Visible = false;
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
            this.currentUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            // lendingsFiltersLabel
            // 
            this.lendingsFiltersLabel.AutoSize = true;
            this.lendingsFiltersLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lendingsFiltersLabel.Location = new System.Drawing.Point(17, 15);
            this.lendingsFiltersLabel.Name = "lendingsFiltersLabel";
            this.lendingsFiltersLabel.Size = new System.Drawing.Size(50, 20);
            this.lendingsFiltersLabel.TabIndex = 1;
            this.lendingsFiltersLabel.Text = "Pokaż:";
            // 
            // lendedFilterButton
            // 
            this.lendedFilterButton.Location = new System.Drawing.Point(73, 15);
            this.lendedFilterButton.Name = "lendedFilterButton";
            this.lendedFilterButton.Size = new System.Drawing.Size(95, 25);
            this.lendedFilterButton.TabIndex = 2;
            this.lendedFilterButton.Text = "Wypożyczone";
            this.lendedFilterButton.UseVisualStyleBackColor = true;
            // 
            // overdueFilterButton
            // 
            this.overdueFilterButton.Location = new System.Drawing.Point(174, 15);
            this.overdueFilterButton.Name = "overdueFilterButton";
            this.overdueFilterButton.Size = new System.Drawing.Size(95, 25);
            this.overdueFilterButton.TabIndex = 2;
            this.overdueFilterButton.Text = "Zaległe";
            this.overdueFilterButton.UseVisualStyleBackColor = true;
            // 
            // returnedFilterButton
            // 
            this.returnedFilterButton.Location = new System.Drawing.Point(276, 15);
            this.returnedFilterButton.Name = "returnedFilterButton";
            this.returnedFilterButton.Size = new System.Drawing.Size(95, 25);
            this.returnedFilterButton.TabIndex = 2;
            this.returnedFilterButton.Text = "Zwrócone";
            this.returnedFilterButton.UseVisualStyleBackColor = true;
            // 
            // allFilterButton
            // 
            this.allFilterButton.Location = new System.Drawing.Point(377, 14);
            this.allFilterButton.Name = "allFilterButton";
            this.allFilterButton.Size = new System.Drawing.Size(95, 25);
            this.allFilterButton.TabIndex = 2;
            this.allFilterButton.Text = "Wszystkie";
            this.allFilterButton.UseVisualStyleBackColor = true;
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
            this.lendingsBottomPanel.ResumeLayout(false);
            this.lendingsBottomPanel.PerformLayout();
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
        private BindingSource userSessionBindingSource;
        private Button lendingsNavButton;
        private Panel navButtonsPanel;
        private Label currentUserLabel;
        private Button statisticsNavButton;
        private Button employeesNavButton;
        private Button customersNavButton;
        private Button booksNavButton;
        private Panel lendingsBottomPanel;
        private Button deleteLendingButton;
        private Button returnLendingButton;
        private Button newLendingButton;
        public DataGridView lendingsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bookName;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn employee;
        private DataGridViewTextBoxColumn lendingDate;
        private DataGridViewTextBoxColumn returnDate;
        private DataGridViewTextBoxColumn finalReturnDate;
        private DataGridViewTextBoxColumn lendingStatus;
        private DataGridViewTextBoxColumn lendingStatusExtended;
        private Button allFilterButton;
        private Button returnedFilterButton;
        private Button overdueFilterButton;
        private Button lendedFilterButton;
        private Label lendingsFiltersLabel;
    }
}