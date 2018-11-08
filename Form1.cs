using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuoteTool.Managers;
using QuoteTool.Models;

namespace QuoteTool
{
    public partial class frmMsin : Form
    {
        public frmMsin()
        {
            InitializeComponent();
        }

        private void frmMsin_Load(object sender, EventArgs e)
        {
            pbMain.Minimum = 0;
            pbMain.Maximum = 100;

            ActiveList.Symbols.ForEach(s => {lbSymbols.Items.Add(s.Name);});
        }

       
        private void btnGetQuotes_Click(object sender, EventArgs e)
        {
            pbMain.Value = 0;
            pbMain.Visible = true;
            ActiveList.Symbols.ForEach(s => { pbMain.Value = pbMain.Value + 10; DataAccess.GetDayQuote(s.Name); });
            pbMain.Visible = false;
        }

        private void btnDisplayCharts(object sender, EventArgs e)
        {

        }

        private void btnFetchQuotes(object sender, EventArgs e)
        {
            pbMain.Value = 0;
            pbMain.Visible = true;
            ActiveList.Symbols.ForEach(s => { pbMain.Value = pbMain.Value + 10; DataAccess.FetchFiveYearQuotes(s.Name); });
            pbMain.Visible = false;
        }

        private void btnClearDataClick(object sender, EventArgs e)
        {
            pbMain.Value = 0;
            pbMain.Visible = true;
            DataAccess.ClearData();
            pbMain.Value = 100;
            pbMain.Visible = false;
        }
    }
}
