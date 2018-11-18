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
            DataAccess.Init();

            pbMain.Minimum = 0;
            pbMain.Maximum = 100;

            chartQuotes.Visible = false;
            chartQuotes.Height = (int)(this.Height * .8);
            chartQuotes.Width = (int)(this.Width * .75);
            chartQuotes.Top = 60;
            chartQuotes.Left = 250;

            rtbAnalysis.Visible = false;
            rtbAnalysis.Height = (int)(this.Height * .8);
            rtbAnalysis.Width = (int)(this.Width * .75);
            rtbAnalysis.Top = 60;
            rtbAnalysis.Left = 250;

            dtpStart.Value = DateTime.Now.AddYears(-5);
            dtpStop.Value = DateTime.Now;

            ActiveList.Symbols.ForEach(s => { lbSymbols.Items.Add(s.Name); });

            UpdateLastQuoteDate();

            this.Refresh();
        }
       
        private void btnGetQuotes_Click(object sender, EventArgs e)
        {
            DateTime date = DataAccess.GetMaxDate().Date;
            pbMain.Value = 0;
            pbMain.Visible = true;
            ActiveList.Symbols.ForEach(s => { pbMain.Value = pbMain.Value + 10; DataAccess.GetDateQuote(s.Symbol, date); });
            UpdateLastQuoteDate();
            pbMain.Visible = false;

            this.Refresh();
        }

        private void UpdateLastQuoteDate()
        {           
            txtLastDate.Text = DataAccess.GetMaxDate().Date.ToShortDateString();
        }

        private void btnDisplayCharts(object sender, EventArgs e)
        {
            rtbAnalysis.Visible = false;
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
            List<Quote> xQuotes = DataAccess.LookupAllQuotes(symbol, startDate, endDate);
            chartQuotes.Series.Add(name);
            chartQuotes.Series[name].ChartType = SeriesChartType.Line;
            
            decimal firstPrice = 0;
            if (rbRelative.Checked)
            {
                Quote firstQuote = xQuotes.Where(q => q.Date.Date == startDate.AddDays(1).Date).FirstOrDefault();
                if (firstQuote == null)
                {
                    firstQuote = xQuotes.Where(q => q.Date.Date == startDate.AddDays(2).Date).FirstOrDefault();
                }
                if (firstQuote == null)
                {
                    firstQuote = xQuotes.Where(q => q.Date.Date == startDate.AddDays(3).Date).FirstOrDefault();
                }
                firstPrice = firstQuote.Price;
            }

            xQuotes.ForEach(q =>
            {
                chartQuotes.Series[name].Points.AddXY(0, q.Price - firstPrice);
            });
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
            ClearSymbolsListBox();
        }

        private void ClearSymbolsListBox()
        {
            lbSymbols.SelectedItems.Clear();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            chartQuotes.Visible = false;

            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpStop.Value;

            rtbAnalysis.Visible = true;
        }
    }
}
