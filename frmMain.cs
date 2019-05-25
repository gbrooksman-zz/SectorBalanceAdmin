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

        private List<Equity> equityList = new List<Equity>();

        private void FrmMsin_Load(object sender, EventArgs e)
        {
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

            equityList = DataAccess.GetEquityList();

            equityList.ForEach(s => { lbSymbols.Items.Add(s.Symbol); });

            UpdateLastQuoteDate();

            this.Refresh();
        }       
       

        private void UpdateLastQuoteDate()
        {           
            txtLastDate.Text = DataAccess.GetMaxDate().Date.ToShortDateString();
        }

        private void BtnDisplayCharts(object sender, EventArgs e)
        {
            rtbAnalysis.Visible = false;
            chartQuotes.Series.Clear();

            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpStop.Value;

            foreach (var item in lbSymbols.SelectedItems)
            {
                DataRowView drwItem = item as DataRowView;
                List<Equity> equityList = DataAccess.GetEquityList();
                var quoteItem = equityList.Where(q => q.Symbol == item.ToString()).First();
                RenderSeries(quoteItem.Symbol, startDate, endDate, quoteItem.SymbolName);
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


        private void RenderRateOfChangeSeries(string symbol, DateTime startDate, DateTime endDate, string name)
        {
            List<Quote> xQuotes = DataAccess.LookupAllQuotes(symbol, startDate, endDate);
            chartQuotes.Series.Add(name);
            chartQuotes.Series[name].ChartType = SeriesChartType.Line;

            decimal firstRate = 0;
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
                firstRate = firstQuote.RateOfChange;
            }

            xQuotes.ForEach(q =>
            {
                if ((q.RateOfChange - firstRate) != 0)
                {
                    chartQuotes.Series[name].Points.AddXY(0, q.RateOfChange - firstRate);
                }
            });

        }

        private void ClearSymbolsListBox()
        {
            lbSymbols.SelectedItems.Clear();
        }



        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            rtbAnalysis.Visible = false;
            chartQuotes.Series.Clear();

            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpStop.Value;

            foreach (var item in lbSymbols.SelectedItems)
            {
                DataRowView drwItem = item as DataRowView;
                List<Equity> equityList = DataAccess.GetEquityList();

                var quoteItem = equityList.Where(q => q.Symbol == item.ToString()).First();
                RenderRateOfChangeSeries(quoteItem.Symbol, startDate, endDate, quoteItem.SymbolName);
            }

            chartQuotes.Visible = true;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.Show();
        }

        private void BtnClearItems_Click_1(object sender, EventArgs e)
        {
            ClearSymbolsListBox();
        }
    }
}
