using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public bool InsertOrUpdate { get; set; }
        public Member member { get; set; }
        public IMemberRepository memberRepository = new MemberRepository();

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 221;
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = member.Id.ToString();
                txtName.Text = member.Name.ToString();
                txtEmail.Text = member.Email.ToString();
                txtPassword.Text = member.Password.ToString();
                cboCity.Text = member.City.ToString();
                cboCountry.Text = member.Country.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    Id = txtMemberID.Text,
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text,
                };
                if (InsertOrUpdate == true)
                {
                    memberRepository.Update(member);
                }
                else
                {
                    try
                    {
                        memberRepository.Create(member);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Member" : "Update a member");
            }
        }
    }
}
