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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.statisticsPage = new System.Windows.Forms.TabPage();
            this.publishersPage = new System.Windows.Forms.TabPage();
            this.sideNavPanel.SuspendLayout();
            this.navButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navTopImage)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSessionBindingSource)).BeginInit();
            this.booksPage.SuspendLayout();
            this.booksPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.lendingsPage.SuspendLayout();
            this.lendingsPanel.SuspendLayout();
            this.lendingsBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendingsDataGridView)).BeginInit();
            this.loginPage.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
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
            this.booksPanel.Controls.Add(this.panel2);
            this.booksPanel.Controls.Add(this.booksDataGridView);
            this.booksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksPanel.Location = new System.Drawing.Point(0, 0);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(709, 487);
            this.booksPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.changeBookQuantityButton);
            this.panel2.Controls.Add(this.addNewBookButton);
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 80);
            this.panel2.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lendingsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lendingsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.customersPage.Location = new System.Drawing.Point(4, 27);
            this.customersPage.Name = "customersPage";
            this.customersPage.Size = new System.Drawing.Size(709, 487);
            this.customersPage.TabIndex = 4;
            this.customersPage.Text = "customersPage";
            this.customersPage.UseVisualStyleBackColor = true;
            // 
            // employeesPage
            // 
            this.employeesPage.Location = new System.Drawing.Point(4, 27);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Size = new System.Drawing.Size(709, 487);
            this.employeesPage.TabIndex = 7;
            this.employeesPage.Text = "employeesPage";
            this.employeesPage.UseVisualStyleBackColor = true;
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
            this.panel2.ResumeLayout(false);
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
        private Panel panel2;
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
    }
}