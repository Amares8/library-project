namespace Reszke
{
    partial class AddEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.cancelAddButton = new System.Windows.Forms.Button();
            this.confirmAddButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.newEmployeeLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.privilegeUpDown = new System.Windows.Forms.NumericUpDown();
            this.privilegeLabel = new System.Windows.Forms.Label();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privilegeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddButton
            // 
            this.cancelAddButton.Location = new System.Drawing.Point(285, 302);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(93, 46);
            this.cancelAddButton.TabIndex = 38;
            this.cancelAddButton.Text = "Anuluj";
            this.cancelAddButton.UseVisualStyleBackColor = true;
            this.cancelAddButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // confirmAddButton
            // 
            this.confirmAddButton.Location = new System.Drawing.Point(178, 302);
            this.confirmAddButton.Name = "confirmAddButton";
            this.confirmAddButton.Size = new System.Drawing.Size(93, 46);
            this.confirmAddButton.TabIndex = 39;
            this.confirmAddButton.Text = "Dodaj";
            this.confirmAddButton.UseVisualStyleBackColor = true;
            this.confirmAddButton.Click += new System.EventHandler(this.confirmAddButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(322, 102);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 23);
            this.emailTextBox.TabIndex = 34;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(35, 229);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(123, 23);
            this.loginTextBox.TabIndex = 35;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(38, 165);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(220, 23);
            this.lastNameTextBox.TabIndex = 36;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(38, 102);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 23);
            this.firstNameTextBox.TabIndex = 37;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(331, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(105, 21);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Adres e-mail: ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(47, 205);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(56, 21);
            this.loginLabel.TabIndex = 31;
            this.loginLabel.Text = "Login: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(47, 141);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 32;
            this.lastNameLabel.Text = "Nazwisko: ";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(52, 78);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(43, 21);
            this.firstNameLabel.TabIndex = 33;
            this.firstNameLabel.Text = "Imię:";
            // 
            // newEmployeeLabel
            // 
            this.newEmployeeLabel.AutoSize = true;
            this.newEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newEmployeeLabel.Location = new System.Drawing.Point(38, 24);
            this.newEmployeeLabel.Name = "newEmployeeLabel";
            this.newEmployeeLabel.Size = new System.Drawing.Size(308, 30);
            this.newEmployeeLabel.TabIndex = 29;
            this.newEmployeeLabel.Text = "Dodawanie nowego pracownika";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // privilegeUpDown
            // 
            this.privilegeUpDown.Location = new System.Drawing.Point(321, 165);
            this.privilegeUpDown.Name = "privilegeUpDown";
            this.privilegeUpDown.Size = new System.Drawing.Size(140, 23);
            this.privilegeUpDown.TabIndex = 40;
            // 
            // privilegeLabel
            // 
            this.privilegeLabel.AutoSize = true;
            this.privilegeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.privilegeLabel.Location = new System.Drawing.Point(331, 141);
            this.privilegeLabel.Name = "privilegeLabel";
            this.privilegeLabel.Size = new System.Drawing.Size(105, 21);
            this.privilegeLabel.TabIndex = 33;
            this.privilegeLabel.Text = "Uprawnienia: ";
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Items.AddRange(new object[] {
            "stażysta",
            "infomatyk",
            "księgowy",
            "kadrowy",
            "kierownik",
            "asystent",
            "nadzorca",
            "prezes",
            "bibliotekarz"});
            this.jobTitleComboBox.Location = new System.Drawing.Point(321, 228);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(140, 23);
            this.jobTitleComboBox.TabIndex = 41;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jobTitleLabel.Location = new System.Drawing.Point(331, 204);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(96, 21);
            this.jobTitleLabel.TabIndex = 32;
            this.jobTitleLabel.Text = "Stanowisko: ";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(178, 284);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 42;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 370);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.jobTitleComboBox);
            this.Controls.Add(this.privilegeUpDown);
            this.Controls.Add(this.cancelAddButton);
            this.Controls.Add(this.confirmAddButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.privilegeLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.newEmployeeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.ShowInTaskbar = false;
            this.Text = "Dodawanie nowego pracownika";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privilegeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelAddButton;
        private Button confirmAddButton;
        private TextBox emailTextBox;
        private TextBox loginTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label emailLabel;
        private Label loginLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label newEmployeeLabel;
        private ImageList imageList1;
        private NumericUpDown privilegeUpDown;
        private Label privilegeLabel;
        private ComboBox jobTitleComboBox;
        private Label jobTitleLabel;
        private Label errorLabel;
    }
}