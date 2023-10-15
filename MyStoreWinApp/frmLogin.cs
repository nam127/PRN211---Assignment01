using Azure.Messaging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(txtEmail.Text);
            }
            catch (FormatException)
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(txtEmail, "Invalid Email");
            }
            if (isAuthenticated(txtEmail.Text, txtPass.Text) == true)
            {
                this.Hide();
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email or Password not correct");
            }
        }

        bool isAuthenticated(string email, string password)
        {
            IConfiguration config = configuration();
            string myEmail = config["MyAccount:Email"];
            string myPass = config["MyAccount:Password"];
            if (string.Equals(email, myEmail, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(password, myPass, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private IConfiguration configuration()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            return config;
        }
    }
}
