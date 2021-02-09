
namespace AllShop_DataSync
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnrChallan = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnStockReturn = new System.Windows.Forms.Button();
            this.btnSSummary = new System.Windows.Forms.Button();
            this.lblRunning = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.TimerCount = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPostedData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbError = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(19, 253);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(100, 30);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnrChallan
            // 
            this.btnrChallan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrChallan.Location = new System.Drawing.Point(149, 253);
            this.btnrChallan.Name = "btnrChallan";
            this.btnrChallan.Size = new System.Drawing.Size(100, 30);
            this.btnrChallan.TabIndex = 2;
            this.btnrChallan.Text = "rChallan";
            this.btnrChallan.UseVisualStyleBackColor = true;
            this.btnrChallan.Click += new System.EventHandler(this.btnrChallan_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(265, 253);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 30);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnStockReturn
            // 
            this.btnStockReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReturn.Location = new System.Drawing.Point(388, 253);
            this.btnStockReturn.Name = "btnStockReturn";
            this.btnStockReturn.Size = new System.Drawing.Size(129, 30);
            this.btnStockReturn.TabIndex = 4;
            this.btnStockReturn.Text = "Stock Return";
            this.btnStockReturn.UseVisualStyleBackColor = true;
            this.btnStockReturn.Click += new System.EventHandler(this.btnStockReturn_Click);
            // 
            // btnSSummary
            // 
            this.btnSSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSummary.Location = new System.Drawing.Point(551, 253);
            this.btnSSummary.Name = "btnSSummary";
            this.btnSSummary.Size = new System.Drawing.Size(100, 30);
            this.btnSSummary.TabIndex = 5;
            this.btnSSummary.Text = "SSummary";
            this.btnSSummary.UseVisualStyleBackColor = true;
            this.btnSSummary.Click += new System.EventHandler(this.btnSSummary_Click);
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Location = new System.Drawing.Point(3, 354);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(79, 13);
            this.lblRunning.TabIndex = 6;
            this.lblRunning.Text = "Running Time :";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(83, 355);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(49, 13);
            this.lblRunningTime.TabIndex = 7;
            this.lblRunningTime.Text = "00:00:00";
            // 
            // TimerCount
            // 
            this.TimerCount.Enabled = true;
            this.TimerCount.Interval = 1000;
            this.TimerCount.Tick += new System.EventHandler(this.TimerCount_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Posted Data :";
            // 
            // lblTotalPostedData
            // 
            this.lblTotalPostedData.AutoSize = true;
            this.lblTotalPostedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPostedData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalPostedData.Location = new System.Drawing.Point(161, 129);
            this.lblTotalPostedData.Name = "lblTotalPostedData";
            this.lblTotalPostedData.Size = new System.Drawing.Size(17, 18);
            this.lblTotalPostedData.TabIndex = 10;
            this.lblTotalPostedData.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(83, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(182, 18);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "No Process is Running";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // rtbError
            // 
            this.rtbError.Location = new System.Drawing.Point(455, 39);
            this.rtbError.Name = "rtbError";
            this.rtbError.Size = new System.Drawing.Size(323, 187);
            this.rtbError.TabIndex = 14;
            this.rtbError.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Error Message";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPostedData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRunningTime);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.btnSSummary);
            this.Controls.Add(this.btnStockReturn);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnrChallan);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "MainForm";
            this.Text = "AllShop Data Sync V1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnrChallan;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnStockReturn;
        private System.Windows.Forms.Button btnSSummary;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Timer TimerCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPostedData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

