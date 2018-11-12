namespace QuoteTool
{
    partial class frmMsin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbSymbols = new System.Windows.Forms.ListBox();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnGetQuotes = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.chartQuotes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.lblStatrDate = new System.Windows.Forms.Label();
            this.lblStopDate = new System.Windows.Forms.Label();
            this.btnClearItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 32);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Fetch Historical Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnFetchQuotes);
            // 
            // lbSymbols
            // 
            this.lbSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSymbols.FormattingEnabled = true;
            this.lbSymbols.ItemHeight = 20;
            this.lbSymbols.Location = new System.Drawing.Point(12, 56);
            this.lbSymbols.Name = "lbSymbols";
            this.lbSymbols.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSymbols.Size = new System.Drawing.Size(196, 224);
            this.lbSymbols.TabIndex = 1;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbMain.Location = new System.Drawing.Point(0, 477);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1117, 23);
            this.pbMain.TabIndex = 2;
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(618, 12);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(196, 32);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearDataClick);
            // 
            // btnGetQuotes
            // 
            this.btnGetQuotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetQuotes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuotes.Location = new System.Drawing.Point(416, 12);
            this.btnGetQuotes.Name = "btnGetQuotes";
            this.btnGetQuotes.Size = new System.Drawing.Size(196, 32);
            this.btnGetQuotes.TabIndex = 4;
            this.btnGetQuotes.Text = "Update Quotes";
            this.btnGetQuotes.UseVisualStyleBackColor = false;
            this.btnGetQuotes.Click += new System.EventHandler(this.btnGetQuotes_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCharts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharts.Location = new System.Drawing.Point(214, 12);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(196, 32);
            this.btnCharts.TabIndex = 5;
            this.btnCharts.Text = "Display Chart(s)";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += new System.EventHandler(this.btnDisplayCharts);
            // 
            // chartQuotes
            // 
            this.chartQuotes.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chartQuotes.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartQuotes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuotes.Legends.Add(legend1);
            this.chartQuotes.Location = new System.Drawing.Point(232, 56);
            this.chartQuotes.Name = "chartQuotes";
            this.chartQuotes.Size = new System.Drawing.Size(810, 351);
            this.chartQuotes.TabIndex = 6;
            this.chartQuotes.Text = "chart1";
            this.chartQuotes.Visible = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(12, 358);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(196, 26);
            this.dtpStart.TabIndex = 7;
            // 
            // dtpStop
            // 
            this.dtpStop.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(12, 420);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(196, 26);
            this.dtpStop.TabIndex = 8;
            // 
            // lblStatrDate
            // 
            this.lblStatrDate.AutoSize = true;
            this.lblStatrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatrDate.Location = new System.Drawing.Point(12, 335);
            this.lblStatrDate.Name = "lblStatrDate";
            this.lblStatrDate.Size = new System.Drawing.Size(83, 20);
            this.lblStatrDate.TabIndex = 9;
            this.lblStatrDate.Text = "Start Date";
            // 
            // lblStopDate
            // 
            this.lblStopDate.AutoSize = true;
            this.lblStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopDate.Location = new System.Drawing.Point(12, 397);
            this.lblStopDate.Name = "lblStopDate";
            this.lblStopDate.Size = new System.Drawing.Size(77, 20);
            this.lblStopDate.TabIndex = 10;
            this.lblStopDate.Text = "End Date";
            // 
            // btnClearItems
            // 
            this.btnClearItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearItems.Location = new System.Drawing.Point(12, 284);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(196, 30);
            this.btnClearItems.TabIndex = 11;
            this.btnClearItems.Text = "Clear Selected";
            this.btnClearItems.UseVisualStyleBackColor = false;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // frmMsin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 500);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.lblStopDate);
            this.Controls.Add(this.lblStatrDate);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chartQuotes);
            this.Controls.Add(this.btnCharts);
            this.Controls.Add(this.btnGetQuotes);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.lbSymbols);
            this.Controls.Add(this.btnUpdate);
            this.DoubleBuffered = true;
            this.Name = "frmMsin";
            this.Text = "Quote Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMsin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lbSymbols;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnGetQuotes;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuotes;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Label lblStatrDate;
        private System.Windows.Forms.Label lblStopDate;
        private System.Windows.Forms.Button btnClearItems;
    }
}

