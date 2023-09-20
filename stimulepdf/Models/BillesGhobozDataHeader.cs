using System.ComponentModel.DataAnnotations;

namespace stimulepdf.Models
{
    public class BillesGhobozDataHeader
    {
        public string AcctNo { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string IDBill { get; set; }
        public string IDPay { get; set; }
        public string RefNo { get; set; }
        public string Amount { get; set; }
        public string Tabe { get; set; }
        public int PageNo { get; set; }
    }

}
