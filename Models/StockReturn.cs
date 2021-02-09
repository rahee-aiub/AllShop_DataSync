using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.Models
{
    public class StockReturn
    {
        public string CmpIDX { get; set; }

        public string Chln { get; set; }

        public string sBarcode { get; set; }

        public string BarCode { get; set; }

        public string GroupName { get; set; }

        public string PrdName { get; set; }

        public string BTName { get; set; }

        public string SSName { get; set; }

        public string fbname { get; set; }

        public string ftname { get; set; }

        public string clname { get; set; }

        public string wsname { get; set; }

        public string slname { get; set; }

        public string ShortName { get; set; }

        public string SupID { get; set; }

        public string SupName { get; set; }

        public decimal? CPU { get; set; }

        public decimal? RPU { get; set; }

        public decimal? Qty { get; set; }

        public decimal? cSqty { get; set; }

        public decimal? sQty { get; set; }

        public decimal? rQty { get; set; }

        public decimal? balQty { get; set; }

        public decimal? sReturn { get; set; }

        public DateTime? ReturnDt { get; set; }

        public string UserID { get; set; }

        public string ShopID { get; set; }

        public string TransferTo { get; set; }

        public string Reasons { get; set; }

        public string Transfer { get; set; }

        public decimal? vatprcnt { get; set; }

        public decimal? discprcnt { get; set; }

    }

}
