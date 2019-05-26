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
            this.lbSymbols = new System.Windows.Forms.ListBox();
            this.btnCharts = new System.Windows.Forms.Button();
            this.chartQuotes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.lblStatrDate = new System.Windows.Forms.Label();
            this.lblStopDate = new System.Windows.Forms.Label();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.rbAbsolute = new System.Windows.Forms.RadioButton();
            this.rbRelative = new System.Windows.Forms.RadioButton();
            this.txtLastDate = new System.Windows.Forms.TextBox();
            this.lblLastFetch = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.rtbAnalysis = new System.Windows.Forms.RichTextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuotes)).BeginInit();
            this.SuspendLayout();
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
            // btnCharts
            // 
            this.btnCharts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCharts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharts.Location = new System.Drawing.Point(214, 12);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(196, 32);
            this.btnCharts.TabIndex = 5;
            this.btnCharts.Text = "Price Chart";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += new System.EventHandler(this.BtnDisplayCharts);
            // 
            // chartQuotes
            // 
            this.chartQuotes.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chartQuotes.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartQuotes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuotes.Legends.Add(legend1);
            this.chartQuotes.Location = new System.Drawing.Point(1053, 449);
            this.chartQuotes.Name = "chartQuotes";
            this.chartQuotes.Size = new System.Drawing.Size(43, 45);
            this.chartQuotes.TabIndex = 6;
            this.chartQuotes.Text = "chart1";
            this.chartQuotes.Visible = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(12, 397);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(196, 26);
            this.dtpStart.TabIndex = 7;
            // 
            // dtpStop
            // 
            this.dtpStop.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(12, 459);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(196, 26);
            this.dtpStop.TabIndex = 8;
            // 
            // lblStatrDate
            // 
            this.lblStatrDate.AutoSize = true;
            this.lblStatrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatrDate.Location = new System.Drawing.Point(12, 374);
            this.lblStatrDate.Name = "lblStatrDate";
            this.lblStatrDate.Size = new System.Drawing.Size(83, 20);
            this.lblStatrDate.TabIndex = 9;
            this.lblStatrDate.Text = "Start Date";
            // 
            // lblStopDate
            // 
            this.lblStopDate.AutoSize = true;
            this.lblStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopDate.Location = new System.Drawing.Point(12, 436);
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
            this.btnClearItems.Click += new System.EventHandler(this.BtnClearItems_Click_1);
            // 
            // rbAbsolute
            // 
            this.rbAbsolute.AutoSize = true;
            this.rbAbsolute.Checked = true;
            this.rbAbsolute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbsolute.Location = new System.Drawing.Point(12, 509);
            this.rbAbsolute.Name = "rbAbsolute";
            this.rbAbsolute.Size = new System.Drawing.Size(90, 24);
            this.rbAbsolute.TabIndex = 12;
            this.rbAbsolute.TabStop = true;
            this.rbAbsolute.Text = "Absolute";
            this.rbAbsolute.UseVisualStyleBackColor = true;
            // 
            // rbRelative
            // 
            this.rbRelative.AutoSize = true;
            this.rbRelative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRelative.Location = new System.Drawing.Point(12, 539);
            this.rbRelative.Name = "rbRelative";
            this.rbRelative.Size = new System.Drawing.Size(84, 24);
            this.rbRelative.TabIndex = 13;
            this.rbRelative.Text = "Relative";
            this.rbRelative.UseVisualStyleBackColor = true;
            // 
            // txtLastDate
            // 
            this.txtLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastDate.Location = new System.Drawing.Point(12, 599);
            this.txtLastDate.Name = "txtLastDate";
            this.txtLastDate.Size = new System.Drawing.Size(196, 26);
            this.txtLastDate.TabIndex = 14;
            // 
            // lblLastFetch
            // 
            this.lblLastFetch.AutoSize = true;
            this.lblLastFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFetch.Location = new System.Drawing.Point(13, 576);
            this.lblLastFetch.Name = "lblLastFetch";
            this.lblLastFetch.Size = new System.Drawing.Size(124, 20);
            this.lblLastFetch.TabIndex = 15;
            this.lblLastFetch.Text = "Last Fetch Date";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnalyze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Location = new System.Drawing.Point(12, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(196, 32);
            this.btnAnalyze.TabIndex = 16;
            this.btnAnalyze.Text = "Rate of Change";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // rtbAnalysis
            // 
            this.rtbAnalysis.Location = new System.Drawing.Point(244, 56);
            this.rtbAnalysis.Name = "rtbAnalysis";
            this.rtbAnalysis.Size = new System.Drawing.Size(100, 96);
            this.rtbAnalysis.TabIndex = 17;
            this.rtbAnalysis.Text = "";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(702, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(196, 32);
            this.btnAdmin.TabIndex = 18;
            this.btnAdmin.Text = "Admin Center";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmMsin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.rtbAnalysis);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lblLastFetch);
            this.Controls.Add(this.txtLastDate);
            this.Controls.Add(this.rbRelative);
            this.Controls.Add(this.rbAbsolute);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.lblStopDate);
            this.Controls.Add(this.lblStatrDate);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chartQuotes);
            this.Controls.Add(this.btnCharts);
            this.Controls.Add(this.lbSymbols);
            this.DoubleBuffered = true;
            this.Name = "frmMsin";
            this.Text = "Quote Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMsin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbSymbols;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuotes;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Label lblStatrDate;
        private System.Windows.Forms.Label lblStopDate;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.RadioButton rbAbsolute;
        private System.Windows.Forms.RadioButton rbRelative;
        private System.Windows.Forms.TextBox txtLastDate;
        private System.Windows.Forms.Label lblLastFetch;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox rtbAnalysis;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button1;
    }
}

