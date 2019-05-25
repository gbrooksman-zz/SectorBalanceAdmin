using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuoteTool.Managers;
using QuoteTool.Models;

namespace QuoteTool
{
    public partial class frmAdmin : Form
    {

        int equityCount = 0;
        int equityFactor = 0;

        List<Equity> equityList = new List<Equity>();

        public frmAdmin()
        {
            InitializeComponent();

            equityCount = DataAccess.GetEquityCount();

            if (equityCount > 0) equityFactor = 100 / equityCount;

            equityList = DataAccess.GetEquityList();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnGetQuotes_Click(object sender, EventArgs e)
        {
            DateTime date = DataAccess.GetMaxDate().Date;
            pbMain.Value = 0;
            pbMain.Visible = true;

            equityList.ForEach(_ => { pbMain.Value += equityFactor; DataAccess.AddQuoteForDate(_.Symbol, date); });

            UpdateLastQuoteDate();
            pbMain.Visible = false;

            this.Refresh();
        }

        private void UpdateLastQuoteDate()
        {
           // txtLastDate.Text = DataAccess.GetMaxDate().Date.ToShortDateString();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            pbMain.Minimum = 0;
            pbMain.Maximum = 100;

            List<Equity> equityList = DataAccess.GetEquityList();
            lvEquities.View = View.Details;
            lvEquities.GridLines = true;
            lvEquities.FullRowSelect = true;

            lvEquities.Columns.Add("Symbol", 50);
            lvEquities.Columns.Add("Name", 300);
            lvEquities.Columns.Add("Created", 100);
            lvEquities.Columns.Add("Updated", 100);

            equityList.ForEach(_ =>
            {
                ListViewItem itm;
                string[] arr = new string[4];
                arr[0] = _.Symbol;
                arr[1] = _.SymbolName;
                arr[2] = _.CreatedAt.ToShortDateString();
                arr[3] = _.UpdatedAt.ToShortDateString();
                itm = new ListViewItem(arr);
                lvEquities.Items.Add(itm);
            });
        }
                


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }


        private void BtnClearDataClick(object sender, EventArgs e)
        {
            pbMain.Value = 0;
            pbMain.Visible = true;
            DataAccess.DeleteAllQuotes();
            pbMain.Value = 100;
            pbMain.Visible = false;
        }


        private void BtnFetchQuotes(object sender, EventArgs e)
        {
            pbMain.Value = 0;
            pbMain.Visible = true;

            equityList.ForEach(_ => { pbMain.Value += equityFactor; DataAccess.FetchFiveYearQuotes(_.Symbol); });

            pbMain.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmUsers f = new frmUsers();
            f.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            frmEquityGroups f = new frmEquityGroups();
            f.Show();
        }
    }
}
