using AllShop_DataSync.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.BLL
{
    public class SaleManager
    {
        FIK.DAL.SQL _sqlDal = null;
        public List<Sale> GetSaleToTransfer(string tablename,ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);


            string query = @"SELECT * FROM dbo."+tablename+" WHERE isTransfer IS NULL OR isTransfer = 'N'";
            return _sqlDal.Select<Sale>(query, ref msg);
        }
        public bool InsertOrUpdateSale(List<Sale> lstSale, string tablename, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["ToDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstSale)
            {

                string q = @" IF EXISTS (SELECT * FROM dbo." + tablename + " WHERE CmpIDX = '" + s.CmpIDX + @"')
	BEGIN
		UPDATE dbo." + tablename + @" SET
				SaleDT ='" + s.SaleDT + @"',
				SupID='" + s.SupID + @"',
				SupName ='" + s.SupName + @"',
				GroupName ='" + s.GroupName + @"',
				PrdName ='" + s.PrdName + @"',
				BTName='" + s.BTName + @"',
				SSName ='" + s.SSName + @"',
				fbname ='" + s.fbname + @"',
				ftname='" + s.ftname + @"',
				clname='" + s.clname + @"',
				wsname ='" + s.wsname + @"',
				slname='" + s.slname + @"',
				ShortName  ='" + s.ShortName + @"',
				Qty ='" + s.Qty + @"',
				CPU ='" + s.CPU + @"',
				RPP ='" + s.RPP + @"',
				RPU='" + s.RPU + @"',
				VPP ='" + s.VPP + @"',
				VPU='" + s.VPU + @"',
				sBarCode='" + s.sBarCode + @"',
				BarCode ='" + s.BarCode + @"',
				SQty ='" + s.SQty + @"',
				rQty ='" + s.rQty + @"',
				rAmt ='" + s.rAmt + @"',
				cInvoice  ='" + s.cInvoice + @"',
				ShopID  ='" + s.ShopID + @"',
				PayType ='" + s.PayType + @"',
				TotalCost ='" + s.TotalCost + @"',
				TotalAmt ='" + s.TotalAmt + @"',
				Discount='" + s.Discount + @"',
				DiscAmt='" + s.DiscAmt + @"',
				DiscAmtPrd='" + s.DiscAmtPrd + @"',
				VAT ='" + s.VAT + @"',
				NetAmt ='" + s.NetAmt + @"',
				PrdSlNo='" + s.PrdSlNo + @"',
				CshAmt='" + s.CshAmt + @"',
				CrdAmt ='" + s.CrdAmt + @"',
				Salesman ='" + s.Salesman + @"',
				Invoice='" + s.Invoice + @"',
				CardName='" + s.CardName + @"',
				Cardno='" + s.Cardno + @"',
				CounterID ='" + s.CounterID + @"',
				PrvCus='" + s.PrvCus + @"',
				PrvCusID='" + s.PrvCusID + @"',
				GrandID ='" + s.GrandID + @"',
				ParentID ='" + s.ParentID + @"',
				CusName ='" + s.CusName + @"',
				Posted ='" + s.Posted + @"',
				VATPrcnt ='" + s.VATPrcnt + @"',
				DiscPrcnt ='" + s.DiscPrcnt + @"',
				Returned ='" + s.Returned + @"',
				ReturnedType ='" + s.ReturnedType + @"',
				ReturnedDt ='" + s.ReturnedDt + @"',
				Flag ='" + s.Flag + @"',
				MrCode='" + s.MrCode + @"',
				MrName ='" + s.MrName + @"',
				Point ='" + s.Point + @"',
				TSEC ='" + s.TSEC + @"',
				rvat='" + s.rvat + @"'
				WHERE CmpIDX = '" + s.CmpIDX + @"';
	END

ELSE 
	BEGIN
		INSERT INTO dbo." + tablename + @"
		        ( CmpIDX ,
		          SaleDT ,
		          SupID ,
		          SupName ,
		          GroupName ,
		          PrdName ,
		          BTName ,
		          SSName ,
		          fbname ,
		          ftname ,
		          clname ,
		          wsname ,
		          slname ,
		          ShortName ,
		          Qty ,
		          CPU ,
		          RPP ,
		          RPU ,
		          VPP ,
		          VPU ,
		          sBarCode ,
		          BarCode ,
		          SQty ,
		          rQty ,
		          rAmt ,
		          cInvoice ,
		          ShopID ,
		          PayType ,
		          TotalCost ,
		          TotalAmt ,
		          Discount ,
		          DiscAmt ,
		          DiscAmtPrd ,
		          VAT ,
		          NetAmt ,
		          PrdSlNo ,
		          CshAmt ,
		          CrdAmt ,
		          Salesman ,
		          Invoice ,
		          CardName ,
		          Cardno ,
		          CounterID ,
		          PrvCus ,
		          PrvCusID ,
		          GrandID ,
		          ParentID ,
		          CusName ,
		          Posted ,
		          VATPrcnt ,
		          DiscPrcnt ,
		          Returned ,
		          ReturnedType ,
		          ReturnedDt ,
		          Flag ,
		          MrCode ,
		          MrName ,
		          Point ,
		          TSEC ,
		          rvat
		        )
		VALUES  ('" + s.CmpIDX + @"',
		        '" + s.SaleDT + @"',
		        '" + s.SupID + @"',
		        '" + s.SupName + @"',
		        '" + s.GroupName + @"',
		        '" + s.PrdName + @"',
		        '" + s.BTName + @"',
		        '" + s.SSName + @"',
		        '" + s.fbname + @"',
		        '" + s.ftname + @"',
		        '" + s.clname + @"',
		        '" + s.wsname + @"',
		        '" + s.slname + @"',
		        '" + s.ShortName + @"',
		        '" + s.Qty + @"',
		        '" + s.CPU + @"',
		        '" + s.RPP + @"',
		        '" + s.RPU + @"',
		        '" + s.VPP + @"',
		        '" + s.VPU + @"',
		        '" + s.sBarCode + @"',
		        '" + s.BarCode + @"',
		        '" + s.SQty + @"',
		        '" + s.rQty + @"',
		        '" + s.rAmt + @"',
		        '" + s.cInvoice + @"',
		        '" + s.ShopID + @"',
		        '" + s.PayType + @"',
		        '" + s.TotalCost + @"',
		        '" + s.TotalAmt + @"',
		        '" + s.Discount + @"',
		        '" + s.DiscAmt + @"',
		        '" + s.DiscAmtPrd + @"',
		        '" + s.VAT + @"',
		        '" + s.NetAmt + @"',
		        '" + s.PrdSlNo + @"',
		        '" + s.CshAmt + @"',
		        '" + s.CrdAmt + @"',
		        '" + s.Salesman + @"',
		        '" + s.Invoice + @"',
		        '" + s.CardName + @"',
		        '" + s.Cardno + @"',
		        '" + s.CounterID + @"',
		        '" + s.PrvCus + @"',
		        '" + s.PrvCusID + @"',
		        '" + s.GrandID + @"',
		        '" + s.ParentID + @"',
		        '" + s.CusName + @"',
		        '" + s.Posted + @"',
		        '" + s.VATPrcnt + @"',
		        '" + s.DiscPrcnt + @"',
		        '" + s.Returned + @"',
		        '" + s.ReturnedType + @"',
		        '" + s.ReturnedDt + @"',
		        '" + s.Flag + @"',
		        '" + s.MrCode + @"',
		        '" + s.MrName + @"',
		        '" + s.Point + @"',
		        '" + s.TSEC + @"',
		        '" + s.rvat + @"'
		        )
	            END ";
                query.Add(q);


            }
            return _sqlDal.ExecuteQuery(query, ref msg);

        }

        public bool SaveAcknowledgement(List<Sale> lstSale, string tablename, ref string msg)
        {
             string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstSale)
            {
                string q = @"UPDATE dbo." + tablename + " set isTransfer = 'Y' WHERE CmpIDX = '" + s.CmpIDX + @"'" ;
                query.Add(q);
            }
            return _sqlDal.ExecuteQuery(query, ref msg);
        }

    }
}
