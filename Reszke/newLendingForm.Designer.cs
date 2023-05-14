namespace Reszke
{
    partial class newLendingForm
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
            this.bookSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseBookLabel = new System.Windows.Forms.Label();
            this.chooseCustomerLabel = new System.Windows.Forms.Label();
            this.customerSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseReturnDateLabel = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.caluclateReturnDateCheckbox = new System.Windows.Forms.CheckBox();
            this.calculateReturnDateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chosenBookLabel = new System.Windows.Forms.Label();
            this.chosenCustomerLabel = new System.Windows.Forms.Label();
            this.chosenReturnDateLabel = new System.Windows.Forms.Label();
            this.acceptNewLendingButton = new System.Windows.Forms.Button();
            this.cancelNewLendingButton = new System.Windows.Forms.Button();
            this.chooseLendingDateLabel = new System.Windows.Forms.Label();
            this.lendingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todayCheckbox = new System.Windows.Forms.CheckBox();
            this.chosenLendingDateLabel = new System.Windows.Forms.Label();
            this.newLendingLabel = new System.Windows.Forms.Label();
            this.newLendingErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookSelectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSelectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculateReturnDateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookSelectDataGridView
            // 
            this.bookSelectDataGridView.AllowUserToAddRows = false;
            this.bookSelectDataGridView.AllowUserToDeleteRows = false;
            this.bookSelectDataGridView.AllowUserToResizeColumns = false;
            this.bookSelectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookSelectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.bookAuthor,
            this.bookPublisher,
            this.releaseDate,
            this.quantityInStock});
            this.bookSelectDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookSelectDataGridView.Location = new System.Drawing.Point(33, 88);
            this.bookSelectDataGridView.MultiSelect = false;
            this.bookSelectDataGridView.Name = "bookSelectDataGridView";
            this.bookSelectDataGridView.ReadOnly = true;
            this.bookSelectDataGridView.RowHeadersVisible = false;
            this.bookSelectDataGridView.RowHeadersWidth = 20;
            this.bookSelectDataGridView.RowTemplate.Height = 25;
            this.bookSelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookSelectDataGridView.Size = new System.Drawing.Size(485, 238);
            this.bookSelectDataGridView.TabIndex = 0;
            this.bookSelectDataGridView.SelectionChanged += new System.EventHandler(this.bookSelectDataGridView_SelectionChanged);
            // 
            // bookID
            // 
            this.bookID.HeaderText = "ID";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Width = 30;
            // 
            // bookName
            // 
            this.bookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookName.HeaderText = "Tytuł";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookAuthor.HeaderText = "Autor";
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.ReadOnly = true;
            // 
            // bookPublisher
            // 
            this.bookPublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookPublisher.HeaderText = "Wydawca";
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.ReadOnly = true;
            // 
            // releaseDate
            // 
            this.releaseDate.HeaderText = "Rok";
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.ReadOnly = true;
            this.releaseDate.Width = 45;
            // 
            // quantityInStock
            // 
            this.quantityInStock.HeaderText = "Stan";
            this.quantityInStock.Name = "quantityInStock";
            this.quantityInStock.ReadOnly = true;
            this.quantityInStock.Width = 35;
            // 
            // chooseBookLabel
            // 
            this.chooseBookLabel.AutoSize = true;
            this.chooseBookLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseBookLabel.Location = new System.Drawing.Point(33, 64);
            this.chooseBookLabel.Name = "chooseBookLabel";
            this.chooseBookLabel.Size = new System.Drawing.Size(124, 21);
            this.chooseBookLabel.TabIndex = 1;
            this.chooseBookLabel.Text = "Wybierz książkę:";
            // 
            // chooseCustomerLabel
            // 
            this.chooseCustomerLabel.AutoSize = true;
            this.chooseCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCustomerLabel.Location = new System.Drawing.Point(541, 64);
            this.chooseCustomerLabel.Name = "chooseCustomerLabel";
            this.chooseCustomerLabel.Size = new System.Drawing.Size(120, 21);
            this.chooseCustomerLabel.TabIndex = 1;
            this.chooseCustomerLabel.Text = "Wybierz klienta:";
            // 
            // customerSelectDataGridView
            // 
            this.customerSelectDataGridView.AllowUserToAddRows = false;
            this.customerSelectDataGridView.AllowUserToDeleteRows = false;
            this.customerSelectDataGridView.AllowUserToResizeColumns = false;
            this.customerSelectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerSelectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.name});
            this.customerSelectDataGridView.Location = new System.Drawing.Point(541, 88);
            this.customerSelectDataGridView.MultiSelect = false;
            this.customerSelectDataGridView.Name = "customerSelectDataGridView";
            this.customerSelectDataGridView.ReadOnly = true;
            this.customerSelectDataGridView.RowHeadersVisible = false;
            this.customerSelectDataGridView.RowHeadersWidth = 20;
            this.customerSelectDataGridView.RowTemplate.Height = 25;
            this.customerSelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerSelectDataGridView.Size = new System.Drawing.Size(182, 238);
            this.customerSelectDataGridView.TabIndex = 0;
            this.customerSelectDataGridView.SelectionChanged += new System.EventHandler(this.customerSelectDataGridView_SelectionChanged);
            // 
            // customerID
            // 
            this.customerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerID.HeaderText = "ID";
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Width = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Imię i nazwisko";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // chooseReturnDateLabel
            // 
            this.chooseReturnDateLabel.AutoSize = true;
            this.chooseReturnDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseReturnDateLabel.Location = new System.Drawing.Point(742, 230);
            this.chooseReturnDateLabel.Name = "chooseReturnDateLabel";
            this.chooseReturnDateLabel.Size = new System.Drawing.Size(160, 21);
            this.chooseReturnDateLabel.TabIndex = 1;
            this.chooseReturnDateLabel.Text = "Wskaż termin zwrotu:";
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Location = new System.Drawing.Point(742, 266);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.returnDateTimePicker.TabIndex = 2;
            this.returnDateTimePicker.ValueChanged += new System.EventHandler(this.returnDateTimePicker_ValueChanged);
            // 
            // caluclateReturnDateCheckbox
            // 
            this.caluclateReturnDateCheckbox.AutoSize = true;
            this.caluclateReturnDateCheckbox.Location = new System.Drawing.Point(742, 295);
            this.caluclateReturnDateCheckbox.Name = "caluclateReturnDateCheckbox";
            this.caluclateReturnDateCheckbox.Size = new System.Drawing.Size(117, 19);
            this.caluclateReturnDateCheckbox.TabIndex = 3;
            this.caluclateReturnDateCheckbox.Text = "Do zwrotu za dni:";
            this.caluclateReturnDateCheckbox.UseVisualStyleBackColor = true;
            this.caluclateReturnDateCheckbox.CheckedChanged += new System.EventHandler(this.caluclateReturnDateCheckbox_CheckedChanged);
            // 
            // calculateReturnDateNumericUpDown
            // 
            this.calculateReturnDateNumericUpDown.Enabled = false;
            this.calculateReturnDateNumericUpDown.Location = new System.Drawing.Point(866, 295);
            this.calculateReturnDateNumericUpDown.Maximum = new decimal(new int[] {
            730,
            0,
            0,
            0});
            this.calculateReturnDateNumericUpDown.Name = "calculateReturnDateNumericUpDown";
            this.calculateReturnDateNumericUpDown.Size = new System.Drawing.Size(76, 23);
            this.calculateReturnDateNumericUpDown.TabIndex = 4;
            this.calculateReturnDateNumericUpDown.ValueChanged += new System.EventHandler(this.calculateReturnDateNumericUpDown_ValueChanged);
            // 
            // chosenBookLabel
            // 
            this.chosenBookLabel.AutoSize = true;
            this.chosenBookLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenBookLabel.Location = new System.Drawing.Point(33, 329);
            this.chosenBookLabel.MaximumSize = new System.Drawing.Size(1000, 0);
            this.chosenBookLabel.Name = "chosenBookLabel";
            this.chosenBookLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenBookLabel.TabIndex = 5;
            this.chosenBookLabel.Text = "Wybrano: ";
            // 
            // chosenCustomerLabel
            // 
            this.chosenCustomerLabel.AutoSize = true;
            this.chosenCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenCustomerLabel.Location = new System.Drawing.Point(541, 329);
            this.chosenCustomerLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.chosenCustomerLabel.Name = "chosenCustomerLabel";
            this.chosenCustomerLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenCustomerLabel.TabIndex = 5;
            this.chosenCustomerLabel.Text = "Wybrano: ";
            // 
            // chosenReturnDateLabel
            // 
            this.chosenReturnDateLabel.AutoSize = true;
            this.chosenReturnDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenReturnDateLabel.Location = new System.Drawing.Point(742, 329);
            this.chosenReturnDateLabel.Name = "chosenReturnDateLabel";
            this.chosenReturnDateLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenReturnDateLabel.TabIndex = 5;
            this.chosenReturnDateLabel.Text = "Wybrano: ";
            // 
            // acceptNewLendingButton
            // 
            this.acceptNewLendingButton.Location = new System.Drawing.Point(113, 374);
            this.acceptNewLendingButton.Name = "acceptNewLendingButton";
            this.acceptNewLendingButton.Size = new System.Drawing.Size(121, 48);
            this.acceptNewLendingButton.TabIndex = 6;
            this.acceptNewLendingButton.Text = "Wypożycz";
            this.acceptNewLendingButton.UseVisualStyleBackColor = true;
            this.acceptNewLendingButton.Click += new System.EventHandler(this.acceptNewLendingButton_Click);
            // 
            // cancelNewLendingButton
            // 
            this.cancelNewLendingButton.Location = new System.Drawing.Point(258, 374);
            this.cancelNewLendingButton.Name = "cancelNewLendingButton";
            this.cancelNewLendingButton.Size = new System.Drawing.Size(121, 48);
            this.cancelNewLendingButton.TabIndex = 6;
            this.cancelNewLendingButton.Text = "Anuluj";
            this.cancelNewLendingButton.UseVisualStyleBackColor = true;
            this.cancelNewLendingButton.Click += new System.EventHandler(this.cancelNewLendingButton_Click);
            // 
            // chooseLendingDateLabel
            // 
            this.chooseLendingDateLabel.AutoSize = true;
            this.chooseLendingDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseLendingDateLabel.Location = new System.Drawing.Point(743, 64);
            this.chooseLendingDateLabel.Name = "chooseLendingDateLabel";
            this.chooseLendingDateLabel.Size = new System.Drawing.Size(203, 21);
            this.chooseLendingDateLabel.TabIndex = 1;
            this.chooseLendingDateLabel.Text = "Wskaż dzień wypożyczenia: ";
            // 
            // lendingDateTimePicker
            // 
            this.lendingDateTimePicker.Enabled = false;
            this.lendingDateTimePicker.Location = new System.Drawing.Point(742, 99);
            this.lendingDateTimePicker.MaxDate = new System.DateTime(2100, 12, 25, 0, 0, 0, 0);
            this.lendingDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.lendingDateTimePicker.Name = "lendingDateTimePicker";
            this.lendingDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.lendingDateTimePicker.TabIndex = 2;
            this.lendingDateTimePicker.Value = new System.DateTime(2023, 5, 25, 23, 59, 59, 0);
            this.lendingDateTimePicker.ValueChanged += new System.EventHandler(this.lendingDateTimePicker_ValueChanged);
            // 
            // todayCheckbox
            // 
            this.todayCheckbox.AutoSize = true;
            this.todayCheckbox.Checked = true;
            this.todayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todayCheckbox.Location = new System.Drawing.Point(742, 128);
            this.todayCheckbox.Name = "todayCheckbox";
            this.todayCheckbox.Size = new System.Drawing.Size(59, 19);
            this.todayCheckbox.TabIndex = 3;
            this.todayCheckbox.Text = "Dzisiaj";
            this.todayCheckbox.UseVisualStyleBackColor = true;
            this.todayCheckbox.CheckedChanged += new System.EventHandler(this.todayCheckbox_CheckedChanged);
            // 
            // chosenLendingDateLabel
            // 
            this.chosenLendingDateLabel.AutoSize = true;
            this.chosenLendingDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenLendingDateLabel.Location = new System.Drawing.Point(742, 163);
            this.chosenLendingDateLabel.Name = "chosenLendingDateLabel";
            this.chosenLendingDateLabel.Size = new System.Drawing.Size(68, 17);
            this.chosenLendingDateLabel.TabIndex = 5;
            this.chosenLendingDateLabel.Text = "Wybrano: ";
            // 
            // newLendingLabel
            // 
            this.newLendingLabel.AutoSize = true;
            this.newLendingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newLendingLabel.Location = new System.Drawing.Point(33, 20);
            this.newLendingLabel.Name = "newLendingLabel";
            this.newLendingLabel.Size = new System.Drawing.Size(201, 30);
            this.newLendingLabel.TabIndex = 7;
            this.newLendingLabel.Text = "Nowe wypożyczenie";
            // 
            // newLendingErrorLabel
            // 
            this.newLendingErrorLabel.AutoSize = true;
            this.newLendingErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newLendingErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newLendingErrorLabel.Location = new System.Drawing.Point(396, 374);
            this.newLendingErrorLabel.Name = "newLendingErrorLabel";
            this.newLendingErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.newLendingErrorLabel.TabIndex = 8;
            // 
            // newLendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 436);
            this.Controls.Add(this.newLendingErrorLabel);
            this.Controls.Add(this.newLendingLabel);
            this.Controls.Add(this.cancelNewLendingButton);
            this.Controls.Add(this.acceptNewLendingButton);
            this.Controls.Add(this.chosenLendingDateLabel);
            this.Controls.Add(this.chosenReturnDateLabel);
            this.Controls.Add(this.chosenCustomerLabel);
            this.Controls.Add(this.chosenBookLabel);
            this.Controls.Add(this.calculateReturnDateNumericUpDown);
            this.Controls.Add(this.todayCheckbox);
            this.Controls.Add(this.caluclateReturnDateCheckbox);
            this.Controls.Add(this.lendingDateTimePicker);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.chooseLendingDateLabel);
            this.Controls.Add(this.chooseReturnDateLabel);
            this.Controls.Add(this.chooseCustomerLabel);
            this.Controls.Add(this.chooseBookLabel);
            this.Controls.Add(this.customerSelectDataGridView);
            this.Controls.Add(this.bookSelectDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(993, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(993, 475);
            this.Name = "newLendingForm";
            this.ShowInTaskbar = false;
            this.Text = "Nowe wypożyczenie";
            this.Load += new System.EventHandler(this.newLendingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookSelectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSelectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculateReturnDateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView bookSelectDataGridView;
        private Label chooseBookLabel;
        private Label chooseCustomerLabel;
        private DataGridView customerSelectDataGridView;
        private Label chooseReturnDateLabel;
        private DateTimePicker returnDateTimePicker;
        private CheckBox caluclateReturnDateCheckbox;
        private NumericUpDown calculateReturnDateNumericUpDown;
        private Label chosenBookLabel;
        private Label chosenCustomerLabel;
        private Label chosenReturnDateLabel;
        private Button acceptNewLendingButton;
        private Button cancelNewLendingButton;
        private DataGridViewTextBoxColumn bookID;
        private DataGridViewTextBoxColumn bookName;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn bookPublisher;
        private DataGridViewTextBoxColumn releaseDate;
        private DataGridViewTextBoxColumn quantityInStock;
        private Label chooseLendingDateLabel;
        private DateTimePicker lendingDateTimePicker;
        private CheckBox todayCheckbox;
        private Label chosenLendingDateLabel;
        private Label newLendingLabel;
        private DataGridViewTextBoxColumn customerID;
        private DataGridViewTextBoxColumn name;
        private Label newLendingErrorLabel;
        
    }
}