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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.navButtonsPanel = new System.Windows.Forms.Panel();
            this.authorsNavButton = new System.Windows.Forms.Button();
            this.publishersNavButton = new System.Windows.Forms.Button();
            this.statisticsNavButton = new System.Windows.Forms.Button();
            this.employeesNavButton = new System.Windows.Forms.Button();
            this.customersNavButton = new System.Windows.Forms.Button();
            this.booksNavButton = new System.Windows.Forms.Button();
            this.lendingsNavButton = new System.Windows.Forms.Button();
            this.navTimeLabel = new System.Windows.Forms.Label();
            this.navTopImage = new System.Windows.Forms.PictureBox();
            this.navTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentTabLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.userSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsPage = new System.Windows.Forms.TabPage();
            this.booksPage = new System.Windows.Forms.TabPage();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.booksBottonPanel = new System.Windows.Forms.Panel();
            this.changeBookQuantityButton = new System.Windows.Forms.Button();
            this.addNewBookButton = new System.Windows.Forms.Button();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendingsPage = new System.Windows.Forms.TabPage();
            this.lendingsPanel = new System.Windows.Forms.Panel();
            this.lendingsBottomPanel = new System.Windows.Forms.Panel();
            this.allFilterButton = new System.Windows.Forms.Button();
            this.returnedFilterButton = new System.Windows.Forms.Button();
            this.overdueFilterButton = new System.Windows.Forms.Button();
            this.lendedFilterButton = new System.Windows.Forms.Button();
            this.lendingsFiltersLabel = new System.Windows.Forms.Label();
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
            this.loginPage = new System.Windows.Forms.TabPage();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.customersPage = new System.Windows.Forms.TabPage();
            this.customersPanel = new System.Windows.Forms.Panel();
            this.customersBottomPanel = new System.Windows.Forms.Panel();
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.employeesPanel = new System.Windows.Forms.Panel();
            this.employeesBottomPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.clientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsPage = new System.Windows.Forms.TabPage();
            this.publishersPage = new System.Windows.Forms.TabPage();
            this.sideNavPanel.SuspendLayout();
            this.navButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSessionBindingSource)).BeginInit();
            this.booksPage.SuspendLayout();
            this.booksPanel.SuspendLayout();
            this.booksBottonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.lendingsPage.SuspendLayout();
            this.lendingsPanel.SuspendLayout();
            this.lendingsBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendingsDataGridView)).BeginInit();
            this.loginPage.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.customersPage.SuspendLayout();
            this.customersPanel.SuspendLayout();
            this.customersBottomPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.employeesPage.SuspendLayout();
            this.employeesPanel.SuspendLayout();
            this.employeesBottomPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
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
            this.navButtonsPanel.Controls.Add(this.authorsNavButton);
            this.navButtonsPanel.Controls.Add(this.publishersNavButton);
            this.navButtonsPanel.Controls.Add(this.statisticsNavButton);
            this.navButtonsPanel.Controls.Add(this.employeesNavButton);
            this.navButtonsPanel.Controls.Add(this.customersNavButton);
            this.navButtonsPanel.Controls.Add(this.booksNavButton);
            this.navButtonsPanel.Controls.Add(this.lendingsNavButton);
            this.navButtonsPanel.Location = new System.Drawing.Point(12, 96);
            this.navButtonsPanel.Name = "navButtonsPanel";
            this.navButtonsPanel.Size = new System.Drawing.Size(173, 411);
            this.navButtonsPanel.TabIndex = 3;
            this.navButtonsPanel.Visible = false;
            // 
            // authorsNavButton
            // 
            this.authorsNavButton.Location = new System.Drawing.Point(32, 354);
            this.authorsNavButton.Name = "authorsNavButton";
            this.authorsNavButton.Size = new System.Drawing.Size(107, 38);
            this.authorsNavButton.TabIndex = 3;
            this.authorsNavButton.Text = "Autorzy";
            this.authorsNavButton.UseVisualStyleBackColor = true;
            this.authorsNavButton.Click += new System.EventHandler(this.authorsNavButton_Click);
            // 
            // publishersNavButton
            // 
            this.publishersNavButton.Location = new System.Drawing.Point(32, 299);
            this.publishersNavButton.Name = "publishersNavButton";
            this.publishersNavButton.Size = new System.Drawing.Size(107, 38);
            this.publishersNavButton.TabIndex = 3;
            this.publishersNavButton.Text = "Wydawcy";
            this.publishersNavButton.UseVisualStyleBackColor = true;
            this.publishersNavButton.Click += new System.EventHandler(this.publishersNavButton_Click);
            // 
            // statisticsNavButton
            // 
            this.statisticsNavButton.Location = new System.Drawing.Point(32, 245);
            this.statisticsNavButton.Name = "statisticsNavButton";
            this.statisticsNavButton.Size = new System.Drawing.Size(107, 38);
            this.statisticsNavButton.TabIndex = 3;
            this.statisticsNavButton.Text = "Statystyki";
            this.statisticsNavButton.UseVisualStyleBackColor = true;
            this.statisticsNavButton.Click += new System.EventHandler(this.statisticsNavButton_Click);
            // 
            // employeesNavButton
            // 
            this.employeesNavButton.Location = new System.Drawing.Point(32, 192);
            this.employeesNavButton.Name = "employeesNavButton";
            this.employeesNavButton.Size = new System.Drawing.Size(107, 38);
            this.employeesNavButton.TabIndex = 3;
            this.employeesNavButton.Text = "Pracownicy";
            this.employeesNavButton.UseVisualStyleBackColor = true;
            this.employeesNavButton.Click += new System.EventHandler(this.employeesNavButton_Click);
            // 
            // customersNavButton
            // 
            this.customersNavButton.Location = new System.Drawing.Point(32, 139);
            this.customersNavButton.Name = "customersNavButton";
            this.customersNavButton.Size = new System.Drawing.Size(107, 38);
            this.customersNavButton.TabIndex = 3;
            this.customersNavButton.Text = "Klienci";
            this.customersNavButton.UseVisualStyleBackColor = true;
            this.customersNavButton.Click += new System.EventHandler(this.customersNavButton_Click);
            // 
            // booksNavButton
            // 
            this.booksNavButton.Location = new System.Drawing.Point(32, 86);
            this.booksNavButton.Name = "booksNavButton";
            this.booksNavButton.Size = new System.Drawing.Size(107, 38);
            this.booksNavButton.TabIndex = 3;
            this.booksNavButton.Text = "Książki";
            this.booksNavButton.UseVisualStyleBackColor = true;
            this.booksNavButton.Click += new System.EventHandler(this.booksNavButton_Click);
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
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.topPanel.Controls.Add(this.currentTabLabel);
            this.topPanel.Controls.Add(this.currentUserLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(211, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(717, 56);
            this.topPanel.TabIndex = 2;
            // 
            // currentTabLabel
            // 
            this.currentTabLabel.AutoSize = true;
            this.currentTabLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTabLabel.Location = new System.Drawing.Point(6, 12);
            this.currentTabLabel.Name = "currentTabLabel";
            this.currentTabLabel.Size = new System.Drawing.Size(129, 32);
            this.currentTabLabel.TabIndex = 1;
            this.currentTabLabel.Text = "Logowanie";
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
            // authorsPage
            // 
            this.authorsPage.Location = new System.Drawing.Point(4, 27);
            this.authorsPage.Name = "authorsPage";
            this.authorsPage.Size = new System.Drawing.Size(709, 487);
            this.authorsPage.TabIndex = 3;
            this.authorsPage.Text = "authorsPage";
            this.authorsPage.UseVisualStyleBackColor = true;
            // 
            // booksPage
            // 
            this.booksPage.Controls.Add(this.booksPanel);
            this.booksPage.Location = new System.Drawing.Point(4, 27);
            this.booksPage.Margin = new System.Windows.Forms.Padding(0);
            this.booksPage.Name = "booksPage";
            this.booksPage.Size = new System.Drawing.Size(709, 487);
            this.booksPage.TabIndex = 2;
            this.booksPage.Text = "booksPage";
            this.booksPage.UseVisualStyleBackColor = true;
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.SystemColors.Control;
            this.booksPanel.Controls.Add(this.booksBottonPanel);
            this.booksPanel.Controls.Add(this.booksDataGridView);
            this.booksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksPanel.Location = new System.Drawing.Point(0, 0);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(709, 487);
            this.booksPanel.TabIndex = 5;
            // 
            // booksBottonPanel
            // 
            this.booksBottonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.booksBottonPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.booksBottonPanel.Controls.Add(this.changeBookQuantityButton);
            this.booksBottonPanel.Controls.Add(this.addNewBookButton);
            this.booksBottonPanel.Location = new System.Drawing.Point(0, 407);
            this.booksBottonPanel.Name = "booksBottonPanel";
            this.booksBottonPanel.Size = new System.Drawing.Size(709, 80);
            this.booksBottonPanel.TabIndex = 1;
            // 
            // changeBookQuantityButton
            // 
            this.changeBookQuantityButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeBookQuantityButton.Location = new System.Drawing.Point(137, 16);
            this.changeBookQuantityButton.Name = "changeBookQuantityButton";
            this.changeBookQuantityButton.Size = new System.Drawing.Size(103, 40);
            this.changeBookQuantityButton.TabIndex = 0;
            this.changeBookQuantityButton.Text = "Zmień ilość";
            this.changeBookQuantityButton.UseVisualStyleBackColor = true;
            this.changeBookQuantityButton.Click += new System.EventHandler(this.changeBookQuantityButton_Click);
            // 
            // addNewBookButton
            // 
            this.addNewBookButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNewBookButton.Location = new System.Drawing.Point(14, 16);
            this.addNewBookButton.Name = "addNewBookButton";
            this.addNewBookButton.Size = new System.Drawing.Size(103, 40);
            this.addNewBookButton.TabIndex = 0;
            this.addNewBookButton.Text = "Dodaj";
            this.addNewBookButton.UseVisualStyleBackColor = true;
            this.addNewBookButton.Click += new System.EventHandler(this.addNewBookButton_Click);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.AllowUserToResizeRows = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.author,
            this.publisher,
            this.year,
            this.category,
            this.description,
            this.inStock,
            this.avaliableQuantity,
            this.totalQuantity});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.booksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.booksDataGridView.MultiSelect = false;
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.RowHeadersVisible = false;
            this.booksDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.booksDataGridView.RowTemplate.Height = 25;
            this.booksDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(709, 487);
            this.booksDataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.FillWeight = 68.52792F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // title
            // 
            this.title.FillWeight = 85.32957F;
            this.title.HeaderText = "Tytuł";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            this.author.FillWeight = 85.32957F;
            this.author.HeaderText = "Autor";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.FillWeight = 85.32957F;
            this.publisher.HeaderText = "Wydawca";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // year
            // 
            this.year.FillWeight = 85.32957F;
            this.year.HeaderText = "Rok";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // category
            // 
            this.category.FillWeight = 85.32957F;
            this.category.HeaderText = "Gatunek";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // description
            // 
            this.description.FillWeight = 85.32957F;
            this.description.HeaderText = "Opis";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.FillWeight = 82.09976F;
            this.inStock.HeaderText = "Na stanie";
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            // 
            // avaliableQuantity
            // 
            this.avaliableQuantity.HeaderText = "availableQuantity";
            this.avaliableQuantity.Name = "avaliableQuantity";
            this.avaliableQuantity.ReadOnly = true;
            this.avaliableQuantity.Visible = false;
            // 
            // totalQuantity
            // 
            this.totalQuantity.HeaderText = "totalQuantity";
            this.totalQuantity.Name = "totalQuantity";
            this.totalQuantity.ReadOnly = true;
            this.totalQuantity.Visible = false;
            // 
            // lendingsPage
            // 
            this.lendingsPage.Controls.Add(this.lendingsPanel);
            this.lendingsPage.Location = new System.Drawing.Point(4, 27);
            this.lendingsPage.Margin = new System.Windows.Forms.Padding(0);
            this.lendingsPage.Name = "lendingsPage";
            this.lendingsPage.Size = new System.Drawing.Size(709, 487);
            this.lendingsPage.TabIndex = 1;
            this.lendingsPage.Text = "lendingsPage";
            this.lendingsPage.UseVisualStyleBackColor = true;
            // 
            // lendingsPanel
            // 
            this.lendingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.lendingsPanel.Controls.Add(this.lendingsBottomPanel);
            this.lendingsPanel.Controls.Add(this.lendingsDataGridView);
            this.lendingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendingsPanel.Location = new System.Drawing.Point(0, 0);
            this.lendingsPanel.Name = "lendingsPanel";
            this.lendingsPanel.Size = new System.Drawing.Size(709, 487);
            this.lendingsPanel.TabIndex = 4;
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
            this.lendingsBottomPanel.Location = new System.Drawing.Point(0, 379);
            this.lendingsBottomPanel.Name = "lendingsBottomPanel";
            this.lendingsBottomPanel.Size = new System.Drawing.Size(709, 108);
            this.lendingsBottomPanel.TabIndex = 1;
            // 
            // allFilterButton
            // 
            this.allFilterButton.Location = new System.Drawing.Point(377, 14);
            this.allFilterButton.Name = "allFilterButton";
            this.allFilterButton.Size = new System.Drawing.Size(95, 25);
            this.allFilterButton.TabIndex = 2;
            this.allFilterButton.Text = "Wszystkie";
            this.allFilterButton.UseVisualStyleBackColor = true;
            this.allFilterButton.Click += new System.EventHandler(this.allFilterButton_Click);
            // 
            // returnedFilterButton
            // 
            this.returnedFilterButton.Location = new System.Drawing.Point(276, 15);
            this.returnedFilterButton.Name = "returnedFilterButton";
            this.returnedFilterButton.Size = new System.Drawing.Size(95, 25);
            this.returnedFilterButton.TabIndex = 2;
            this.returnedFilterButton.Text = "Zwrócone";
            this.returnedFilterButton.UseVisualStyleBackColor = true;
            this.returnedFilterButton.Click += new System.EventHandler(this.returnedFilterButton_Click);
            // 
            // overdueFilterButton
            // 
            this.overdueFilterButton.Location = new System.Drawing.Point(174, 15);
            this.overdueFilterButton.Name = "overdueFilterButton";
            this.overdueFilterButton.Size = new System.Drawing.Size(95, 25);
            this.overdueFilterButton.TabIndex = 2;
            this.overdueFilterButton.Text = "Zaległe";
            this.overdueFilterButton.UseVisualStyleBackColor = true;
            this.overdueFilterButton.Click += new System.EventHandler(this.overdueFilterButton_Click);
            // 
            // lendedFilterButton
            // 
            this.lendedFilterButton.Location = new System.Drawing.Point(73, 15);
            this.lendedFilterButton.Name = "lendedFilterButton";
            this.lendedFilterButton.Size = new System.Drawing.Size(95, 25);
            this.lendedFilterButton.TabIndex = 2;
            this.lendedFilterButton.Text = "Wypożyczone";
            this.lendedFilterButton.UseVisualStyleBackColor = true;
            this.lendedFilterButton.Click += new System.EventHandler(this.lendedFilterButton_Click);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lendingsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lendingsDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.lendingsDataGridView.Size = new System.Drawing.Size(709, 487);
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
            // loginPage
            // 
            this.loginPage.Controls.Add(this.loginPanel);
            this.loginPage.Location = new System.Drawing.Point(4, 27);
            this.loginPage.Margin = new System.Windows.Forms.Padding(0);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(709, 487);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "loginPage";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginPanel.Controls.Add(this.loginErrorLabel);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(709, 487);
            this.loginPanel.TabIndex = 1;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(167, 207);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(282, 40);
            this.loginErrorLabel.TabIndex = 3;
            this.loginErrorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(167, 285);
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
            this.loginTextBox.Location = new System.Drawing.Point(167, 250);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(282, 29);
            this.loginTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Location = new System.Drawing.Point(223, 329);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(168, 49);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj się";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.loginPage);
            this.mainTabControl.Controls.Add(this.lendingsPage);
            this.mainTabControl.Controls.Add(this.booksPage);
            this.mainTabControl.Controls.Add(this.customersPage);
            this.mainTabControl.Controls.Add(this.employeesPage);
            this.mainTabControl.Controls.Add(this.statisticsPage);
            this.mainTabControl.Controls.Add(this.publishersPage);
            this.mainTabControl.Controls.Add(this.authorsPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(211, 56);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(717, 518);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // customersPage
            // 
            this.customersPage.Controls.Add(this.customersPanel);
            this.customersPage.Location = new System.Drawing.Point(4, 27);
            this.customersPage.Name = "customersPage";
            this.customersPage.Size = new System.Drawing.Size(709, 487);
            this.customersPage.TabIndex = 4;
            this.customersPage.Text = "customersPage";
            this.customersPage.UseVisualStyleBackColor = true;
            // 
            // customersPanel
            // 
            this.customersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.customersPanel.Controls.Add(this.customersBottomPanel);
            this.customersPanel.Controls.Add(this.panel3);
            this.customersPanel.Controls.Add(this.customersDataGridView);
            this.customersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersPanel.Location = new System.Drawing.Point(0, 0);
            this.customersPanel.Name = "customersPanel";
            this.customersPanel.Size = new System.Drawing.Size(709, 487);
            this.customersPanel.TabIndex = 6;
            // 
            // customersBottomPanel
            // 
            this.customersBottomPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.customersBottomPanel.Controls.Add(this.modifyCustomerButton);
            this.customersBottomPanel.Controls.Add(this.addCustomerButton);
            this.customersBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customersBottomPanel.Location = new System.Drawing.Point(0, 407);
            this.customersBottomPanel.Name = "customersBottomPanel";
            this.customersBottomPanel.Size = new System.Drawing.Size(709, 80);
            this.customersBottomPanel.TabIndex = 2;
            // 
            // modifyCustomerButton
            // 
            this.modifyCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modifyCustomerButton.Location = new System.Drawing.Point(137, 17);
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.Size = new System.Drawing.Size(103, 40);
            this.modifyCustomerButton.TabIndex = 0;
            this.modifyCustomerButton.Text = "Zmień ilość";
            this.modifyCustomerButton.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCustomerButton.Location = new System.Drawing.Point(14, 17);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(103, 40);
            this.addCustomerButton.TabIndex = 0;
            this.addCustomerButton.Text = "Dodaj";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 794);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 80);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(137, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zmień ilość";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(14, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AllowUserToResizeRows = false;
            this.customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName,
            this.customerPhoneNumber,
            this.customerAddress,
            this.customerEmailAddress});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customersDataGridView.MultiSelect = false;
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersVisible = false;
            this.customersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.customersDataGridView.RowTemplate.Height = 25;
            this.customersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataGridView.Size = new System.Drawing.Size(709, 487);
            this.customersDataGridView.TabIndex = 0;
            // 
            // customerID
            // 
            this.customerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerID.FillWeight = 68.52792F;
            this.customerID.HeaderText = "ID";
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Width = 40;
            // 
            // customerName
            // 
            this.customerName.FillWeight = 85.32957F;
            this.customerName.HeaderText = "Imię i nazwisko";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.FillWeight = 85.32957F;
            this.customerPhoneNumber.HeaderText = "Nr telefonu";
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.ReadOnly = true;
            // 
            // customerAddress
            // 
            this.customerAddress.FillWeight = 85.32957F;
            this.customerAddress.HeaderText = "Adres zamieszkania";
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.ReadOnly = true;
            // 
            // customerEmailAddress
            // 
            this.customerEmailAddress.FillWeight = 85.32957F;
            this.customerEmailAddress.HeaderText = "Adres e-mail";
            this.customerEmailAddress.Name = "customerEmailAddress";
            this.customerEmailAddress.ReadOnly = true;
            // 
            // employeesPage
            // 
            this.employeesPage.Controls.Add(this.employeesPanel);
            this.employeesPage.Location = new System.Drawing.Point(4, 27);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Size = new System.Drawing.Size(709, 487);
            this.employeesPage.TabIndex = 7;
            this.employeesPage.Text = "employeesPage";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // employeesPanel
            // 
            this.employeesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.employeesPanel.Controls.Add(this.employeesBottomPanel);
            this.employeesPanel.Controls.Add(this.panel4);
            this.employeesPanel.Controls.Add(this.employeesDataGridView);
            this.employeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesPanel.Location = new System.Drawing.Point(0, 0);
            this.employeesPanel.Name = "employeesPanel";
            this.employeesPanel.Size = new System.Drawing.Size(709, 487);
            this.employeesPanel.TabIndex = 7;
            // 
            // employeesBottomPanel
            // 
            this.employeesBottomPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.employeesBottomPanel.Controls.Add(this.button3);
            this.employeesBottomPanel.Controls.Add(this.button4);
            this.employeesBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeesBottomPanel.Location = new System.Drawing.Point(0, 407);
            this.employeesBottomPanel.Name = "employeesBottomPanel";
            this.employeesBottomPanel.Size = new System.Drawing.Size(709, 80);
            this.employeesBottomPanel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(137, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Zmień ilość";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(14, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Location = new System.Drawing.Point(0, 1181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 80);
            this.panel4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(137, -4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Zmień ilość";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.Location = new System.Drawing.Point(14, -4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Dodaj";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.AllowUserToResizeRows = false;
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientID,
            this.clientName,
            this.clientPhoneNumber,
            this.clientAddress,
            this.clientEmailAddress});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesDataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.employeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersVisible = false;
            this.employeesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeesDataGridView.RowTemplate.Height = 25;
            this.employeesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(709, 487);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // clientID
            // 
            this.clientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientID.FillWeight = 68.52792F;
            this.clientID.HeaderText = "ID";
            this.clientID.Name = "clientID";
            this.clientID.ReadOnly = true;
            this.clientID.Width = 40;
            // 
            // clientName
            // 
            this.clientName.FillWeight = 85.32957F;
            this.clientName.HeaderText = "Imię i nazwisko";
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            // 
            // clientPhoneNumber
            // 
            this.clientPhoneNumber.FillWeight = 85.32957F;
            this.clientPhoneNumber.HeaderText = "Nr telefonu";
            this.clientPhoneNumber.Name = "clientPhoneNumber";
            this.clientPhoneNumber.ReadOnly = true;
            // 
            // clientAddress
            // 
            this.clientAddress.FillWeight = 85.32957F;
            this.clientAddress.HeaderText = "Adres zamieszkania";
            this.clientAddress.Name = "clientAddress";
            this.clientAddress.ReadOnly = true;
            // 
            // clientEmailAddress
            // 
            this.clientEmailAddress.FillWeight = 85.32957F;
            this.clientEmailAddress.HeaderText = "Adres e-mail";
            this.clientEmailAddress.Name = "clientEmailAddress";
            this.clientEmailAddress.ReadOnly = true;
            // 
            // statisticsPage
            // 
            this.statisticsPage.Location = new System.Drawing.Point(4, 27);
            this.statisticsPage.Name = "statisticsPage";
            this.statisticsPage.Size = new System.Drawing.Size(709, 487);
            this.statisticsPage.TabIndex = 5;
            this.statisticsPage.Text = "statisticsPage";
            this.statisticsPage.UseVisualStyleBackColor = true;
            // 
            // publishersPage
            // 
            this.publishersPage.Location = new System.Drawing.Point(4, 27);
            this.publishersPage.Name = "publishersPage";
            this.publishersPage.Size = new System.Drawing.Size(709, 487);
            this.publishersPage.TabIndex = 6;
            this.publishersPage.Text = "publishersPage";
            this.publishersPage.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.mainTabControl);
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
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSessionBindingSource)).EndInit();
            this.booksPage.ResumeLayout(false);
            this.booksPanel.ResumeLayout(false);
            this.booksBottonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.lendingsPage.ResumeLayout(false);
            this.lendingsPanel.ResumeLayout(false);
            this.lendingsBottomPanel.ResumeLayout(false);
            this.lendingsBottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendingsDataGridView)).EndInit();
            this.loginPage.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.customersPage.ResumeLayout(false);
            this.customersPanel.ResumeLayout(false);
            this.customersBottomPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.employeesPage.ResumeLayout(false);
            this.employeesPanel.ResumeLayout(false);
            this.employeesBottomPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sideNavPanel;
        private PictureBox navTopImage;
        private Label navTimeLabel;
        private System.Windows.Forms.Timer navTimeTimer;
        private Panel topPanel;
        private BindingSource userSessionBindingSource;
        private Button lendingsNavButton;
        private Panel navButtonsPanel;
        private Label currentUserLabel;
        private Button statisticsNavButton;
        private Button employeesNavButton;
        private Button customersNavButton;
        private Button booksNavButton;
        private Button authorsNavButton;
        private Button publishersNavButton;
        private Label currentTabLabel;
        private TabPage authorsPage;
        private TabPage booksPage;
        private Panel booksPanel;
        private Panel booksBottonPanel;
        private Button changeBookQuantityButton;
        private Button addNewBookButton;
        public DataGridView booksDataGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn publisher;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn inStock;
        private DataGridViewTextBoxColumn avaliableQuantity;
        private DataGridViewTextBoxColumn totalQuantity;
        private TabPage lendingsPage;
        private Panel lendingsPanel;
        private Panel lendingsBottomPanel;
        private Button allFilterButton;
        private Button returnedFilterButton;
        private Button overdueFilterButton;
        private Button lendedFilterButton;
        private Label lendingsFiltersLabel;
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
        private TabPage loginPage;
        private Panel loginPanel;
        private Label loginErrorLabel;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button loginButton;
        private TabControl mainTabControl;
        private TabPage customersPage;
        private TabPage statisticsPage;
        private TabPage publishersPage;
        private TabPage employeesPage;
        private Panel customersPanel;
        private Panel customersBottomPanel;
        private Button modifyCustomerButton;
        private Button addCustomerButton;
        private Panel panel3;
        private Button button1;
        private Button button2;
        public DataGridView customersDataGridView;
        private DataGridViewTextBoxColumn customerID;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn customerPhoneNumber;
        private DataGridViewTextBoxColumn customerAddress;
        private DataGridViewTextBoxColumn customerEmailAddress;
        private Panel employeesPanel;
        private Panel employeesBottomPanel;
        private Button button3;
        private Button button4;
        private Panel panel4;
        private Button button5;
        private Button button6;
        public DataGridView employeesDataGridView;
        private DataGridViewTextBoxColumn clientID;
        private DataGridViewTextBoxColumn clientName;
        private DataGridViewTextBoxColumn clientPhoneNumber;
        private DataGridViewTextBoxColumn clientAddress;
        private DataGridViewTextBoxColumn clientEmailAddress;
    }
}