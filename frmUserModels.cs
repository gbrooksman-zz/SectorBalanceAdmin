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
    public partial class frmUserModels : Form
    {
        private Guid userId;

        public frmUserModels(Guid _id)
        {
            InitializeComponent();

            userId = _id;
        }

        private void FrmUserModels_Load(object sender, EventArgs e)
        {
            lvUserModels.View = View.Details;
            lvUserModels.GridLines = true;
            lvUserModels.FullRowSelect = true;

            lvUserModels.Columns.Add("Symbol", 50);
            lvUserModels.Columns.Add("Name", 200);
            lvUserModels.Columns.Add("Percent", 100); 
        }
    }
}
