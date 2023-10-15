using BusinessObject;
using DataAccess;
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
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource bindingSource;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
        }

        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                member = GetMemberObject(),
                memberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }
        bool isLoad = true;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
            txtMemberId.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPassword.ReadOnly = true;
        }

        public void LoadMemberList()
        {
            var members = memberRepository.FindAll();

            bindingSource = new BindingSource();
            bindingSource.DataSource = members;
            txtMemberId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            cboCountry.DataBindings.Clear();
            cboCity.DataBindings.Clear();

            txtMemberId.DataBindings.Add("Text", bindingSource, "Id");
            txtName.DataBindings.Add("Text", bindingSource, "Name");
            txtEmail.DataBindings.Add("Text", bindingSource, "Email");
            txtPassword.DataBindings.Add("Text", bindingSource, "Password");
            cboCountry.DataBindings.Add("Text", bindingSource, "Country");
            cboCity.DataBindings.Add("Text", bindingSource, "City");
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = bindingSource;
            if (members.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        public Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    Id = txtMemberId.Text,
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add New Member",
                InsertOrUpdate = false,
                memberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.Delete(member.Id);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to delete");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var country = cboCountryFilter.Text;
            var city = cboCityFilter.Text;
            var result = memberRepository.FindByCountryAndCity(country, city);
            if (result != null)
            {
                dgvMemberList.DataSource = result;
            }
            else
            {
                MessageBox.Show("There's no member with the Country and City");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var members = memberRepository.FindAll();
            var resultList = new List<Member>();
            int count = 0;
            try
            {
                foreach (var member in members)
                {
                    if (member.Id.Equals(txtSearch.Text))
                    {
                        var result = memberRepository.FindById(txtSearch.Text);
                        resultList.Add(result);
                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = resultList;
                        count++;
                        break;
                    }
                    else if (member.Name.Equals(txtSearch.Text))
                    {
                        var resultName = memberRepository.FindByName(txtSearch.Text);
                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = resultName;
                        count++;
                        break;
                    }
                }
                if(count <= 0)
                {
                    MessageBox.Show("Cannot find any member", "FStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find any member", "FStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
