using AllShop_DataSync.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.BLL
{
    public class rChallanManager
    {
        FIK.DAL.SQL _sqlDal = null;
        public List<rChallan> GetrChallanToTransfer(ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);

            string query = @"SELECT * FROM dbo.rChallan WHERE Transfer IS NULL OR Transfer = 'N'";
            return _sqlDal.Select<rChallan>(query, ref msg);
        }
        public bool InsertOrUpdaterChallan(List<rChallan> lstrChallan, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["ToDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstrChallan)
            {

                string q = @" IF EXISTS (SELECT * FROM dbo.rChallan WHERE CmpIDX = '" + s.CmpIDX + @"')
	BEGIN
		UPDATE rChallan SET
	                        Chln= '" + s.Chln + @"',
	                        OrderNo = '" + s.OrderNo + @"',
	                        BuyDT = '" + s.BuyDT + @"',
	                        sBarCode = '" + s.sBarCode + @"',
	                        BarCode= '" + s.BarCode + @"',
	                        GroupName = '" + s.GroupName + @"',
	                        Prdname = '" + s.Prdname + @"',
	                        BTname= '" + s.BTname + @"',
	                        SSName = '" + s.SSName + @"',
	                        fbname = '" + s.fbname + @"',
	                        ftname = '" + s.ftname + @"',
	                        clname= '" + s.clname + @"',
	                        wsname = '" + s.wsname + @"',
	                        slname= '" + s.slname + @"',
	                        ShortName= '" + s.ShortName + @"',
	                        CPU= '" + s.CPU + @"',
	                        acpu= '" + s.acpu + @"',
	                        RPU = '" + s.RPU + @"',
	                        VPU = '" + s.VPU + @"',
	                        RPP = '" + s.RPP + @"',
	                        VPP = '" + s.VPP + @"',
	                        DiscPrcnt = '" + s.DiscPrcnt + @"',
	                        VATPrcnt  = '" + s.VATPrcnt + @"',
	                        PrdComm = '" + s.PrdComm + @"',
	                        Qty = '" + s.Qty + @"',
	                        bQty = '" + s.bQty + @"',
	                        sQty = '" + s.sQty + @"',
	                        cSqty  = '" + s.cSqty + @"',
	                        rQty = '" + s.rQty + @"',
	                        dmlqty = '" + s.dmlqty + @"',
	                        balQty = '" + s.balQty + @"',
	                        SupID = '" + s.SupID + @"',
	                        SupName  = '" + s.SupName + @"',
	                        EXPDT  = '" + s.EXPDT + @"',
	                        LastSDT = '" + s.LastSDT + @"',
	                        ShopID = '" + s.ShopID + @"',
	                        Transfer  = '" + s.Transfer + @"',
	                        TotalPrdComm  = '" + s.TotalPrdComm + @"',
	                        AddPrdComm  = '" + s.AddPrdComm + @"',
	                        ChlnTotal  = '" + s.ChlnTotal + @"',
	                        SupRef  = '" + s.SupRef + @"',
	                        UserID  = '" + s.UserID + @"',
	                        Point = '" + s.Point + @"',
	                        Reorder  = '" + s.Reorder + @"',
	                        ZoneID   = '" + s.ZoneID + @"'
						 WHERE CmpIDX = '" + s.CmpIDX + @"';
	END

ELSE 
	BEGIN
		INSERT INTO dbo.rChallan
			        ( CmpIDX ,
			          Chln ,
			          OrderNo ,
			          BuyDT ,
			          sBarCode ,
			          BarCode ,
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
			          acpu ,
			          RPU ,
			          VPU ,
			          RPP ,
			          VPP ,
			          DiscPrcnt ,
			          VATPrcnt ,
			          PrdComm ,
			          Qty ,
			          bQty ,
			          sQty ,
			          cSqty ,
			          rQty ,
			          dmlqty ,
			          balQty ,
			          SupID ,
			          SupName ,
			          EXPDT ,
			          LastSDT ,
			          ShopID ,
			          Transfer ,
			          TotalPrdComm ,
			          AddPrdComm ,
			          ChlnTotal ,
			          SupRef ,
			          UserID ,
			          Point ,
			          Reorder ,
			          ZoneID
			        )
			VALUES  ( '" + s.CmpIDX + @"',
			          '" + s.Chln + @"',
			          '" + s.OrderNo + @"',
			          '" + s.BuyDT + @"',
			          '" + s.sBarCode + @"',
			          '" + s.BarCode + @"',
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
			          '" + s.acpu + @"',
			          '" + s.RPU + @"',
			          '" + s.VPU + @"',
			          '" + s.RPP + @"',
			          '" + s.VPP + @"',
			          '" + s.DiscPrcnt + @"',
			          '" + s.VATPrcnt + @"',
			          '" + s.PrdComm + @"',
			          '" + s.Qty + @"',
			          '" + s.bQty + @"',
			          '" + s.sQty + @"',
			          '" + s.cSqty + @"',
			          '" + s.rQty + @"',
			          '" + s.dmlqty + @"',
			          '" + s.balQty + @"',
			          '" + s.SupID + @"',
			          '" + s.SupName + @"',
			          '" + s.EXPDT + @"',
			          '" + s.LastSDT + @"',
			          '" + s.ShopID + @"',
			          '" + s.Transfer + @"',
			          '" + s.TotalPrdComm + @"',
			          '" + s.AddPrdComm + @"',
			          '" + s.ChlnTotal + @"',
			          '" + s.SupRef + @"',
			          '" + s.UserID + @"',
			          '" + s.Point + @"',
			          '" + s.Reorder + @"',
			          '" + s.ZoneID + @"'
			        )
	            END ";
                query.Add(q);


            }
            return _sqlDal.ExecuteQuery(query, ref msg);

        }
        public bool SaveAcknowledgement(List<rChallan> lstrChallan, ref string msg)
        {
            string connection = ConfigurationManager.ConnectionStrings["FromDB"].ConnectionString;
            _sqlDal = new FIK.DAL.SQL(connection);
            List<string> query = new List<string>();
            foreach (var s in lstrChallan)
            {
                string q = @"UPDATE dbo.rChallan set Transfer = 'Y' WHERE CmpIDX = '" + s.CmpIDX + @"'";
                query.Add(q);
            }
            return _sqlDal.ExecuteQuery(query, ref msg);
        }
    }
}
