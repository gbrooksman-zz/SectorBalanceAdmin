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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbSymbols = new System.Windows.Forms.ListBox();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnGetQuotes = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
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
            this.lbSymbols.Size = new System.Drawing.Size(196, 224);
            this.lbSymbols.TabIndex = 1;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbMain.Location = new System.Drawing.Point(0, 427);
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
            // frmMsin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lbSymbols;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnGetQuotes;
        private System.Windows.Forms.Button btnCharts;
    }
}

