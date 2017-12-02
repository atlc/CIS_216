namespace Assignment01
{
    partial class Rentals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rentals));
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressStreetTextBox = new System.Windows.Forms.TextBox();
            this.AddressCityTextBox = new System.Windows.Forms.TextBox();
            this.AddressStateTextBox = new System.Windows.Forms.TextBox();
            this.AddressZIPTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.DriversLicenseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreditCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CarSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.SizeLuxuryRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeMidsizeRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeCompactRadioButton = new System.Windows.Forms.RadioButton();
            this.DiscountsGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountInsuranceAcctRadioButton = new System.Windows.Forms.RadioButton();
            this.DiscountCorporateRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OdometerEndingTextBox = new System.Windows.Forms.TextBox();
            this.OdometerBeginningTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DaysRentedTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CarSizeGroupBox.SuspendLayout();
            this.DiscountsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(454, 499);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(112, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "C&lose";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "C&ustomer Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(195, 40);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(338, 26);
            this.CustomerNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Address";
            // 
            // AddressStreetTextBox
            // 
            this.AddressStreetTextBox.Location = new System.Drawing.Point(195, 83);
            this.AddressStreetTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressStreetTextBox.Name = "AddressStreetTextBox";
            this.AddressStreetTextBox.Size = new System.Drawing.Size(338, 26);
            this.AddressStreetTextBox.TabIndex = 4;
            // 
            // AddressCityTextBox
            // 
            this.AddressCityTextBox.Location = new System.Drawing.Point(195, 123);
            this.AddressCityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressCityTextBox.Name = "AddressCityTextBox";
            this.AddressCityTextBox.Size = new System.Drawing.Size(174, 26);
            this.AddressCityTextBox.TabIndex = 5;
            // 
            // AddressStateTextBox
            // 
            this.AddressStateTextBox.Location = new System.Drawing.Point(380, 123);
            this.AddressStateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressStateTextBox.Name = "AddressStateTextBox";
            this.AddressStateTextBox.Size = new System.Drawing.Size(64, 26);
            this.AddressStateTextBox.TabIndex = 6;
            // 
            // AddressZIPTextBox
            // 
            this.AddressZIPTextBox.Location = new System.Drawing.Point(454, 123);
            this.AddressZIPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressZIPTextBox.Name = "AddressZIPTextBox";
            this.AddressZIPTextBox.Size = new System.Drawing.Size(79, 26);
            this.AddressZIPTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "&Phone";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(195, 165);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(174, 26);
            this.PhoneNumberTextBox.TabIndex = 9;
            // 
            // DriversLicenseTextBox
            // 
            this.DriversLicenseTextBox.Location = new System.Drawing.Point(196, 208);
            this.DriversLicenseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DriversLicenseTextBox.Name = "DriversLicenseTextBox";
            this.DriversLicenseTextBox.Size = new System.Drawing.Size(174, 26);
            this.DriversLicenseTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Driver\'s Lice&nse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "&Type of Credit Card";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "C&redit Card Number";
            // 
            // CreditCardNumberTextBox
            // 
            this.CreditCardNumberTextBox.Location = new System.Drawing.Point(195, 332);
            this.CreditCardNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreditCardNumberTextBox.Name = "CreditCardNumberTextBox";
            this.CreditCardNumberTextBox.Size = new System.Drawing.Size(180, 26);
            this.CreditCardNumberTextBox.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "American Express"});
            this.listBox1.Location = new System.Drawing.Point(195, 251);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 64);
            this.listBox1.TabIndex = 16;
            // 
            // CarSizeGroupBox
            // 
            this.CarSizeGroupBox.Controls.Add(this.SizeLuxuryRadioButton);
            this.CarSizeGroupBox.Controls.Add(this.SizeMidsizeRadioButton);
            this.CarSizeGroupBox.Controls.Add(this.SizeCompactRadioButton);
            this.CarSizeGroupBox.Location = new System.Drawing.Point(30, 391);
            this.CarSizeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarSizeGroupBox.Name = "CarSizeGroupBox";
            this.CarSizeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarSizeGroupBox.Size = new System.Drawing.Size(165, 143);
            this.CarSizeGroupBox.TabIndex = 17;
            this.CarSizeGroupBox.TabStop = false;
            this.CarSizeGroupBox.Text = "Select A Car Size";
            // 
            // SizeLuxuryRadioButton
            // 
            this.SizeLuxuryRadioButton.AutoSize = true;
            this.SizeLuxuryRadioButton.Location = new System.Drawing.Point(9, 102);
            this.SizeLuxuryRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SizeLuxuryRadioButton.Name = "SizeLuxuryRadioButton";
            this.SizeLuxuryRadioButton.Size = new System.Drawing.Size(80, 24);
            this.SizeLuxuryRadioButton.TabIndex = 2;
            this.SizeLuxuryRadioButton.TabStop = true;
            this.SizeLuxuryRadioButton.Text = "Lu&xury";
            this.SizeLuxuryRadioButton.UseVisualStyleBackColor = true;
            // 
            // SizeMidsizeRadioButton
            // 
            this.SizeMidsizeRadioButton.AutoSize = true;
            this.SizeMidsizeRadioButton.Location = new System.Drawing.Point(9, 66);
            this.SizeMidsizeRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SizeMidsizeRadioButton.Name = "SizeMidsizeRadioButton";
            this.SizeMidsizeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.SizeMidsizeRadioButton.TabIndex = 1;
            this.SizeMidsizeRadioButton.TabStop = true;
            this.SizeMidsizeRadioButton.Text = "Mid-Si&zed";
            this.SizeMidsizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SizeCompactRadioButton
            // 
            this.SizeCompactRadioButton.AutoSize = true;
            this.SizeCompactRadioButton.Checked = true;
            this.SizeCompactRadioButton.Location = new System.Drawing.Point(9, 29);
            this.SizeCompactRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SizeCompactRadioButton.Name = "SizeCompactRadioButton";
            this.SizeCompactRadioButton.Size = new System.Drawing.Size(98, 24);
            this.SizeCompactRadioButton.TabIndex = 0;
            this.SizeCompactRadioButton.TabStop = true;
            this.SizeCompactRadioButton.Text = "Co&mpact";
            this.SizeCompactRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiscountsGroupBox
            // 
            this.DiscountsGroupBox.Controls.Add(this.DiscountInsuranceAcctRadioButton);
            this.DiscountsGroupBox.Controls.Add(this.DiscountCorporateRadioButton);
            this.DiscountsGroupBox.Location = new System.Drawing.Point(204, 391);
            this.DiscountsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscountsGroupBox.Name = "DiscountsGroupBox";
            this.DiscountsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscountsGroupBox.Size = new System.Drawing.Size(198, 143);
            this.DiscountsGroupBox.TabIndex = 18;
            this.DiscountsGroupBox.TabStop = false;
            this.DiscountsGroupBox.Text = "Discounts";
            // 
            // DiscountInsuranceAcctRadioButton
            // 
            this.DiscountInsuranceAcctRadioButton.AutoSize = true;
            this.DiscountInsuranceAcctRadioButton.Location = new System.Drawing.Point(10, 66);
            this.DiscountInsuranceAcctRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscountInsuranceAcctRadioButton.Name = "DiscountInsuranceAcctRadioButton";
            this.DiscountInsuranceAcctRadioButton.Size = new System.Drawing.Size(168, 24);
            this.DiscountInsuranceAcctRadioButton.TabIndex = 1;
            this.DiscountInsuranceAcctRadioButton.TabStop = true;
            this.DiscountInsuranceAcctRadioButton.Text = "&Insurance Account";
            this.DiscountInsuranceAcctRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiscountCorporateRadioButton
            // 
            this.DiscountCorporateRadioButton.AutoSize = true;
            this.DiscountCorporateRadioButton.Location = new System.Drawing.Point(10, 29);
            this.DiscountCorporateRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscountCorporateRadioButton.Name = "DiscountCorporateRadioButton";
            this.DiscountCorporateRadioButton.Size = new System.Drawing.Size(105, 24);
            this.DiscountCorporateRadioButton.TabIndex = 0;
            this.DiscountCorporateRadioButton.TabStop = true;
            this.DiscountCorporateRadioButton.Text = "Corpor&ate";
            this.DiscountCorporateRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OdometerEndingTextBox);
            this.groupBox1.Controls.Add(this.OdometerBeginningTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DaysRentedTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(75, 561);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(482, 154);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // OdometerEndingTextBox
            // 
            this.OdometerEndingTextBox.Location = new System.Drawing.Point(177, 106);
            this.OdometerEndingTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OdometerEndingTextBox.Name = "OdometerEndingTextBox";
            this.OdometerEndingTextBox.Size = new System.Drawing.Size(148, 26);
            this.OdometerEndingTextBox.TabIndex = 5;
            // 
            // OdometerBeginningTextBox
            // 
            this.OdometerBeginningTextBox.Location = new System.Drawing.Point(178, 66);
            this.OdometerBeginningTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OdometerBeginningTextBox.Name = "OdometerBeginningTextBox";
            this.OdometerBeginningTextBox.Size = new System.Drawing.Size(148, 26);
            this.OdometerBeginningTextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "&Ending Odometer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "&Beginning Odometer";
            // 
            // DaysRentedTextBox
            // 
            this.DaysRentedTextBox.Location = new System.Drawing.Point(218, 25);
            this.DaysRentedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DaysRentedTextBox.Name = "DaysRentedTextBox";
            this.DaysRentedTextBox.Size = new System.Drawing.Size(109, 26);
            this.DaysRentedTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Number of &Days Rented";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(454, 446);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(112, 35);
            this.CalculateButton.TabIndex = 20;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(434, 397);
            this.AmountDueTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(148, 26);
            this.AmountDueTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 372);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Amount Due:";
            // 
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 728);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DiscountsGroupBox);
            this.Controls.Add(this.CarSizeGroupBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CreditCardNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DriversLicenseTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressZIPTextBox);
            this.Controls.Add(this.AddressStateTextBox);
            this.Controls.Add(this.AddressCityTextBox);
            this.Controls.Add(this.AddressStreetTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rentals";
            this.Text = "Rentals";
            this.CarSizeGroupBox.ResumeLayout(false);
            this.CarSizeGroupBox.PerformLayout();
            this.DiscountsGroupBox.ResumeLayout(false);
            this.DiscountsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressStreetTextBox;
        private System.Windows.Forms.TextBox AddressCityTextBox;
        private System.Windows.Forms.TextBox AddressStateTextBox;
        private System.Windows.Forms.TextBox AddressZIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox DriversLicenseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreditCardNumberTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox CarSizeGroupBox;
        private System.Windows.Forms.RadioButton SizeLuxuryRadioButton;
        private System.Windows.Forms.RadioButton SizeMidsizeRadioButton;
        private System.Windows.Forms.RadioButton SizeCompactRadioButton;
        private System.Windows.Forms.GroupBox DiscountsGroupBox;
        private System.Windows.Forms.RadioButton DiscountInsuranceAcctRadioButton;
        private System.Windows.Forms.RadioButton DiscountCorporateRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OdometerBeginningTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DaysRentedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OdometerEndingTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.Label label10;
    }
}