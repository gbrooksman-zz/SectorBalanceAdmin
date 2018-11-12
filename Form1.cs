using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

            chartQuotes.Height = (int)(this.Height * .8);
            chartQuotes.Width = (int)(this.Width * .75);

            dtpStart.Value = DateTime.Now.AddYears(-5);
            dtpStop.Value = DateTime.Now;

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
            chartQuotes.Series.Clear();  

            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpStop.Value;

            foreach (var item in lbSymbols.SelectedItems)
            {
                DataRowView drwItem = item as DataRowView;
                var quoteItem = ActiveList.Symbols.Where(q => q.Name == item.ToString()).First();
                RenderSeries(quoteItem.Symbol, startDate, endDate, quoteItem.Name);
            }

            chartQuotes.Visible = true;
        }

        private void RenderSeries(string symbol, DateTime startDate, DateTime endDate, string name)
        {
            List<Quote> xQuotes = DataAccess.FetchAllQuotes(symbol, startDate, endDate);
            chartQuotes.Series.Add(name);
            chartQuotes.Series[name].ChartType = SeriesChartType.Line;
            //int y = 0;
            //int x = 0;
            //xQuotes.ForEach(q => 
            //{
            //    if (q.Date >= startDate.AddDays(y))
            //    {
            //        chartQuotes.Series[name].Points.AddXY(x, q.Price);
            //    }
            //    else
            //    {
            //        chartQuotes.Series[name].Points.AddXY(x, 0);
            //    }
            //    y++;
            //    x++;
            //});

            foreach (Quote q in xQuotes)
            {
                chartQuotes.Series[name].Points.AddXY(0, q.Price);
            }
        }

        private void btnFetchQuotes(object sender, EventArgs e)
        {
            pbMain.Value = 0;
            pbMain.Visible = true;
            ActiveList.Symbols.ForEach(s => { pbMain.Value = pbMain.Value + 10; DataAccess.FetchFiveYearQuotes(s.Symbol); });
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

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            lbSymbols.SelectedItems.Clear();
        }
    }
}
