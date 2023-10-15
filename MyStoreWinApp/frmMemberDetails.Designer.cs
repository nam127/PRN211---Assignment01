namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            txtName = new TextBox();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboCity = new ComboBox();
            cboCountry = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 0;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(122, 53);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(193, 23);
            txtMemberID.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(193, 23);
            txtPassword.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(240, 363);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(122, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 104);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Member ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 203);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 155);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 300);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 253);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 2;
            label6.Text = "City";
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Bac Lieu", "Ben Thuy", "Ben Tre", "Bien Hoa", "Buon Me Thuot", "Cam Ranh", "Can Tho", "Cao Lanh", "Cho Lon", "Con Son", "Da Lat", "Da Nang", "Ha Long", "Hai Duong", "Haiphong", "Hanoi", "Ho Chi Minh City", "Hoa Binh", "Hue", "Kon Tum", "Lao Cai", "Long Xuyen", "My Tho", "Nam Dinh", "Nha Trang", "Phan Thiet", "Pleiku", "Quang Ngai", "Qui Nhon", "Rach Gia", "Sa Dec", "Tay Ninh", "Thai Binh", "Thai Nguyen", "Thanh Hoa", "Thu Dau Mot", "Tuy Hoa", "Vinh", "Vinh Long", "Vung Tau" });
            cboCity.Location = new Point(122, 251);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(193, 23);
            cboCity.TabIndex = 3;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Austrian Empire*", "Azerbaijan", "Baden*", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Bavaria*", "Belarus", "Belgium", "Belize", "Benin (Dahomey)", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Brunswick and Lüneburg", "Bulgaria", "Burkina Faso (Upper Volta)", "Burma", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Cayman Islands, The", "Central African Republic", "Central American Federation*", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo Free State, The*", "Costa Rica", "Cote d’Ivoire (Ivory Coast)", "Croatia", "Cuba", "Cyprus", "Czechia", "Czechoslovakia", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Duchy of Parma, The*", "East Germany (German Democratic Republic)*", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Federal Government of Germany (1848-49)*", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Grand Duchy of Tuscany, The*", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Hanover*", "Hanseatic Republics*", "Hawaii*", "Hesse*", "Holy See", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kingdom of Serbia/Yugoslavia*", "Kiribati", "Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Lew Chew (Loochoo)*", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mecklenburg-Schwerin*", "Mecklenburg-Strelitz*", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nassau*", "Nauru", "Nepal", "Netherlands, The", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North German Confederation*", "North German Union*", "North Macedonia", "Norway", "Oldenburg*", "Oman", "Orange Free State*", "Pakistan", "Palau", "Panama", "Papal States*", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Piedmont-Sardinia*", "Poland", "Portugal", "Qatar", "Republic of Genoa*", "Republic of Korea (South Korea)", "Republic of the Congo", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Schaumburg-Lippe*", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands, The", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Texas*", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Two Sicilies*", "Uganda", "Ukraine", "Union of Soviet Socialist Republics*", "United Arab Emirates, The", "United Kingdom, The", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Württemberg*", "Yemen", "Zambia", "Zimbabwe" });
            cboCountry.Location = new Point(122, 297);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(193, 23);
            cboCountry.TabIndex = 3;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(cboCountry);
            Controls.Add(cboCity);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtMemberID);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "frmMemberDetails";
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboCity;
        private ComboBox cboCountry;
    }
}