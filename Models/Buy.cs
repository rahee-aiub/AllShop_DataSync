using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.Models
{
    public class Buy
    {
        public string CMPIDX { get; set; }

        public string sBarCode { get; set; }

        public string BarCode { get; set; }

        public string Chln { get; set; }

        public DateTime? BuyDT { get; set; }

        public string GroupName { get; set; }

        public string Prdname { get; set; }

        public string BTname { get; set; }

        public string SSName { get; set; }

        public string fbname { get; set; }

        public string ftname { get; set; }

        public string clname { get; set; }

        public string wsname { get; set; }

        public string slname { get; set; }

        public string ShortName { get; set; }

        public decimal? CPU { get; set; }

        public decimal? LCPU { get; set; }

        public decimal? RPU { get; set; }

        public decimal? RPP { get; set; }

        public decimal? DiscPrcnt { get; set; }

        public decimal? VATPrcnt { get; set; }

        public decimal? PrdComm { get; set; }

        public decimal? Qty { get; set; }

        public decimal? bQty { get; set; }

        public decimal? ShopReturn { get; set; }

        public decimal? sreturn { get; set; }

        public decimal? sQty { get; set; }

        public decimal? rQty { get; set; }

        public decimal? SrpQty { get; set; }

        public decimal? dmlqty { get; set; }

        public decimal? InvQty { get; set; }

        public decimal? balQty { get; set; }

        public decimal? Adjqty { get; set; }

        public string SupID { get; set; }

        public string SupName { get; set; }

        public DateTime? EXPDT { get; set; }

        public DateTime? LastSDT { get; set; }

        public string ShopID { get; set; }

        public string Transfer { get; set; }

        public string UserID { get; set; }

        public decimal? Point { get; set; }

        public decimal? Reorder { get; set; }

        public string ZoneID { get; set; }

        public DateTime? InventoryDT { get; set; }

        public decimal? openqty { get; set; }

        public decimal? acpu { get; set; }

        public decimal? scanqty { get; set; }

        public decimal? WriteOn { get; set; }

        public decimal? WriteOff { get; set; }

    }

}
