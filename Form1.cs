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

            chartQuotes.Height = (int)(this.Height * .8);
            chartQuotes.Width = (int)(this.Width * .75);
            chartQuotes.Visible = true;

            DateTime startDate = DateTime.Parse("01/01/2014");
            DateTime endDate = DateTime.Parse("06/30/2018");

            RenderSeries("XLF", startDate, endDate);
            RenderSeries("XLE", startDate, endDate);
            RenderSeries("XLK", startDate, endDate);
            RenderSeries("XLU", startDate, endDate);
            RenderSeries("XLY", startDate, endDate);
            RenderSeries("XLB", startDate, endDate);

        }

        private void RenderSeries(string name, DateTime startDate, DateTime endDate)
        {
            List<Quote> xQuotes = DataAccess.FetchAllQuotes(name, startDate, endDate);
            chartQuotes.Series.Add(name);
            chartQuotes.Series[name].ChartType = SeriesChartType.Line;
            xQuotes.ForEach(q => 
            {
                int x = 0;
                chartQuotes.Series[name].Points.AddXY(x, q.Price);
            });
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
