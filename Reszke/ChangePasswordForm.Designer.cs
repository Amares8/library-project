namespace Reszke
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.newPassword1TextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.newPassword2TextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newPassword1TextBox
            // 
            this.newPassword1TextBox.Location = new System.Drawing.Point(31, 191);
            this.newPassword1TextBox.Name = "newPassword1TextBox";
            this.newPassword1TextBox.Size = new System.Drawing.Size(220, 23);
            this.newPassword1TextBox.TabIndex = 1;
            this.newPassword1TextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordLabel.Location = new System.Drawing.Point(45, 167);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(99, 21);
            this.newPasswordLabel.TabIndex = 48;
            this.newPasswordLabel.Text = "Nowe hasło: ";
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePasswordLabel.Location = new System.Drawing.Point(31, 24);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(137, 30);
            this.changePasswordLabel.TabIndex = 47;
            this.changePasswordLabel.Text = "Zmiana hasła";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(12, 74);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(94, 21);
            this.userLabel.TabIndex = 48;
            this.userLabel.Text = "Użytkownik:";
            // 
            // newPassword2TextBox
            // 
            this.newPassword2TextBox.Location = new System.Drawing.Point(31, 241);
            this.newPassword2TextBox.Name = "newPassword2TextBox";
            this.newPassword2TextBox.Size = new System.Drawing.Size(220, 23);
            this.newPassword2TextBox.TabIndex = 2;
            this.newPassword2TextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(45, 217);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(156, 21);
            this.repeatPasswordLabel.TabIndex = 48;
            this.repeatPasswordLabel.Text = "Powtórz nowe hasło: ";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(32, 270);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 50;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(152, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 46);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(45, 295);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(93, 46);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Zmień hasło";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPasswordLabel.Location = new System.Drawing.Point(45, 107);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.oldPasswordLabel.TabIndex = 48;
            this.oldPasswordLabel.Text = "Stare hasło";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(31, 131);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(220, 23);
            this.oldPasswordTextBox.TabIndex = 0;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 353);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.newPassword2TextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.newPassword1TextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Text = "Zmiana hasła";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox newPassword1TextBox;
        private Label newPasswordLabel;
        private Label changePasswordLabel;
        private Label userLabel;
        private TextBox newPassword2TextBox;
        private Label repeatPasswordLabel;
        private Label errorLabel;
        private Button cancelButton;
        private Button confirmButton;
        private Label oldPasswordLabel;
        private TextBox oldPasswordTextBox;
    }
}