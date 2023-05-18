namespace Reszke
{
    partial class ModifyClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyClientForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmModifyButton = new System.Windows.Forms.Button();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.houseApartmentNumberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.chooseTelephoneNumberLabel = new System.Windows.Forms.Label();
            this.chooseLastNameLabel = new System.Windows.Forms.Label();
            this.chooseFirstNameLabel = new System.Windows.Forms.Label();
            this.newClientLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(289, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 46);
            this.cancelButton.TabIndex = 47;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmModifyButton
            // 
            this.confirmModifyButton.Location = new System.Drawing.Point(182, 360);
            this.confirmModifyButton.Name = "confirmModifyButton";
            this.confirmModifyButton.Size = new System.Drawing.Size(93, 46);
            this.confirmModifyButton.TabIndex = 48;
            this.confirmModifyButton.Text = "Modyfikuj";
            this.confirmModifyButton.UseVisualStyleBackColor = true;
            this.confirmModifyButton.Click += new System.EventHandler(this.confirmModifyButton_Click);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(329, 231);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(201, 23);
            this.streetTextBox.TabIndex = 38;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(329, 167);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(201, 23);
            this.cityTextBox.TabIndex = 39;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(30, 292);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 23);
            this.emailTextBox.TabIndex = 40;
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(440, 292);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(90, 23);
            this.apartmentNumberTextBox.TabIndex = 41;
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.Location = new System.Drawing.Point(329, 292);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(90, 23);
            this.houseNumberTextBox.TabIndex = 42;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(30, 231);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(123, 23);
            this.telephoneTextBox.TabIndex = 43;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(33, 167);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(220, 23);
            this.lastNameTextBox.TabIndex = 44;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(329, 104);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(123, 23);
            this.postalCodeTextBox.TabIndex = 45;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(33, 104);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 23);
            this.firstNameTextBox.TabIndex = 46;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalCodeLabel.Location = new System.Drawing.Point(338, 80);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(114, 21);
            this.postalCodeLabel.TabIndex = 32;
            this.postalCodeLabel.Text = "Kod pocztowy: ";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLabel.Location = new System.Drawing.Point(338, 207);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(44, 21);
            this.streetLabel.TabIndex = 33;
            this.streetLabel.Text = "Ulica";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(39, 268);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(105, 21);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "Adres e-mail: ";
            // 
            // houseApartmentNumberLabel
            // 
            this.houseApartmentNumberLabel.AutoSize = true;
            this.houseApartmentNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.houseApartmentNumberLabel.Location = new System.Drawing.Point(338, 268);
            this.houseApartmentNumberLabel.Name = "houseApartmentNumberLabel";
            this.houseApartmentNumberLabel.Size = new System.Drawing.Size(167, 21);
            this.houseApartmentNumberLabel.TabIndex = 35;
            this.houseApartmentNumberLabel.Text = "Nr domu / mieszkania:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(338, 143);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(101, 21);
            this.cityLabel.TabIndex = 36;
            this.cityLabel.Text = "Miescowość: ";
            // 
            // chooseTelephoneNumberLabel
            // 
            this.chooseTelephoneNumberLabel.AutoSize = true;
            this.chooseTelephoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseTelephoneNumberLabel.Location = new System.Drawing.Point(42, 207);
            this.chooseTelephoneNumberLabel.Name = "chooseTelephoneNumberLabel";
            this.chooseTelephoneNumberLabel.Size = new System.Drawing.Size(92, 21);
            this.chooseTelephoneNumberLabel.TabIndex = 31;
            this.chooseTelephoneNumberLabel.Text = "Nr telefonu:";
            // 
            // chooseLastNameLabel
            // 
            this.chooseLastNameLabel.AutoSize = true;
            this.chooseLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseLastNameLabel.Location = new System.Drawing.Point(47, 143);
            this.chooseLastNameLabel.Name = "chooseLastNameLabel";
            this.chooseLastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.chooseLastNameLabel.TabIndex = 30;
            this.chooseLastNameLabel.Text = "Nazwisko: ";
            // 
            // chooseFirstNameLabel
            // 
            this.chooseFirstNameLabel.AutoSize = true;
            this.chooseFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseFirstNameLabel.Location = new System.Drawing.Point(47, 80);
            this.chooseFirstNameLabel.Name = "chooseFirstNameLabel";
            this.chooseFirstNameLabel.Size = new System.Drawing.Size(43, 21);
            this.chooseFirstNameLabel.TabIndex = 37;
            this.chooseFirstNameLabel.Text = "Imię:";
            // 
            // newClientLabel
            // 
            this.newClientLabel.AutoSize = true;
            this.newClientLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newClientLabel.Location = new System.Drawing.Point(33, 26);
            this.newClientLabel.Name = "newClientLabel";
            this.newClientLabel.Size = new System.Drawing.Size(294, 30);
            this.newClientLabel.TabIndex = 29;
            this.newClientLabel.Text = "Modyfikowanie danych klienta";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(182, 333);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 49;
            // 
            // ModifyClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 445);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmModifyButton);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(this.houseNumberTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.houseApartmentNumberLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.chooseTelephoneNumberLabel);
            this.Controls.Add(this.chooseLastNameLabel);
            this.Controls.Add(this.chooseFirstNameLabel);
            this.Controls.Add(this.newClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyClientForm";
            this.ShowInTaskbar = false;
            this.Text = "Modyfikowanie danych klienta";
            this.Load += new System.EventHandler(this.ModifyClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button confirmModifyButton;
        private TextBox streetTextBox;
        private TextBox cityTextBox;
        private TextBox emailTextBox;
        private TextBox apartmentNumberTextBox;
        private TextBox houseNumberTextBox;
        private TextBox telephoneTextBox;
        private TextBox lastNameTextBox;
        private TextBox postalCodeTextBox;
        private TextBox firstNameTextBox;
        private Label postalCodeLabel;
        private Label streetLabel;
        private Label emailLabel;
        private Label houseApartmentNumberLabel;
        private Label cityLabel;
        private Label chooseTelephoneNumberLabel;
        private Label chooseLastNameLabel;
        private Label chooseFirstNameLabel;
        private Label newClientLabel;
        private Label errorLabel;
    }
}