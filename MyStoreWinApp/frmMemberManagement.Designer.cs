namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            txtMemberId = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblName = new Label();
            lblMemberID = new Label();
            lblCountry = new Label();
            lblPassword = new Label();
            lblCity = new Label();
            lblEmail = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dgvMemberList = new DataGridView();
            btnFilter = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cboCountryFilter = new ComboBox();
            cboCityFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboCountry = new ComboBox();
            cboCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 23);
            txtName.TabIndex = 0;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(160, 20);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(171, 23);
            txtMemberId.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(441, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 23);
            txtPassword.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(62, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(87, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Member Name";
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Location = new Point(62, 23);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(66, 15);
            lblMemberID.TabIndex = 1;
            lblMemberID.Text = "Member ID";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(378, 23);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "Country";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(378, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(378, 68);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 1;
            lblCity.Text = "City";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(62, 114);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(186, 249);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Insert";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(476, 249);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(335, 249);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(62, 288);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(605, 150);
            dgvMemberList.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(476, 202);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(476, 158);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(160, 158);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(298, 23);
            txtSearch.TabIndex = 10;
         
            // 
            // cboCountryFilter
            // 
            cboCountryFilter.FormattingEnabled = true;
            cboCountryFilter.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Austrian Empire*", "Azerbaijan", "Baden*", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Bavaria*", "Belarus", "Belgium", "Belize", "Benin (Dahomey)", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Brunswick and Lüneburg", "Bulgaria", "Burkina Faso (Upper Volta)", "Burma", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Cayman Islands, The", "Central African Republic", "Central American Federation*", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo Free State, The*", "Costa Rica", "Cote d’Ivoire (Ivory Coast)", "Croatia", "Cuba", "Cyprus", "Czechia", "Czechoslovakia", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Duchy of Parma, The*", "East Germany (German Democratic Republic)*", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Federal Government of Germany (1848-49)*", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Grand Duchy of Tuscany, The*", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Hanover*", "Hanseatic Republics*", "Hawaii*", "Hesse*", "Holy See", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kingdom of Serbia/Yugoslavia*", "Kiribati", "Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Lew Chew (Loochoo)*", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mecklenburg-Schwerin*", "Mecklenburg-Strelitz*", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nassau*", "Nauru", "Nepal", "Netherlands, The", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North German Confederation*", "North German Union*", "North Macedonia", "Norway", "Oldenburg*", "Oman", "Orange Free State*", "Pakistan", "Palau", "Panama", "Papal States*", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Piedmont-Sardinia*", "Poland", "Portugal", "Qatar", "Republic of Genoa*", "Republic of Korea (South Korea)", "Republic of the Congo", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Schaumburg-Lippe*", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands, The", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Texas*", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Two Sicilies*", "Uganda", "Ukraine", "Union of Soviet Socialist Republics*", "United Arab Emirates, The", "United Kingdom, The", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Württemberg*", "Yemen", "Zambia", "Zimbabwe" });
            cboCountryFilter.Location = new Point(160, 202);
            cboCountryFilter.Name = "cboCountryFilter";
            cboCountryFilter.Size = new Size(125, 23);
            cboCountryFilter.TabIndex = 9;
            // 
            // cboCityFilter
            // 
            cboCityFilter.FormattingEnabled = true;
            cboCityFilter.Items.AddRange(new object[] { "Bac Lieu", "Ben Thuy", "Ben Tre", "Bien Hoa", "Buon Me Thuot", "Cam Ranh", "Can Tho", "Cao Lanh", "Cho Lon", "Con Son", "Da Lat", "Da Nang", "Ha Long", "Hai Duong", "Haiphong", "Hanoi", "Ho Chi Minh City", "Hoa Binh", "Hue", "Kon Tum", "Lao Cai", "Long Xuyen", "My Tho", "Nam Dinh", "Nha Trang", "Phan Thiet", "Pleiku", "Quang Ngai", "Qui Nhon", "Rach Gia", "Sa Dec", "Tay Ninh", "Thai Binh", "Thai Nguyen", "Thanh Hoa", "Thu Dau Mot", "Tuy Hoa", "Vinh", "Vinh Long", "Vung Tau" });
            cboCityFilter.Location = new Point(335, 202);
            cboCityFilter.Name = "cboCityFilter";
            cboCityFilter.Size = new Size(123, 23);
            cboCityFilter.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 205);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 12;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 206);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 12;
            label2.Text = "Country";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(441, 20);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(172, 23);
            cboCountry.TabIndex = 13;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Location = new Point(441, 65);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(172, 23);
            cboCity.TabIndex = 13;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(cboCity);
            Controls.Add(cboCountry);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(cboCityFilter);
            Controls.Add(cboCountryFilter);
            Controls.Add(btnSearch);
            Controls.Add(btnFilter);
            Controls.Add(dgvMemberList);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(lblMemberID);
            Controls.Add(lblEmail);
            Controls.Add(lblCity);
            Controls.Add(lblPassword);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
            Controls.Add(txtMemberId);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtMemberId;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblName;
        private Label lblMemberID;
        private Label lblCountry;
        private Label lblPassword;
        private Label lblCity;
        private Label lblEmail;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnLoad;
        private DataGridView dgvMemberList;
        private Button btnFilter;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cboCountryFilter;
        private ComboBox cboCityFilter;
        private Label label1;
        private Label label2;
        private ComboBox cboCountry;
        private ComboBox cboCity;
    }
}