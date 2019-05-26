namespace QuoteTool
{
    partial class frmAdmin
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
            this.btnGetQuotes = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.lblLastFetch = new System.Windows.Forms.Label();
            this.txtLastDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdEquity = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvEquities = new System.Windows.Forms.ListView();
            this.txtAddEquity = new System.Windows.Forms.TextBox();
            this.txtEquityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(21, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Fetch Historical Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnGetQuotes
            // 
            this.btnGetQuotes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuotes.Location = new System.Drawing.Point(21, 67);
            this.btnGetQuotes.Name = "btnGetQuotes";
            this.btnGetQuotes.Size = new System.Drawing.Size(196, 32);
            this.btnGetQuotes.TabIndex = 5;
            this.btnGetQuotes.Text = "Update Quotes";
            this.btnGetQuotes.UseVisualStyleBackColor = false;
            this.btnGetQuotes.Click += new System.EventHandler(this.BtnGetQuotes_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(21, 124);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(196, 32);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = false;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbMain.Location = new System.Drawing.Point(0, 519);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1224, 23);
            this.pbMain.TabIndex = 7;
            // 
            // lblLastFetch
            // 
            this.lblLastFetch.AutoSize = true;
            this.lblLastFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFetch.Location = new System.Drawing.Point(22, 171);
            this.lblLastFetch.Name = "lblLastFetch";
            this.lblLastFetch.Size = new System.Drawing.Size(124, 20);
            this.lblLastFetch.TabIndex = 17;
            this.lblLastFetch.Text = "Last Fetch Date";
            // 
            // txtLastDate
            // 
            this.txtLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastDate.Location = new System.Drawing.Point(21, 194);
            this.txtLastDate.Name = "txtLastDate";
            this.txtLastDate.Size = new System.Drawing.Size(196, 26);
            this.txtLastDate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Equities";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAdEquity
            // 
            this.btnAdEquity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdEquity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdEquity.Location = new System.Drawing.Point(901, 209);
            this.btnAdEquity.Name = "btnAdEquity";
            this.btnAdEquity.Size = new System.Drawing.Size(126, 32);
            this.btnAdEquity.TabIndex = 20;
            this.btnAdEquity.Text = "Add Equity";
            this.btnAdEquity.UseVisualStyleBackColor = false;
            this.btnAdEquity.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(21, 245);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(196, 32);
            this.btnUsers.TabIndex = 24;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(21, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 32);
            this.button3.TabIndex = 25;
            this.button3.Text = "Equity Groups";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // lvEquities
            // 
            this.lvEquities.HideSelection = false;
            this.lvEquities.Location = new System.Drawing.Point(266, 54);
            this.lvEquities.MultiSelect = false;
            this.lvEquities.Name = "lvEquities";
            this.lvEquities.Size = new System.Drawing.Size(541, 335);
            this.lvEquities.TabIndex = 26;
            this.lvEquities.UseCompatibleStateImageBehavior = false;
            // 
            // txtAddEquity
            // 
            this.txtAddEquity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEquity.Location = new System.Drawing.Point(901, 109);
            this.txtAddEquity.Name = "txtAddEquity";
            this.txtAddEquity.Size = new System.Drawing.Size(110, 26);
            this.txtAddEquity.TabIndex = 27;
            // 
            // txtEquityName
            // 
            this.txtEquityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquityName.Location = new System.Drawing.Point(901, 165);
            this.txtEquityName.Name = "txtEquityName";
            this.txtEquityName.Size = new System.Drawing.Size(311, 26);
            this.txtEquityName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Symbol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(898, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquityName);
            this.Controls.Add(this.txtAddEquity);
            this.Controls.Add(this.lvEquities);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnAdEquity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastFetch);
            this.Controls.Add(this.txtLastDate);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnGetQuotes);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmAdmin";
            this.Text = "Admin Center";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetQuotes;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Label lblLastFetch;
        private System.Windows.Forms.TextBox txtLastDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdEquity;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvEquities;
        private System.Windows.Forms.TextBox txtAddEquity;
        private System.Windows.Forms.TextBox txtEquityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}