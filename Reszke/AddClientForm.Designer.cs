namespace Reszke
{
    partial class AddClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.cancelClientAddButton = new System.Windows.Forms.Button();
            this.confirmClientAddButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.chooseLastNameLabel = new System.Windows.Forms.Label();
            this.chooseFirstNameLabel = new System.Windows.Forms.Label();
            this.newClientLabel = new System.Windows.Forms.Label();
            this.chooseTelephoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseApartmentNumberLabel = new System.Windows.Forms.Label();
            this.newClientErrorLabel = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelClientAddButton
            // 
            this.cancelClientAddButton.Location = new System.Drawing.Point(283, 363);
            this.cancelClientAddButton.Name = "cancelClientAddButton";
            this.cancelClientAddButton.Size = new System.Drawing.Size(93, 46);
            this.cancelClientAddButton.TabIndex = 10;
            this.cancelClientAddButton.Text = "Anuluj";
            this.cancelClientAddButton.UseVisualStyleBackColor = true;
            this.cancelClientAddButton.Click += new System.EventHandler(this.cancelClientAddButton_Click);
            // 
            // confirmClientAddButton
            // 
            this.confirmClientAddButton.Location = new System.Drawing.Point(176, 363);
            this.confirmClientAddButton.Name = "confirmClientAddButton";
            this.confirmClientAddButton.Size = new System.Drawing.Size(93, 46);
            this.confirmClientAddButton.TabIndex = 9;
            this.confirmClientAddButton.Text = "Dodaj";
            this.confirmClientAddButton.UseVisualStyleBackColor = true;
            this.confirmClientAddButton.Click += new System.EventHandler(this.confirmClientAddButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(27, 170);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(220, 23);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(27, 107);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 23);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // chooseLastNameLabel
            // 
            this.chooseLastNameLabel.AutoSize = true;
            this.chooseLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseLastNameLabel.Location = new System.Drawing.Point(41, 146);
            this.chooseLastNameLabel.Name = "chooseLastNameLabel";
            this.chooseLastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.chooseLastNameLabel.TabIndex = 23;
            this.chooseLastNameLabel.Text = "Nazwisko: ";
            // 
            // chooseFirstNameLabel
            // 
            this.chooseFirstNameLabel.AutoSize = true;
            this.chooseFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseFirstNameLabel.Location = new System.Drawing.Point(41, 83);
            this.chooseFirstNameLabel.Name = "chooseFirstNameLabel";
            this.chooseFirstNameLabel.Size = new System.Drawing.Size(43, 21);
            this.chooseFirstNameLabel.TabIndex = 24;
            this.chooseFirstNameLabel.Text = "Imię:";
            // 
            // newClientLabel
            // 
            this.newClientLabel.AutoSize = true;
            this.newClientLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newClientLabel.Location = new System.Drawing.Point(27, 29);
            this.newClientLabel.Name = "newClientLabel";
            this.newClientLabel.Size = new System.Drawing.Size(264, 30);
            this.newClientLabel.TabIndex = 22;
            this.newClientLabel.Text = "Dodawanie nowego klienta";
            // 
            // chooseTelephoneNumberLabel
            // 
            this.chooseTelephoneNumberLabel.AutoSize = true;
            this.chooseTelephoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseTelephoneNumberLabel.Location = new System.Drawing.Point(36, 210);
            this.chooseTelephoneNumberLabel.Name = "chooseTelephoneNumberLabel";
            this.chooseTelephoneNumberLabel.Size = new System.Drawing.Size(92, 21);
            this.chooseTelephoneNumberLabel.TabIndex = 23;
            this.chooseTelephoneNumberLabel.Text = "Nr telefonu:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(33, 271);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(105, 21);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Adres e-mail: ";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalCodeLabel.Location = new System.Drawing.Point(332, 83);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(114, 21);
            this.postalCodeLabel.TabIndex = 23;
            this.postalCodeLabel.Text = "Kod pocztowy: ";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(332, 146);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(101, 21);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "Miescowość: ";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(323, 170);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(201, 23);
            this.cityTextBox.TabIndex = 5;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLabel.Location = new System.Drawing.Point(332, 210);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(44, 21);
            this.streetLabel.TabIndex = 23;
            this.streetLabel.Text = "Ulica";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(323, 234);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(201, 23);
            this.streetTextBox.TabIndex = 6;
            // 
            // houseApartmentNumberLabel
            // 
            this.houseApartmentNumberLabel.AutoSize = true;
            this.houseApartmentNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.houseApartmentNumberLabel.Location = new System.Drawing.Point(332, 271);
            this.houseApartmentNumberLabel.Name = "houseApartmentNumberLabel";
            this.houseApartmentNumberLabel.Size = new System.Drawing.Size(167, 21);
            this.houseApartmentNumberLabel.TabIndex = 23;
            this.houseApartmentNumberLabel.Text = "Nr domu / mieszkania:";
            // 
            // newClientErrorLabel
            // 
            this.newClientErrorLabel.AutoSize = true;
            this.newClientErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newClientErrorLabel.Location = new System.Drawing.Point(168, 335);
            this.newClientErrorLabel.Name = "newClientErrorLabel";
            this.newClientErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.newClientErrorLabel.TabIndex = 30;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(323, 107);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(123, 23);
            this.postalCodeTextBox.TabIndex = 4;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(24, 234);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(123, 23);
            this.telephoneTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(24, 295);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 23);
            this.emailTextBox.TabIndex = 3;
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.Location = new System.Drawing.Point(323, 295);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(90, 23);
            this.houseNumberTextBox.TabIndex = 7;
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(434, 295);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(90, 23);
            this.apartmentNumberTextBox.TabIndex = 8;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 423);
            this.Controls.Add(this.newClientErrorLabel);
            this.Controls.Add(this.cancelClientAddButton);
            this.Controls.Add(this.confirmClientAddButton);
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
            this.Name = "AddClientForm";
            this.Text = "Dodawanie nowego klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelClientAddButton;
        private Button confirmClientAddButton;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label chooseLastNameLabel;
        private Label chooseFirstNameLabel;
        private Label newClientLabel;
        private Label chooseTelephoneNumberLabel;
        private Label emailLabel;
        private Label postalCodeLabel;
        private Label cityLabel;
        private TextBox cityTextBox;
        private Label streetLabel;
        private TextBox streetTextBox;
        private Label houseApartmentNumberLabel;
        private Label newClientErrorLabel;
        private TextBox postalCodeTextBox;
        private TextBox telephoneTextBox;
        private TextBox emailTextBox;
        private TextBox houseNumberTextBox;
        private TextBox apartmentNumberTextBox;
    }
}