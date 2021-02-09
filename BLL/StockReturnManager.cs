using AllShop_DataSync.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.BLL
{
    public class StockReturnManager
    {
        FIK.DAL.SQL _sqlDal = null;
        public List<StockReturn> GetStockReturnToTransfer(ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);

            string query = @"SELECT * FROM dbo.StockReturn WHERE Transfer IS NULL OR Transfer = 'N'";
            return _sqlDal.Select<StockReturn>(query, ref msg);
        }

        public bool InsertOrUpdateStockReturn(List<StockReturn> lstStockReturn, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["ToDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstStockReturn)
            {

                string q = @" IF EXISTS (SELECT * FROM dbo.StockReturn WHERE CmpIDX = '" + s.CmpIDX + @"')
	BEGIN
		UPDATE dbo.StockReturn 
		
		SET 		
				 Chln = '" + s.Chln + @"',
	             sBarcode = '" + s.sBarcode + @"',
	             BarCode = '" + s.BarCode + @"',
	             GroupName = '" + s.GroupName + @"',
	             PrdName = '" + s.PrdName + @"',
	             BTName = '" + s.BTName + @"',
	             SSName = '" + s.SSName + @"',
	             fbname = '" + s.fbname + @"',
	             ftname = '" + s.ftname + @"',
	             clname = '" + s.clname + @"',
	             wsname = '" + s.wsname + @"',
	             slname = '" + s.slname + @"',
	             ShortName = '" + s.ShortName + @"',
	             SupID = '" + s.SupID + @"',
	             SupName = '" + s.SupName + @"',
	             CPU = '" + s.CPU + @"',
	             RPU = '" + s.RPU + @"',
	             Qty = '" + s.Qty + @"',
	             cSqty = '" + s.cSqty + @"',
	             sQty = '" + s.sQty + @"',
	             rQty = '" + s.rQty + @"',
	             balQty = '" + s.balQty + @"',
	             sReturn = '" + s.sReturn + @"',
	             ReturnDt = '" + s.ReturnDt + @"',
	             UserID = '" + s.UserID + @"',
	             ShopID = '" + s.ShopID + @"',
	             TransferTo = '" + s.TransferTo + @"',
	             Reasons = '" + s.Reasons + @"',
	             Transfer = '" + s.Transfer + @"',
	             vatprcnt = '" + s.vatprcnt + @"',
	             discprcnt = '" + s.discprcnt + @"'
				 WHERE CmpIDX = '" + s.CmpIDX + @"'
		;
	END

ELSE 
	BEGIN
		 INSERT INTO dbo.StockReturn
	           ( CmpIDX ,
	             Chln ,
	             sBarcode ,
	             BarCode ,
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
	             SupID ,
	             SupName ,
	             CPU ,
	             RPU ,
	             Qty ,
	             cSqty ,
	             sQty ,
	             rQty ,
	             balQty ,
	             sReturn ,
	             ReturnDt ,
	             UserID ,
	             ShopID ,
	             TransferTo ,
	             Reasons ,
	             Transfer ,
	             vatprcnt ,
	             discprcnt
	           )
	   VALUES  ('" + s.CmpIDX + @"',
	            '" + s.Chln + @"',
	            '" + s.sBarcode + @"',
	            '" + s.BarCode + @"',
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
	            '" + s.SupID + @"',
	            '" + s.SupName + @"',
	            '" + s.CPU + @"',
	            '" + s.RPU + @"',
	            '" + s.Qty + @"',
	            '" + s.cSqty + @"',
	            '" + s.sQty + @"',
	            '" + s.rQty + @"',
	            '" + s.balQty + @"',
	            '" + s.sReturn + @"',
	            '" + s.ReturnDt + @"',
	            '" + s.UserID + @"',
	            '" + s.ShopID + @"',
	            '" + s.TransferTo + @"',
	            '" + s.Reasons + @"',
	            '" + s.Transfer + @"',
	            '" + s.vatprcnt + @"',
	            '" + s.discprcnt + @"'
	           )
	            END ";
                query.Add(q);


            }
            return _sqlDal.ExecuteQuery(query, ref msg);

        }

        public bool SaveAcknowledgement(List<StockReturn> lstStockReturn, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstStockReturn)
            {
                string q = @"UPDATE dbo.StockReturn set Transfer = 'Y' WHERE CmpIDX = '" + s.CmpIDX + @"'";
                query.Add(q);
            }
            return _sqlDal.ExecuteQuery(query, ref msg);
        }
    }
}
