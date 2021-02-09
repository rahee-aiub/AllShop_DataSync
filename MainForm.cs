using AllShop_DataSync.BLL;
using AllShop_DataSync.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllShop_DataSync
{
    public partial class MainForm : Form
    {
        TimeSpan ts = new TimeSpan();


        string msg = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void TimerCount_Tick(object sender, EventArgs e)
        {
            ts = ts.Add(new TimeSpan(0, 0, 1));
            lblRunningTime.Text = ts.ToString();
        }

        private Thread demoThread = null;
        private void SetLabelValue(Label source, string value)
        {
            if (source.InvokeRequired)
            {
                source.Invoke(new MethodInvoker(delegate
                {
                    source.Text = value;
                }));
            }
        }

        private void SetErrorValue(string value)
        {
            if (rtbError.InvokeRequired)
            {
                rtbError.Invoke(new MethodInvoker(delegate
                {
                    rtbError.Text = value;
                }));
            }
        }
        private void btnSSummary_Click(object sender, EventArgs e)
        {

            if (demoThread == null)
            {
                this.demoThread = new Thread(new ThreadStart(SSummaryDataSync));
            }
            if (!demoThread.IsAlive)
            {
                this.demoThread = new Thread(new ThreadStart(SSummaryDataSync));
                this.demoThread.Start();
            }

        }

    
        private void SSummaryDataSync()
        {
            try
            {

                SetLabelValue(lblStatus, "SSummary Data Sync Running...");
               

                SSummaryManager oSSummaryManager = new SSummaryManager();
                List<SSummary> lstSSummary = new List<SSummary>();

                var x = oSSummaryManager.GetSSummaryToTransfer(ref msg);

                Thread.Sleep(2000);

                lstSSummary = x;

                if (lstSSummary != null || lstSSummary.Count < 0)
                {
                    bool result = oSSummaryManager.InsertOrUpdateSSummary(lstSSummary, ref msg);
                   
                    if (result)
                    {
                        SetLabelValue(lblTotalPostedData, x.Count.ToString());
                        oSSummaryManager.SaveAcknowledgement(lstSSummary, ref msg);
                        SetErrorValue(msg);
                    }
                    SetErrorValue(msg);
                }
            }
            catch (Exception ex)
            {
                SetErrorValue(ex.Message);
            }
            finally
            {
                SetLabelValue(lblStatus, "SSummary Data Sync Completed !! ");
            }
        }

        private void btnStockReturn_Click(object sender, EventArgs e)
        {
            if (demoThread == null)
            {
                this.demoThread = new Thread(new ThreadStart(StockReturnDataSync));
            }
            if (!demoThread.IsAlive)
            {
                this.demoThread = new Thread(new ThreadStart(StockReturnDataSync));
                this.demoThread.Start();
            }        
        }

        private void StockReturnDataSync()
        {
            try
            {
                SetLabelValue(lblStatus, "Stock Return Data Sync Running...");

                StockReturnManager oStockReturnManager = new StockReturnManager();
                List<StockReturn> lstStockReturn = new List<StockReturn>();

                var x = oStockReturnManager.GetStockReturnToTransfer(ref msg);
                Thread.Sleep(2000);
                lstStockReturn = x;

                if (lstStockReturn != null || lstStockReturn.Count < 0)
                {
                    bool result = oStockReturnManager.InsertOrUpdateStockReturn(lstStockReturn, ref msg);
                    SetErrorValue(msg);
                    if (result)
                    {
                        SetLabelValue(lblTotalPostedData, x.Count.ToString());
                        oStockReturnManager.SaveAcknowledgement(lstStockReturn, ref msg);
                        SetErrorValue(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                SetErrorValue(ex.Message);
            }
            finally
            {
                SetLabelValue(lblStatus, "Stock Return Data Sync Completed !!");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
          
            if (demoThread == null)
            {
                this.demoThread = new Thread(new ThreadStart(BuyDataSync));
            }
            if (!demoThread.IsAlive)
            {
                this.demoThread = new Thread(new ThreadStart(BuyDataSync));
                this.demoThread.Start();
            }
          
        }
        private void BuyDataSync()
        {
            try
            {
                SetLabelValue(lblStatus, "Buy Data Sync Running...");

                BuyManager oBuyManager = new BuyManager();
                List<Buy> lstBuy = new List<Buy>();

                var x = oBuyManager.GetBuyToTransfer(ref msg);
                Thread.Sleep(2000);
                lstBuy = x;

                if (lstBuy != null || lstBuy.Count < 0)
                {
                    bool result = oBuyManager.InsertOrUpdateBuy(lstBuy, ref msg);
                    SetErrorValue(msg);
                    if (result)
                    {
                        SetLabelValue(lblTotalPostedData, x.Count.ToString());                      
                        oBuyManager.SaveAcknowledgement(lstBuy, ref msg);
                        SetErrorValue(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                SetErrorValue(ex.Message);
            }
            finally
            {
                SetLabelValue(lblStatus, "Buy Data Sync Completed !!");
            }
        }

        private void btnrChallan_Click(object sender, EventArgs e)
        {

            if (demoThread == null)
            {
                this.demoThread = new Thread(new ThreadStart(rChallanDataSync));
            }
            if (!demoThread.IsAlive)
            {
                this.demoThread = new Thread(new ThreadStart(rChallanDataSync));
                this.demoThread.Start();
            }
        
        }

        private void rChallanDataSync()
        {
            try
            {
                SetLabelValue(lblStatus, "r Challan Data Sync Running...");
                Thread.Sleep(2000);

                rChallanManager orChallanManager = new rChallanManager();
                List<rChallan> lstrChallan = new List<rChallan>();

                var x = orChallanManager.GetrChallanToTransfer(ref msg);

                lstrChallan = x;

                if (lstrChallan != null || lstrChallan.Count < 0)
                {
                    bool result = orChallanManager.InsertOrUpdaterChallan(lstrChallan, ref msg);
                    SetErrorValue(msg);
                    if (result)
                    {
                        SetLabelValue(lblTotalPostedData, x.Count.ToString());
                        orChallanManager.SaveAcknowledgement(lstrChallan, ref msg);
                        SetErrorValue(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                SetErrorValue(ex.Message);
            }
            finally
            {
                SetLabelValue(lblStatus, "r Challan Data Sync Completed !!");
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
           
            if (demoThread == null)
            {
                this.demoThread = new Thread(new ThreadStart(SaleDataSync));
            }
            if (!demoThread.IsAlive)
            {
                this.demoThread = new Thread(new ThreadStart(SaleDataSync));
                this.demoThread.Start();
            }
          
        }
        private void SaleDataSync()
        {
            try
            {
                string TableName = "Sale" + dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString("00");

                SetLabelValue(lblStatus, "Sale Data Sync Running...");
                SaleManager orSaleManager = new SaleManager();
                List<Sale> lstSale = new List<Sale>();

                var x = orSaleManager.GetSaleToTransfer(TableName, ref msg);
                SetErrorValue(msg);

                Thread.Sleep(2000);
                lstSale = x;

                if (lstSale != null || lstSale.Count < 0)
                {
                    bool result = orSaleManager.InsertOrUpdateSale(lstSale, TableName, ref msg);
                    SetErrorValue(msg);
                    if (result)
                    {
                        SetLabelValue(lblTotalPostedData, x.Count.ToString());
                        orSaleManager.SaveAcknowledgement(lstSale, TableName, ref msg);
                        SetErrorValue(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                SetErrorValue(ex.Message);
            }
            finally
            {
                SetLabelValue(lblStatus, "Sale Data Sync Completed !!");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(demoThread != null)
            {              
                if (demoThread.IsAlive)
                {
                    e.Cancel = true;
                }
            }
          
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
         
        }
    }
}
