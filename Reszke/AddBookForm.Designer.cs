namespace Reszke
{
    partial class AddBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.newBookLabel = new System.Windows.Forms.Label();
            this.chosenAuthorLabel = new System.Windows.Forms.Label();
            this.authorSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.authorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseAuthorLabel = new System.Windows.Forms.Label();
            this.chooseTitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.chooseDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.chosenPublisherLabel = new System.Windows.Forms.Label();
            this.choosePublisherLabel = new System.Windows.Forms.Label();
            this.publisherSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.publisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosenCategoryLabel = new System.Windows.Forms.Label();
            this.chooseCategoryLabel = new System.Windows.Forms.Label();
            this.categorySelectDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelBookAddButton = new System.Windows.Forms.Button();
            this.confirmBookAddButton = new System.Windows.Forms.Button();
            this.chooseYearLabel = new System.Windows.Forms.Label();
            this.chooseYearUpDown = new System.Windows.Forms.NumericUpDown();
            this.bookAddErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorSelectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherSelectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySelectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // newBookLabel
            // 
            this.newBookLabel.AutoSize = true;
            this.newBookLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newBookLabel.Location = new System.Drawing.Point(31, 30);
            this.newBookLabel.Name = "newBookLabel";
            this.newBookLabel.Size = new System.Drawing.Size(244, 30);
            this.newBookLabel.TabIndex = 11;
            this.newBookLabel.Text = "Dodawanie nowej książki";
            // 
            // chosenAuthorLabel
            // 
            this.chosenAuthorLabel.AutoSize = true;
            this.chosenAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenAuthorLabel.Location = new System.Drawing.Point(272, 349);
            this.chosenAuthorLabel.MaximumSize = new System.Drawing.Size(160, 80);
            this.chosenAuthorLabel.Name = "chosenAuthorLabel";
            this.chosenAuthorLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenAuthorLabel.TabIndex = 10;
            this.chosenAuthorLabel.Text = "Wybrano: ";
            // 
            // authorSelectDataGridView
            // 
            this.authorSelectDataGridView.AllowUserToAddRows = false;
            this.authorSelectDataGridView.AllowUserToDeleteRows = false;
            this.authorSelectDataGridView.AllowUserToResizeColumns = false;
            this.authorSelectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorSelectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.authorSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorID,
            this.name});
            this.authorSelectDataGridView.Location = new System.Drawing.Point(272, 108);
            this.authorSelectDataGridView.MultiSelect = false;
            this.authorSelectDataGridView.Name = "authorSelectDataGridView";
            this.authorSelectDataGridView.ReadOnly = true;
            this.authorSelectDataGridView.RowHeadersVisible = false;
            this.authorSelectDataGridView.RowHeadersWidth = 20;
            this.authorSelectDataGridView.RowTemplate.Height = 25;
            this.authorSelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorSelectDataGridView.Size = new System.Drawing.Size(182, 238);
            this.authorSelectDataGridView.TabIndex = 3;
            this.authorSelectDataGridView.TabStop = false;
            this.authorSelectDataGridView.SelectionChanged += new System.EventHandler(this.authorSelectDataGridView_SelectionChanged);
            // 
            // authorID
            // 
            this.authorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.authorID.HeaderText = "ID";
            this.authorID.Name = "authorID";
            this.authorID.ReadOnly = true;
            this.authorID.Width = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Imię i nazwisko";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // chooseAuthorLabel
            // 
            this.chooseAuthorLabel.AutoSize = true;
            this.chooseAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseAuthorLabel.Location = new System.Drawing.Point(272, 84);
            this.chooseAuthorLabel.Name = "chooseAuthorLabel";
            this.chooseAuthorLabel.Size = new System.Drawing.Size(119, 21);
            this.chooseAuthorLabel.TabIndex = 9;
            this.chooseAuthorLabel.Text = "Wybierz autora:";
            // 
            // chooseTitleLabel
            // 
            this.chooseTitleLabel.AutoSize = true;
            this.chooseTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseTitleLabel.Location = new System.Drawing.Point(45, 84);
            this.chooseTitleLabel.Name = "chooseTitleLabel";
            this.chooseTitleLabel.Size = new System.Drawing.Size(46, 21);
            this.chooseTitleLabel.TabIndex = 12;
            this.chooseTitleLabel.Text = "Tytuł:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(31, 108);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 23);
            this.titleTextBox.TabIndex = 0;
            // 
            // chooseDescriptionLabel
            // 
            this.chooseDescriptionLabel.AutoSize = true;
            this.chooseDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseDescriptionLabel.Location = new System.Drawing.Point(45, 147);
            this.chooseDescriptionLabel.Name = "chooseDescriptionLabel";
            this.chooseDescriptionLabel.Size = new System.Drawing.Size(49, 21);
            this.chooseDescriptionLabel.TabIndex = 12;
            this.chooseDescriptionLabel.Text = "Opis: ";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(31, 171);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(220, 23);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // chosenPublisherLabel
            // 
            this.chosenPublisherLabel.AutoSize = true;
            this.chosenPublisherLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenPublisherLabel.Location = new System.Drawing.Point(474, 349);
            this.chosenPublisherLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.chosenPublisherLabel.Name = "chosenPublisherLabel";
            this.chosenPublisherLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenPublisherLabel.TabIndex = 16;
            this.chosenPublisherLabel.Text = "Wybrano: ";
            // 
            // choosePublisherLabel
            // 
            this.choosePublisherLabel.AutoSize = true;
            this.choosePublisherLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choosePublisherLabel.Location = new System.Drawing.Point(474, 84);
            this.choosePublisherLabel.Name = "choosePublisherLabel";
            this.choosePublisherLabel.Size = new System.Drawing.Size(138, 21);
            this.choosePublisherLabel.TabIndex = 15;
            this.choosePublisherLabel.Text = "Wybierz wydawcę:";
            // 
            // publisherSelectDataGridView
            // 
            this.publisherSelectDataGridView.AllowUserToAddRows = false;
            this.publisherSelectDataGridView.AllowUserToDeleteRows = false;
            this.publisherSelectDataGridView.AllowUserToResizeColumns = false;
            this.publisherSelectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisherSelectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.publisherSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherID,
            this.publisherName});
            this.publisherSelectDataGridView.Location = new System.Drawing.Point(474, 108);
            this.publisherSelectDataGridView.MultiSelect = false;
            this.publisherSelectDataGridView.Name = "publisherSelectDataGridView";
            this.publisherSelectDataGridView.ReadOnly = true;
            this.publisherSelectDataGridView.RowHeadersVisible = false;
            this.publisherSelectDataGridView.RowHeadersWidth = 20;
            this.publisherSelectDataGridView.RowTemplate.Height = 25;
            this.publisherSelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.publisherSelectDataGridView.Size = new System.Drawing.Size(182, 238);
            this.publisherSelectDataGridView.TabIndex = 4;
            this.publisherSelectDataGridView.TabStop = false;
            this.publisherSelectDataGridView.SelectionChanged += new System.EventHandler(this.publisherSelectDataGridView_SelectionChanged);
            // 
            // publisherID
            // 
            this.publisherID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.publisherID.HeaderText = "ID";
            this.publisherID.Name = "publisherID";
            this.publisherID.ReadOnly = true;
            this.publisherID.Width = 25;
            // 
            // publisherName
            // 
            this.publisherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.publisherName.HeaderText = "Nazwa";
            this.publisherName.Name = "publisherName";
            this.publisherName.ReadOnly = true;
            // 
            // chosenCategoryLabel
            // 
            this.chosenCategoryLabel.AutoSize = true;
            this.chosenCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenCategoryLabel.Location = new System.Drawing.Point(677, 349);
            this.chosenCategoryLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.chosenCategoryLabel.Name = "chosenCategoryLabel";
            this.chosenCategoryLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenCategoryLabel.TabIndex = 19;
            this.chosenCategoryLabel.Text = "Wybrano: ";
            // 
            // chooseCategoryLabel
            // 
            this.chooseCategoryLabel.AutoSize = true;
            this.chooseCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCategoryLabel.Location = new System.Drawing.Point(677, 84);
            this.chooseCategoryLabel.Name = "chooseCategoryLabel";
            this.chooseCategoryLabel.Size = new System.Drawing.Size(139, 21);
            this.chooseCategoryLabel.TabIndex = 18;
            this.chooseCategoryLabel.Text = "Wybierz kategorię:";
            // 
            // categorySelectDataGridView
            // 
            this.categorySelectDataGridView.AllowUserToAddRows = false;
            this.categorySelectDataGridView.AllowUserToDeleteRows = false;
            this.categorySelectDataGridView.AllowUserToResizeColumns = false;
            this.categorySelectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categorySelectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categorySelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorySelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryID,
            this.categoryName});
            this.categorySelectDataGridView.Location = new System.Drawing.Point(677, 108);
            this.categorySelectDataGridView.MultiSelect = false;
            this.categorySelectDataGridView.Name = "categorySelectDataGridView";
            this.categorySelectDataGridView.ReadOnly = true;
            this.categorySelectDataGridView.RowHeadersVisible = false;
            this.categorySelectDataGridView.RowHeadersWidth = 20;
            this.categorySelectDataGridView.RowTemplate.Height = 25;
            this.categorySelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorySelectDataGridView.Size = new System.Drawing.Size(182, 238);
            this.categorySelectDataGridView.TabIndex = 5;
            this.categorySelectDataGridView.TabStop = false;
            this.categorySelectDataGridView.SelectionChanged += new System.EventHandler(this.categorySelectDataGridView_SelectionChanged);
            // 
            // categoryID
            // 
            this.categoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categoryID.HeaderText = "ID";
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
            this.categoryID.Width = 25;
            // 
            // categoryName
            // 
            this.categoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryName.HeaderText = "Nazwa";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // cancelBookAddButton
            // 
            this.cancelBookAddButton.Location = new System.Drawing.Point(140, 300);
            this.cancelBookAddButton.Name = "cancelBookAddButton";
            this.cancelBookAddButton.Size = new System.Drawing.Size(93, 46);
            this.cancelBookAddButton.TabIndex = 4;
            this.cancelBookAddButton.Text = "Anuluj";
            this.cancelBookAddButton.UseVisualStyleBackColor = true;
            this.cancelBookAddButton.Click += new System.EventHandler(this.cancelBookAddButton_Click);
            // 
            // confirmBookAddButton
            // 
            this.confirmBookAddButton.Location = new System.Drawing.Point(31, 300);
            this.confirmBookAddButton.Name = "confirmBookAddButton";
            this.confirmBookAddButton.Size = new System.Drawing.Size(93, 46);
            this.confirmBookAddButton.TabIndex = 3;
            this.confirmBookAddButton.Text = "Dodaj";
            this.confirmBookAddButton.UseVisualStyleBackColor = true;
            this.confirmBookAddButton.Click += new System.EventHandler(this.confirmBookAddButton_Click);
            // 
            // chooseYearLabel
            // 
            this.chooseYearLabel.AutoSize = true;
            this.chooseYearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseYearLabel.Location = new System.Drawing.Point(45, 210);
            this.chooseYearLabel.Name = "chooseYearLabel";
            this.chooseYearLabel.Size = new System.Drawing.Size(102, 21);
            this.chooseYearLabel.TabIndex = 12;
            this.chooseYearLabel.Text = "Rok wydania:";
            // 
            // chooseYearUpDown
            // 
            this.chooseYearUpDown.Location = new System.Drawing.Point(31, 234);
            this.chooseYearUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.chooseYearUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chooseYearUpDown.Name = "chooseYearUpDown";
            this.chooseYearUpDown.Size = new System.Drawing.Size(120, 23);
            this.chooseYearUpDown.TabIndex = 2;
            this.chooseYearUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseYearUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bookAddErrorLabel
            // 
            this.bookAddErrorLabel.AutoSize = true;
            this.bookAddErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.bookAddErrorLabel.Location = new System.Drawing.Point(31, 270);
            this.bookAddErrorLabel.Name = "bookAddErrorLabel";
            this.bookAddErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.bookAddErrorLabel.TabIndex = 23;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 412);
            this.Controls.Add(this.bookAddErrorLabel);
            this.Controls.Add(this.chooseYearUpDown);
            this.Controls.Add(this.cancelBookAddButton);
            this.Controls.Add(this.confirmBookAddButton);
            this.Controls.Add(this.chosenCategoryLabel);
            this.Controls.Add(this.chooseCategoryLabel);
            this.Controls.Add(this.categorySelectDataGridView);
            this.Controls.Add(this.chosenPublisherLabel);
            this.Controls.Add(this.choosePublisherLabel);
            this.Controls.Add(this.publisherSelectDataGridView);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.chooseYearLabel);
            this.Controls.Add(this.chooseDescriptionLabel);
            this.Controls.Add(this.chooseTitleLabel);
            this.Controls.Add(this.newBookLabel);
            this.Controls.Add(this.chosenAuthorLabel);
            this.Controls.Add(this.chooseAuthorLabel);
            this.Controls.Add(this.authorSelectDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "Dodawanie nowej książki";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorSelectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherSelectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySelectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label newBookLabel;
        private Label chosenAuthorLabel;
        private DataGridView authorSelectDataGridView;
        private Label chooseAuthorLabel;
        private Label chooseTitleLabel;
        private TextBox titleTextBox;
        private Label chooseDescriptionLabel;
        private TextBox descriptionTextBox;
        private Label chosenPublisherLabel;
        private Label choosePublisherLabel;
        private DataGridView publisherSelectDataGridView;
        private Label chosenCategoryLabel;
        private Label chooseCategoryLabel;
        private DataGridView categorySelectDataGridView;
        private Button cancelBookAddButton;
        private Button confirmBookAddButton;
        private DataGridViewTextBoxColumn authorID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn publisherID;
        private DataGridViewTextBoxColumn publisherName;
        private DataGridViewTextBoxColumn categoryID;
        private DataGridViewTextBoxColumn categoryName;
        private Label chooseYearLabel;
        private NumericUpDown chooseYearUpDown;
        private Label bookAddErrorLabel;
    }
}