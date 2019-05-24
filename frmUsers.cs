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

            lvUsers.Columns.Add("UserName", 100);
            lvUsers.Columns.Add("Active?", 100);
            lvUsers.Columns.Add("Created", 200);
            lvUsers.Columns.Add("Updated", 200);

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
    }
}
