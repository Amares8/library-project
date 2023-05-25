namespace Reszke
{
    partial class DeleteLendingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteLendingForm));
            this.deleteLendingLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.confirmDeleteButton = new System.Windows.Forms.Button();
            this.cancelDeleteButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.toDeleteLabel = new System.Windows.Forms.Label();
            this.deleteRecordInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteLendingLabel
            // 
            this.deleteLendingLabel.AutoSize = true;
            this.deleteLendingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteLendingLabel.Location = new System.Drawing.Point(33, 20);
            this.deleteLendingLabel.Name = "deleteLendingLabel";
            this.deleteLendingLabel.Size = new System.Drawing.Size(236, 30);
            this.deleteLendingLabel.TabIndex = 9;
            this.deleteLendingLabel.Text = "Usuwanie wypożyczenia";
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(33, 60);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(310, 37);
            this.warningLabel.TabIndex = 10;
            this.warningLabel.Text = "Uwaga, ta operacja jest nieodwracalna i niezalecania dla przypadków innych niż om" +
    "yłkowo wprowadzone rekordy!";
            // 
            // confirmDeleteButton
            // 
            this.confirmDeleteButton.Location = new System.Drawing.Point(75, 240);
            this.confirmDeleteButton.Name = "confirmDeleteButton";
            this.confirmDeleteButton.Size = new System.Drawing.Size(93, 46);
            this.confirmDeleteButton.TabIndex = 0;
            this.confirmDeleteButton.Text = "Usuń";
            this.confirmDeleteButton.UseVisualStyleBackColor = true;
            this.confirmDeleteButton.Click += new System.EventHandler(this.confirmDeleteButton_Click);
            // 
            // cancelDeleteButton
            // 
            this.cancelDeleteButton.Location = new System.Drawing.Point(197, 240);
            this.cancelDeleteButton.Name = "cancelDeleteButton";
            this.cancelDeleteButton.Size = new System.Drawing.Size(93, 46);
            this.cancelDeleteButton.TabIndex = 1;
            this.cancelDeleteButton.Text = "Anuluj";
            this.cancelDeleteButton.UseVisualStyleBackColor = true;
            this.cancelDeleteButton.Click += new System.EventHandler(this.cancelDeleteButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(45, 216);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 12;
            // 
            // toDeleteLabel
            // 
            this.toDeleteLabel.AutoSize = true;
            this.toDeleteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDeleteLabel.Location = new System.Drawing.Point(33, 106);
            this.toDeleteLabel.Name = "toDeleteLabel";
            this.toDeleteLabel.Size = new System.Drawing.Size(106, 21);
            this.toDeleteLabel.TabIndex = 13;
            this.toDeleteLabel.Text = "Do usunięcia: ";
            // 
            // deleteRecordInfoLabel
            // 
            this.deleteRecordInfoLabel.AutoSize = true;
            this.deleteRecordInfoLabel.Location = new System.Drawing.Point(45, 136);
            this.deleteRecordInfoLabel.Name = "deleteRecordInfoLabel";
            this.deleteRecordInfoLabel.Size = new System.Drawing.Size(12, 15);
            this.deleteRecordInfoLabel.TabIndex = 14;
            this.deleteRecordInfoLabel.Text = "-";
            // 
            // DeleteLendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 303);
            this.Controls.Add(this.deleteRecordInfoLabel);
            this.Controls.Add(this.toDeleteLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelDeleteButton);
            this.Controls.Add(this.confirmDeleteButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.deleteLendingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteLendingForm";
            this.ShowInTaskbar = false;
            this.Text = "Usuwanie rekordu wypożyczenia";
            this.Load += new System.EventHandler(this.DeleteLendingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deleteLendingLabel;
        private Label warningLabel;
        private Button confirmDeleteButton;
        private Button cancelDeleteButton;
        private Label errorLabel;
        private Label toDeleteLabel;
        private Label deleteRecordInfoLabel;
    }
}