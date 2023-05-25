namespace Reszke
{
    partial class ReturnLendingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnLendingForm));
            this.returnBookLabel = new System.Windows.Forms.Label();
            this.finalReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todayCheckBox = new System.Windows.Forms.CheckBox();
            this.finalReturnDateLabel = new System.Windows.Forms.Label();
            this.lendingInfoLabel = new System.Windows.Forms.Label();
            this.lendingInfoDetailsLabel = new System.Windows.Forms.Label();
            this.overdueLabel = new System.Windows.Forms.Label();
            this.overdueInfoLabel = new System.Windows.Forms.Label();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.cancelReturningButton = new System.Windows.Forms.Button();
            this.bookReturnErrorLabel = new System.Windows.Forms.Label();
            this.finalChosenReturnedDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBookLabel
            // 
            this.returnBookLabel.AutoSize = true;
            this.returnBookLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnBookLabel.Location = new System.Drawing.Point(33, 20);
            this.returnBookLabel.Name = "returnBookLabel";
            this.returnBookLabel.Size = new System.Drawing.Size(132, 30);
            this.returnBookLabel.TabIndex = 8;
            this.returnBookLabel.Text = "Zwrot książki";
            // 
            // finalReturnedDateTimePicker
            // 
            this.finalReturnedDateTimePicker.Checked = false;
            this.finalReturnedDateTimePicker.Enabled = false;
            this.finalReturnedDateTimePicker.Location = new System.Drawing.Point(33, 195);
            this.finalReturnedDateTimePicker.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.finalReturnedDateTimePicker.Name = "finalReturnedDateTimePicker";
            this.finalReturnedDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.finalReturnedDateTimePicker.TabIndex = 0;
            this.finalReturnedDateTimePicker.ValueChanged += new System.EventHandler(this.finalReturnedDateTimePicker_ValueChanged);
            // 
            // todayCheckBox
            // 
            this.todayCheckBox.AutoSize = true;
            this.todayCheckBox.Checked = true;
            this.todayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todayCheckBox.Location = new System.Drawing.Point(40, 224);
            this.todayCheckBox.Name = "todayCheckBox";
            this.todayCheckBox.Size = new System.Drawing.Size(59, 19);
            this.todayCheckBox.TabIndex = 1;
            this.todayCheckBox.Text = "Dzisiaj";
            this.todayCheckBox.UseVisualStyleBackColor = true;
            this.todayCheckBox.CheckedChanged += new System.EventHandler(this.todayCheckBox_CheckedChanged);
            // 
            // finalReturnDateLabel
            // 
            this.finalReturnDateLabel.AutoSize = true;
            this.finalReturnDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalReturnDateLabel.Location = new System.Drawing.Point(33, 162);
            this.finalReturnDateLabel.Name = "finalReturnDateLabel";
            this.finalReturnDateLabel.Size = new System.Drawing.Size(97, 21);
            this.finalReturnDateLabel.TabIndex = 11;
            this.finalReturnDateLabel.Text = "Data zwrotu:";
            // 
            // lendingInfoLabel
            // 
            this.lendingInfoLabel.AutoSize = true;
            this.lendingInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lendingInfoLabel.Location = new System.Drawing.Point(33, 59);
            this.lendingInfoLabel.Name = "lendingInfoLabel";
            this.lendingInfoLabel.Size = new System.Drawing.Size(116, 21);
            this.lendingInfoLabel.TabIndex = 12;
            this.lendingInfoLabel.Text = "Wypożyczenie: ";
            // 
            // lendingInfoDetailsLabel
            // 
            this.lendingInfoDetailsLabel.AutoSize = true;
            this.lendingInfoDetailsLabel.Location = new System.Drawing.Point(40, 89);
            this.lendingInfoDetailsLabel.MaximumSize = new System.Drawing.Size(240, 0);
            this.lendingInfoDetailsLabel.Name = "lendingInfoDetailsLabel";
            this.lendingInfoDetailsLabel.Size = new System.Drawing.Size(0, 15);
            this.lendingInfoDetailsLabel.TabIndex = 13;
            // 
            // overdueLabel
            // 
            this.overdueLabel.AutoSize = true;
            this.overdueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overdueLabel.Location = new System.Drawing.Point(33, 277);
            this.overdueLabel.Name = "overdueLabel";
            this.overdueLabel.Size = new System.Drawing.Size(92, 21);
            this.overdueLabel.TabIndex = 11;
            this.overdueLabel.Text = "Opóźnienie:";
            // 
            // overdueInfoLabel
            // 
            this.overdueInfoLabel.AutoSize = true;
            this.overdueInfoLabel.Location = new System.Drawing.Point(40, 308);
            this.overdueInfoLabel.Name = "overdueInfoLabel";
            this.overdueInfoLabel.Size = new System.Drawing.Size(37, 15);
            this.overdueInfoLabel.TabIndex = 14;
            this.overdueInfoLabel.Text = "Dni: 0";
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(40, 362);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(112, 49);
            this.returnBookButton.TabIndex = 2;
            this.returnBookButton.Text = "Zwróć książkę";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // cancelReturningButton
            // 
            this.cancelReturningButton.Location = new System.Drawing.Point(158, 362);
            this.cancelReturningButton.Name = "cancelReturningButton";
            this.cancelReturningButton.Size = new System.Drawing.Size(112, 49);
            this.cancelReturningButton.TabIndex = 3;
            this.cancelReturningButton.Text = "Anuluj";
            this.cancelReturningButton.UseVisualStyleBackColor = true;
            this.cancelReturningButton.Click += new System.EventHandler(this.cancelReturningButton_Click);
            // 
            // bookReturnErrorLabel
            // 
            this.bookReturnErrorLabel.AutoSize = true;
            this.bookReturnErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.bookReturnErrorLabel.Location = new System.Drawing.Point(42, 337);
            this.bookReturnErrorLabel.Name = "bookReturnErrorLabel";
            this.bookReturnErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.bookReturnErrorLabel.TabIndex = 16;
            // 
            // finalChosenReturnedDateLabel
            // 
            this.finalChosenReturnedDateLabel.AutoSize = true;
            this.finalChosenReturnedDateLabel.Location = new System.Drawing.Point(40, 246);
            this.finalChosenReturnedDateLabel.Name = "finalChosenReturnedDateLabel";
            this.finalChosenReturnedDateLabel.Size = new System.Drawing.Size(61, 15);
            this.finalChosenReturnedDateLabel.TabIndex = 14;
            this.finalChosenReturnedDateLabel.Text = "Wybrano: ";
            // 
            // ReturnLendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 429);
            this.Controls.Add(this.bookReturnErrorLabel);
            this.Controls.Add(this.cancelReturningButton);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.finalChosenReturnedDateLabel);
            this.Controls.Add(this.overdueInfoLabel);
            this.Controls.Add(this.lendingInfoDetailsLabel);
            this.Controls.Add(this.lendingInfoLabel);
            this.Controls.Add(this.overdueLabel);
            this.Controls.Add(this.finalReturnDateLabel);
            this.Controls.Add(this.todayCheckBox);
            this.Controls.Add(this.finalReturnedDateTimePicker);
            this.Controls.Add(this.returnBookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "ReturnLendingForm";
            this.ShowInTaskbar = false;
            this.Text = "Zwrot książki";
            this.Load += new System.EventHandler(this.ReturnLendingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label returnBookLabel;
        private DateTimePicker finalReturnedDateTimePicker;
        private CheckBox todayCheckBox;
        private Label finalReturnDateLabel;
        private Label lendingInfoLabel;
        private Label lendingInfoDetailsLabel;
        private Label overdueLabel;
        private Label overdueInfoLabel;
        private Button returnBookButton;
        private Button cancelReturningButton;
        private Label bookReturnErrorLabel;
        private Label finalChosenReturnedDateLabel;
    }
}