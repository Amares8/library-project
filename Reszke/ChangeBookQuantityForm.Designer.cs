namespace Reszke
{
    partial class ChangeBookQuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeBookQuantityForm));
            this.toChangeLabel = new System.Windows.Forms.Label();
            this.cancelQuantityChangeButton = new System.Windows.Forms.Button();
            this.confirmQuantityChangeButton = new System.Windows.Forms.Button();
            this.changingQuantityLabel = new System.Windows.Forms.Label();
            this.toChangeInfoLabel = new System.Windows.Forms.Label();
            this.ChangeAmountLabel = new System.Windows.Forms.Label();
            this.quantityChangeUpDown = new System.Windows.Forms.NumericUpDown();
            this.afterChangeQuantityLabel = new System.Windows.Forms.Label();
            this.afterChangeQuantityInfoLabel = new System.Windows.Forms.Label();
            this.quantityChangeErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityChangeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // toChangeLabel
            // 
            this.toChangeLabel.AutoSize = true;
            this.toChangeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toChangeLabel.Location = new System.Drawing.Point(39, 62);
            this.toChangeLabel.Name = "toChangeLabel";
            this.toChangeLabel.Size = new System.Drawing.Size(68, 21);
            this.toChangeLabel.TabIndex = 17;
            this.toChangeLabel.Text = "Książka: ";
            // 
            // cancelQuantityChangeButton
            // 
            this.cancelQuantityChangeButton.Location = new System.Drawing.Point(184, 290);
            this.cancelQuantityChangeButton.Name = "cancelQuantityChangeButton";
            this.cancelQuantityChangeButton.Size = new System.Drawing.Size(93, 46);
            this.cancelQuantityChangeButton.TabIndex = 2;
            this.cancelQuantityChangeButton.Text = "Anuluj";
            this.cancelQuantityChangeButton.UseVisualStyleBackColor = true;
            this.cancelQuantityChangeButton.Click += new System.EventHandler(this.cancelQuantityChangeButton_Click);
            // 
            // confirmQuantityChangeButton
            // 
            this.confirmQuantityChangeButton.Location = new System.Drawing.Point(75, 290);
            this.confirmQuantityChangeButton.Name = "confirmQuantityChangeButton";
            this.confirmQuantityChangeButton.Size = new System.Drawing.Size(93, 46);
            this.confirmQuantityChangeButton.TabIndex = 1;
            this.confirmQuantityChangeButton.Text = "Zmień ilość";
            this.confirmQuantityChangeButton.UseVisualStyleBackColor = true;
            this.confirmQuantityChangeButton.Click += new System.EventHandler(this.confirmQuantityChangeButton_Click);
            // 
            // changingQuantityLabel
            // 
            this.changingQuantityLabel.AutoSize = true;
            this.changingQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changingQuantityLabel.Location = new System.Drawing.Point(29, 21);
            this.changingQuantityLabel.Name = "changingQuantityLabel";
            this.changingQuantityLabel.Size = new System.Drawing.Size(291, 30);
            this.changingQuantityLabel.TabIndex = 14;
            this.changingQuantityLabel.Text = "Zmiana stanu magazynowego";
            // 
            // toChangeInfoLabel
            // 
            this.toChangeInfoLabel.AutoSize = true;
            this.toChangeInfoLabel.Location = new System.Drawing.Point(63, 83);
            this.toChangeInfoLabel.Name = "toChangeInfoLabel";
            this.toChangeInfoLabel.Size = new System.Drawing.Size(12, 15);
            this.toChangeInfoLabel.TabIndex = 18;
            this.toChangeInfoLabel.Text = "-";
            // 
            // ChangeAmountLabel
            // 
            this.ChangeAmountLabel.AutoSize = true;
            this.ChangeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeAmountLabel.Location = new System.Drawing.Point(39, 133);
            this.ChangeAmountLabel.Name = "ChangeAmountLabel";
            this.ChangeAmountLabel.Size = new System.Drawing.Size(78, 21);
            this.ChangeAmountLabel.TabIndex = 17;
            this.ChangeAmountLabel.Text = "Zmiana o:";
            // 
            // quantityChangeUpDown
            // 
            this.quantityChangeUpDown.Location = new System.Drawing.Point(63, 169);
            this.quantityChangeUpDown.Name = "quantityChangeUpDown";
            this.quantityChangeUpDown.Size = new System.Drawing.Size(54, 23);
            this.quantityChangeUpDown.TabIndex = 0;
            this.quantityChangeUpDown.ValueChanged += new System.EventHandler(this.quantityChangeUpDown_ValueChanged);
            // 
            // afterChangeQuantityLabel
            // 
            this.afterChangeQuantityLabel.AutoSize = true;
            this.afterChangeQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afterChangeQuantityLabel.Location = new System.Drawing.Point(39, 212);
            this.afterChangeQuantityLabel.Name = "afterChangeQuantityLabel";
            this.afterChangeQuantityLabel.Size = new System.Drawing.Size(123, 21);
            this.afterChangeQuantityLabel.TabIndex = 17;
            this.afterChangeQuantityLabel.Text = "Stan po zmianie:";
            // 
            // afterChangeQuantityInfoLabel
            // 
            this.afterChangeQuantityInfoLabel.AutoSize = true;
            this.afterChangeQuantityInfoLabel.Location = new System.Drawing.Point(63, 246);
            this.afterChangeQuantityInfoLabel.Name = "afterChangeQuantityInfoLabel";
            this.afterChangeQuantityInfoLabel.Size = new System.Drawing.Size(13, 15);
            this.afterChangeQuantityInfoLabel.TabIndex = 20;
            this.afterChangeQuantityInfoLabel.Text = "0";
            // 
            // quantityChangeErrorLabel
            // 
            this.quantityChangeErrorLabel.AutoSize = true;
            this.quantityChangeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityChangeErrorLabel.Location = new System.Drawing.Point(56, 269);
            this.quantityChangeErrorLabel.Name = "quantityChangeErrorLabel";
            this.quantityChangeErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.quantityChangeErrorLabel.TabIndex = 21;
            // 
            // ChangeBookQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 360);
            this.Controls.Add(this.quantityChangeErrorLabel);
            this.Controls.Add(this.afterChangeQuantityInfoLabel);
            this.Controls.Add(this.quantityChangeUpDown);
            this.Controls.Add(this.toChangeInfoLabel);
            this.Controls.Add(this.afterChangeQuantityLabel);
            this.Controls.Add(this.ChangeAmountLabel);
            this.Controls.Add(this.toChangeLabel);
            this.Controls.Add(this.cancelQuantityChangeButton);
            this.Controls.Add(this.confirmQuantityChangeButton);
            this.Controls.Add(this.changingQuantityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeBookQuantityForm";
            this.ShowInTaskbar = false;
            this.Text = "Zmiana stanu magazynowego książki";
            this.Load += new System.EventHandler(this.ChangeBookQuantityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityChangeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label toChangeLabel;
        private Button cancelQuantityChangeButton;
        private Button confirmQuantityChangeButton;
        private Label changingQuantityLabel;
        private Label toChangeInfoLabel;
        private Label ChangeAmountLabel;
        private NumericUpDown quantityChangeUpDown;
        private Label afterChangeQuantityLabel;
        private Label afterChangeQuantityInfoLabel;
        private Label quantityChangeErrorLabel;
    }
}