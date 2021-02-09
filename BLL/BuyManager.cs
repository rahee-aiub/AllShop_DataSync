using AllShop_DataSync.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.BLL
{
    public class BuyManager
    {
        FIK.DAL.SQL _sqlDal = null;
        public List<Buy> GetBuyToTransfer(ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);

            string query = @"SELECT * FROM dbo.Buy WHERE Transfer IS NULL OR Transfer = 'N'";
            return _sqlDal.Select<Buy>(query, ref msg);
        }
        public bool InsertOrUpdateBuy(List<Buy> lstBuy, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["ToDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstBuy)
            {

                string q = @" IF EXISTS (SELECT * FROM dbo.Buy WHERE CmpIDX = '" + s.CMPIDX + @"')
	BEGIN
		UPDATE BUY SET
				         sBarCode  = '" + s.sBarCode + @"',
                        BarCode= '" + s.BarCode + @"',
                        Chln    = '" + s.Chln + @"',
                        BuyDT   = '" + s.BuyDT + @"',
                        GroupName   = '" + s.GroupName + @"',
                        Prdname = '" + s.Prdname + @"',
                        BTname  = '" + s.BTname + @"',
                        SSName  = '" + s.SSName + @"',
                        fbname  = '" + s.fbname + @"',
                        ftname  = '" + s.ftname + @"',
                        clname= '" + s.clname + @"',
                        wsname = '" + s.wsname + @"',
                        slname  = '" + s.slname + @"',
                        ShortName  = '" + s.ShortName + @"',
                        CPU = '" + s.CPU + @"',
                        LCPU = '" + s.LCPU + @"',
                        RPU= '" + s.RPU + @"',
                        RPP= '" + s.RPP + @"',
                        DiscPrcnt= '" + s.DiscPrcnt + @"',
                        VATPrcnt = '" + s.VATPrcnt + @"',
                        PrdComm = '" + s.PrdComm + @"',
                        Qty = '" + s.Qty + @"',
                        bQty = '" + s.bQty + @"',
                        ShopReturn  = '" + s.ShopReturn + @"',
                        sreturn  = '" + s.sreturn + @"',
                        sQty = '" + s.sQty + @"',
                        rQty  = '" + s.rQty + @"',
                        SrpQty = '" + s.SrpQty + @"',
                        dmlqty = '" + s.dmlqty + @"',
                        InvQty = '" + s.InvQty + @"',
                        balQty  = '" + s.balQty + @"',
                        Adjqty = '" + s.Adjqty + @"',
                        SupID = '" + s.SupID + @"',
                        SupName = '" + s.SupName + @"',
                        EXPDT = '" + s.EXPDT + @"',
                        LastSDT = '" + s.LastSDT + @"',
                        ShopID = '" + s.ShopID + @"',
                        Transfer = '" + s.Transfer + @"',
                        UserID = '" + s.UserID + @"',
                        Point = '" + s.Point + @"',
                        Reorder = '" + s.Reorder + @"',
                        ZoneID = '" + s.ZoneID + @"',
                        InventoryDT  = '" + s.InventoryDT + @"',
                        openqty = '" + s.openqty + @"',
                        acpu = '" + s.acpu + @"',
                        scanqty = '" + s.scanqty + @"',
                        WriteOn = '" + s.WriteOn + @"',
                        WriteOff= '" + s.WriteOff + @"'
                        WHERE CMPIDX = '" + s.CMPIDX + @"';
	END

ELSE 
	BEGIN
		 INSERT INTO dbo.Buy
		        ( CMPIDX ,
		          sBarCode ,
		          BarCode ,
		          Chln ,
		          BuyDT ,
		          GroupName ,
		          Prdname ,
		          BTname ,
		          SSName ,
		          fbname ,
		          ftname ,
		          clname ,
		          wsname ,
		          slname ,
		          ShortName ,
		          CPU ,
		          LCPU ,
		          RPU ,
		          RPP ,
		          DiscPrcnt ,
		          VATPrcnt ,
		          PrdComm ,
		          Qty ,
		          bQty ,
		          ShopReturn ,
		          sreturn ,
		          sQty ,
		          rQty ,
		          SrpQty ,
		          dmlqty ,
		          InvQty ,
		          balQty ,
		          Adjqty ,
		          SupID ,
		          SupName ,
		          EXPDT ,
		          LastSDT ,
		          ShopID ,
		          Transfer ,
		          UserID ,
		          Point ,
		          Reorder ,
		          ZoneID ,
		          InventoryDT ,
		          openqty ,
		          acpu ,
		          scanqty ,
		          WriteOn ,
		          WriteOff
		        )
		VALUES  (  '" + s.CMPIDX + @"',
		          '" + s.sBarCode + @"',
		          '" + s.BarCode + @"',
		          '" + s.Chln + @"',
		          '" + s.BuyDT + @"',
		          '" + s.GroupName + @"',
		          '" + s.Prdname + @"',
		          '" + s.BTname + @"',
		          '" + s.SSName + @"',
		          '" + s.fbname + @"',
		          '" + s.ftname + @"',
		          '" + s.clname + @"',
		          '" + s.wsname + @"',
		          '" + s.slname + @"',
		          '" + s.ShortName + @"',
		          '" + s.CPU + @"',
		          '" + s.LCPU + @"',
		          '" + s.RPU + @"',
		          '" + s.RPP + @"',
		          '" + s.DiscPrcnt + @"',
		          '" + s.VATPrcnt + @"',
		          '" + s.PrdComm + @"',
		          '" + s.Qty + @"',
		          '" + s.bQty + @"',
		          '" + s.ShopReturn + @"',
		          '" + s.sreturn + @"',
		          '" + s.sQty + @"',
		          '" + s.rQty + @"',
		          '" + s.SrpQty + @"',
		          '" + s.dmlqty + @"',
		          '" + s.InvQty + @"',
		          '" + s.balQty + @"',
		          '" + s.Adjqty + @"',
		          '" + s.SupID + @"',
		          '" + s.SupName + @"',
		          '" + s.EXPDT + @"',
		          '" + s.LastSDT + @"',
		          '" + s.ShopID + @"',
		          '" + s.Transfer + @"',
		          '" + s.UserID + @"',
		          '" + s.Point + @"',
		          '" + s.Reorder + @"',
		          '" + s.ZoneID + @"',
		          '" + s.InventoryDT + @"',
		          '" + s.openqty + @"',
		          '" + s.acpu + @"',
		          '" + s.scanqty + @"',
		          '" + s.WriteOn + @"',
		          '" + s.WriteOff + @"'
		        )
	            END ";
                query.Add(q);


            }
            return _sqlDal.ExecuteQuery(query, ref msg);

        }

        public bool SaveAcknowledgement(List<Buy> lstBuy,  ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstBuy)
            {
                string q = @"UPDATE dbo.Buy set Transfer = 'Y' WHERE CmpIDX = '" + s.CMPIDX + @"'";
                query.Add(q);
            }
            return _sqlDal.ExecuteQuery(query, ref msg);
        }
    }
}
