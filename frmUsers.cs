using QuoteTool.Managers;
using QuoteTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteTool
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {            
            lvUsers.View = View.Details;
            lvUsers.GridLines = true;
            lvUsers.FullRowSelect = true;

            lvUsers.Columns.Add("UserName", 200);
            lvUsers.Columns.Add("Active?", 50);
            lvUsers.Columns.Add("Created", 100);
            lvUsers.Columns.Add("Updated", 100);

            LoadUserGrid();
        }

        private void LoadUserGrid()
        {
            lvUsers.Items.Clear();

            List<User> userList = DataAccess.GetAllUsers();

            userList.ForEach(_ =>
            {
                ListViewItem itm;
                string[] arr = new string[4];
                arr[0] = _.UserName;
                arr[1] = _.Active.ToString();
                arr[2] = _.CreatedAt.ToShortDateString();
                arr[3] = _.UpdatedAt.ToShortDateString();
                itm = new ListViewItem(arr);
                lvUsers.Items.Add(itm);
            });
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            bool isUpdate = Guid.TryParse(txtUserId.Text, out Guid theGuid);

            if (isUpdate)
            {
                User user = new User
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Id = Guid.Parse(txtUserId.Text),
                    Active = chkActive.Checked
                };

                DataAccess.UpdateUser(user);
               
            }
            else
            {
                User user = new User
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Active = chkActive.Checked
                };

                DataAccess.AddUser(user);
            }

            LoadUserGrid();
        }

        private void LvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 1)
            {
                User user = DataAccess.GetUser(lvUsers.SelectedItems[0].Text);

                txtUserId.Text = user.Id.ToString();
                txtUserName.Text = user.UserName;
                txtPassword.Text = user.Password;
                chkActive.Checked = user.Active;
            }
        }

        private void BtnUserModels_Click(object sender, EventArgs e)
        {
            frmUserModels f = new frmUserModels(Guid.Parse(txtUserId.Text));
            f.Show();
        }
    }
}
