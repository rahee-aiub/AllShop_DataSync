using AllShop_DataSync.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.BLL
{
    public class SSummaryManager
    {
        FIK.DAL.SQL _sqlDal = null;
       

        public List<SSummary> GetSSummaryToTransfer(ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);

            string query = @"SELECT * FROM dbo.Ssummary WHERE IsTransfer IS NULL OR IsTransfer = 'N'";
            return _sqlDal.Select<SSummary>(query, ref msg);
        }
        public bool InsertOrUpdateSSummary(List<SSummary> lstSSummary, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["ToDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstSSummary)
            {
              
                string q = @" IF EXISTS(SELECT* FROM dbo.Ssummary WHERE Invoice = '"+s.Invoice+ @"')
                BEGIN
                    UPDATE dbo.Ssummary SET 
         
           SaleDT         = '" + s.SaleDT + @"',
		   TotalCost      = '" + s.TotalCost + @"',
           TotalAmt       = '" + s.TotalAmt + @"',
           Discount       = '" + s.Discount + @"',
           DiscAmt        = '" + s.DiscAmt + @"',
           VAT            = '" + s.VAT + @"',
           rVAT           = '" + s.rVAT + @"',
           NetAmt         = '" + s.NetAmt + @"',
           CshAmt         = '" + s.CshAmt + @"',
           CrdAmt         = '" + s.CrdAmt + @"',
           PayType        = '" + s.PayType + @"',
           Salesman       = '" + s.Salesman + @"',
           ShopID         = '" + s.ShopID + @"',
           CardName       = '" + s.CardName + @"',
           Cardno         = '" + s.Cardno + @"',
           CounterID      = '" + s.CounterID + @"',
           PrvCus         = '" + s.PrvCus + @"',
           PrvCusID       = '" + s.PrvCusID + @"',
           ParentID       = '" + s.ParentID + @"',
           GrandID        = '" + s.GrandID + @"',
           CusName        = '" + s.CusName + @"',
           ReturnedAmt    = '" + s.ReturnedAmt + @"',
           rTotalCost     = '" + s.rTotalCost + @"',
           cInvoice       = '" + s.cInvoice + @"',
           ReturnedType   = '" + s.ReturnedType + @"',
           Flag           = '" + s.Flag + @"',
           PaidAmt        = '" + s.PaidAmt + @"',
           ChangeAmt      = '" + s.ChangeAmt + @"',
           MrCode         = '" + s.MrCode + @"',
           MrName         = '" + s.MrName + @"',
           TSEC           = '" + s.TSEC + @"',
           totalEarn      = '" + s.totalEarn + @"',
           acpu           = '" + s.acpu + @"',
           VoidAmt        = '" + s.VoidAmt + @"',
           Point          = '" + s.Point + @"',
           PointRedem     = '" + s.PointRedem + @"',
           PointRedemAmt  = '" + s.PointRedemAmt + @"',
           pointearn      = '" + s.pointearn + @"'
          
          
        WHERE Invoice = '" + s.Invoice + @"'
                END
                ELSE
                BEGIN
                INSERT INTO dbo.Ssummary
                        (Invoice,SaleDT,TotalCost,TotalAmt,Discount,DiscAmt,VAT,rVAT,NetAmt,CshAmt,
                          CrdAmt,PayType,Salesman,ShopID,CardName,Cardno,CounterID,PrvCus,PrvCusID,ParentID,
                          GrandID,CusName,ReturnedAmt,rTotalCost,cInvoice,ReturnedType,Flag,PaidAmt,ChangeAmt,
                          MrCode,MrName,TSEC,totalEarn,acpu,VoidAmt,Point,PointRedem,PointRedemAmt,pointearn,IsTransfer
                        )
                VALUES('" + s.Invoice+@"',
                          '"+s.SaleDT+ @"',		 
		                  '" + s.TotalCost + @"',
                          '" + s.TotalAmt + @"',
                          '" + s.Discount + @"',
                          '" + s.DiscAmt + @"',
                          '" + s.VAT + @"',
                          '" + s.rVAT + @"',
                          '" + s.NetAmt + @"',
                          '" + s.CshAmt + @"',
                          '" + s.CrdAmt + @"',
                          '" + s.PayType + @"',
                          '" + s.Salesman + @"',
                          '" + s.ShopID + @"',
                          '" + s.CardName + @"',
                          '" + s.Cardno + @"',
                          '" + s.CounterID + @"',
                          '" + s.PrvCus + @"',
                          '" + s.PrvCusID + @"',
                          '" + s.ParentID + @"',
                          '" + s.GrandID + @"',
                          '" + s.CusName + @"',
                          '" + s.ReturnedAmt + @"',
                          '" + s.rTotalCost + @"',
                          '" + s.cInvoice + @"',
                          '" + s.ReturnedType + @"',
                          '" + s.Flag + @"',
                          '" + s.PaidAmt + @"',
                          '" + s.ChangeAmt + @"',
                          '" + s.MrCode + @"',
                          '" + s.MrName + @"',
                          '" + s.TSEC + @"',
                          '" + s.totalEarn + @"',
                          '" + s.acpu + @"',
                          '" + s.VoidAmt + @"',
                          '" + s.Point + @"',
                          '" + s.PointRedem + @"',
                          '" + s.PointRedemAmt + @"',
                          '" + s.pointearn + @"',
                          '" + s.IsTransfer + @"'
                        )
                END";
                query.Add(q);


            }
            return _sqlDal.ExecuteQuery(query, ref msg);
           
        }
        public bool SaveAcknowledgement(List<SSummary> lstSSummary, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstSSummary)
            {
                string q = @"UPDATE dbo.SSummary set isTransfer = 'Y' WHERE Invoice = '" + s.Invoice + @"'";
                query.Add(q);
            }
            return _sqlDal.ExecuteQuery(query, ref msg);
        }
    }
}
