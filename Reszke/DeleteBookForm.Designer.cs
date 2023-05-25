namespace Reszke
{
    partial class DeleteBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBookForm));
            this.deleteRecordInfoLabel = new System.Windows.Forms.Label();
            this.toDeleteLabel = new System.Windows.Forms.Label();
            this.cancelDeleteButton = new System.Windows.Forms.Button();
            this.confirmDeleteButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.deleteBookLabel = new System.Windows.Forms.Label();
            this.deleteErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteRecordInfoLabel
            // 
            this.deleteRecordInfoLabel.AutoSize = true;
            this.deleteRecordInfoLabel.Location = new System.Drawing.Point(35, 157);
            this.deleteRecordInfoLabel.Name = "deleteRecordInfoLabel";
            this.deleteRecordInfoLabel.Size = new System.Drawing.Size(12, 15);
            this.deleteRecordInfoLabel.TabIndex = 20;
            this.deleteRecordInfoLabel.Text = "-";
            // 
            // toDeleteLabel
            // 
            this.toDeleteLabel.AutoSize = true;
            this.toDeleteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDeleteLabel.Location = new System.Drawing.Point(23, 127);
            this.toDeleteLabel.Name = "toDeleteLabel";
            this.toDeleteLabel.Size = new System.Drawing.Size(106, 21);
            this.toDeleteLabel.TabIndex = 19;
            this.toDeleteLabel.Text = "Do usunięcia: ";
            // 
            // cancelDeleteButton
            // 
            this.cancelDeleteButton.Location = new System.Drawing.Point(187, 261);
            this.cancelDeleteButton.Name = "cancelDeleteButton";
            this.cancelDeleteButton.Size = new System.Drawing.Size(93, 46);
            this.cancelDeleteButton.TabIndex = 1;
            this.cancelDeleteButton.Text = "Anuluj";
            this.cancelDeleteButton.UseVisualStyleBackColor = true;
            this.cancelDeleteButton.Click += new System.EventHandler(this.cancelDeleteButton_Click);
            // 
            // confirmDeleteButton
            // 
            this.confirmDeleteButton.Location = new System.Drawing.Point(65, 261);
            this.confirmDeleteButton.Name = "confirmDeleteButton";
            this.confirmDeleteButton.Size = new System.Drawing.Size(93, 46);
            this.confirmDeleteButton.TabIndex = 0;
            this.confirmDeleteButton.Text = "Usuń";
            this.confirmDeleteButton.UseVisualStyleBackColor = true;
            this.confirmDeleteButton.Click += new System.EventHandler(this.confirmDeleteButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(23, 60);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(310, 67);
            this.warningLabel.TabIndex = 16;
            this.warningLabel.Text = resources.GetString("warningLabel.Text");
            // 
            // deleteBookLabel
            // 
            this.deleteBookLabel.AutoSize = true;
            this.deleteBookLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBookLabel.Location = new System.Drawing.Point(23, 20);
            this.deleteBookLabel.Name = "deleteBookLabel";
            this.deleteBookLabel.Size = new System.Drawing.Size(168, 30);
            this.deleteBookLabel.TabIndex = 15;
            this.deleteBookLabel.Text = "Usuwanie książki";
            // 
            // deleteErrorLabel
            // 
            this.deleteErrorLabel.AutoSize = true;
            this.deleteErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteErrorLabel.Location = new System.Drawing.Point(41, 239);
            this.deleteErrorLabel.Name = "deleteErrorLabel";
            this.deleteErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.deleteErrorLabel.TabIndex = 21;
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 337);
            this.Controls.Add(this.deleteErrorLabel);
            this.Controls.Add(this.deleteRecordInfoLabel);
            this.Controls.Add(this.toDeleteLabel);
            this.Controls.Add(this.cancelDeleteButton);
            this.Controls.Add(this.confirmDeleteButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.deleteBookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteBookForm";
            this.Text = "Usuwanie rekordu książki";
            this.Load += new System.EventHandler(this.DeleteBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deleteRecordInfoLabel;
        private Label toDeleteLabel;
        private Button cancelDeleteButton;
        private Button confirmDeleteButton;
        private Label warningLabel;
        private Label deleteBookLabel;
        private Label deleteErrorLabel;
    }
}