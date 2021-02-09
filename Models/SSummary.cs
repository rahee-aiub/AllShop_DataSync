using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShop_DataSync.Models
{
    public class SSummary
    {
        public string Invoice { get; set; }

        public DateTime? SaleDT { get; set; }

        public decimal? TotalCost { get; set; }

        public decimal? TotalAmt { get; set; }

        public decimal? Discount { get; set; }

        public decimal? DiscAmt { get; set; }

        public decimal? VAT { get; set; }

        public decimal? rVAT { get; set; }

        public decimal? NetAmt { get; set; }

        public decimal? CshAmt { get; set; }

        public decimal? CrdAmt { get; set; }

        public string PayType { get; set; }

        public string Salesman { get; set; }

        public string ShopID { get; set; }

        public string CardName { get; set; }

        public string Cardno { get; set; }

        public string CounterID { get; set; }

        public string PrvCus { get; set; }

        public string PrvCusID { get; set; }

        public string ParentID { get; set; }

        public string GrandID { get; set; }

        public string CusName { get; set; }

        public decimal? ReturnedAmt { get; set; }

        public decimal? rTotalCost { get; set; }

        public string cInvoice { get; set; }

        public string ReturnedType { get; set; }

        public string Flag { get; set; }

        public decimal? PaidAmt { get; set; }

        public decimal? ChangeAmt { get; set; }

        public string MrCode { get; set; }

        public string MrName { get; set; }

        public string TSEC { get; set; }

        public decimal? totalEarn { get; set; }

        public decimal? acpu { get; set; }

        public decimal? VoidAmt { get; set; }

        public decimal? Point { get; set; }

        public decimal? PointRedem { get; set; }

        public decimal? PointRedemAmt { get; set; }

        public decimal? pointearn { get; set; }

        public string IsTransfer { get; set; }

    }

}
