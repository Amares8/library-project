namespace Reszke
{
    partial class CustomerDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDeleteForm));
            this.deleteRecordInfoLabel = new System.Windows.Forms.Label();
            this.toDeleteLabel = new System.Windows.Forms.Label();
            this.cancelDeleteButton = new System.Windows.Forms.Button();
            this.confirmDeleteButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.deleteClientLabel = new System.Windows.Forms.Label();
            this.deleteErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteRecordInfoLabel
            // 
            this.deleteRecordInfoLabel.AutoSize = true;
            this.deleteRecordInfoLabel.Location = new System.Drawing.Point(36, 158);
            this.deleteRecordInfoLabel.Name = "deleteRecordInfoLabel";
            this.deleteRecordInfoLabel.Size = new System.Drawing.Size(12, 15);
            this.deleteRecordInfoLabel.TabIndex = 26;
            this.deleteRecordInfoLabel.Text = "-";
            // 
            // toDeleteLabel
            // 
            this.toDeleteLabel.AutoSize = true;
            this.toDeleteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDeleteLabel.Location = new System.Drawing.Point(24, 128);
            this.toDeleteLabel.Name = "toDeleteLabel";
            this.toDeleteLabel.Size = new System.Drawing.Size(106, 21);
            this.toDeleteLabel.TabIndex = 25;
            this.toDeleteLabel.Text = "Do usunięcia: ";
            // 
            // cancelDeleteButton
            // 
            this.cancelDeleteButton.Location = new System.Drawing.Point(188, 262);
            this.cancelDeleteButton.Name = "cancelDeleteButton";
            this.cancelDeleteButton.Size = new System.Drawing.Size(93, 46);
            this.cancelDeleteButton.TabIndex = 23;
            this.cancelDeleteButton.Text = "Anuluj";
            this.cancelDeleteButton.UseVisualStyleBackColor = true;
            this.cancelDeleteButton.Click += new System.EventHandler(this.cancelDeleteButton_Click);
            // 
            // confirmDeleteButton
            // 
            this.confirmDeleteButton.Location = new System.Drawing.Point(66, 262);
            this.confirmDeleteButton.Name = "confirmDeleteButton";
            this.confirmDeleteButton.Size = new System.Drawing.Size(93, 46);
            this.confirmDeleteButton.TabIndex = 24;
            this.confirmDeleteButton.Text = "Usuń";
            this.confirmDeleteButton.UseVisualStyleBackColor = true;
            this.confirmDeleteButton.Click += new System.EventHandler(this.confirmDeleteButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(24, 61);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(310, 67);
            this.warningLabel.TabIndex = 22;
            this.warningLabel.Text = resources.GetString("warningLabel.Text");
            // 
            // deleteClientLabel
            // 
            this.deleteClientLabel.AutoSize = true;
            this.deleteClientLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteClientLabel.Location = new System.Drawing.Point(24, 21);
            this.deleteClientLabel.Name = "deleteClientLabel";
            this.deleteClientLabel.Size = new System.Drawing.Size(169, 30);
            this.deleteClientLabel.TabIndex = 21;
            this.deleteClientLabel.Text = "Usuwanie klienta";
            // 
            // deleteErrorLabel
            // 
            this.deleteErrorLabel.AutoSize = true;
            this.deleteErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteErrorLabel.Location = new System.Drawing.Point(34, 225);
            this.deleteErrorLabel.Name = "deleteErrorLabel";
            this.deleteErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.deleteErrorLabel.TabIndex = 27;
            // 
            // CustomerDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 329);
            this.Controls.Add(this.deleteErrorLabel);
            this.Controls.Add(this.deleteRecordInfoLabel);
            this.Controls.Add(this.toDeleteLabel);
            this.Controls.Add(this.cancelDeleteButton);
            this.Controls.Add(this.confirmDeleteButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.deleteClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDeleteForm";
            this.Text = "Usuwanie rekordu klienta";
            this.Load += new System.EventHandler(this.CustomerDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deleteRecordInfoLabel;
        private Label toDeleteLabel;
        private Button cancelDeleteButton;
        private Button confirmDeleteButton;
        private Label warningLabel;
        private Label deleteClientLabel;
        private Label deleteErrorLabel;
    }
}