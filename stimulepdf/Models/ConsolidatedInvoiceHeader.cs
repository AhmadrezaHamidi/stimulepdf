namespace stimulepdf.Models
{
    public class ConsolidatedInvoiceHeader
    {
        public string AcctNo { get; set; }
        public string TR_Type { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string Amount { get; set; }
        public string Serial { get; set; }
        public string Info2 { get; set; }
        public string BranchCode { get; set; }
        public string Sort { get; set; }
        public int PageNo { get; set; }

        public static implicit operator ConsolidatedInvoiceHeader(BillesInternetHeader v)
        {
            throw new NotImplementedException();
        }
    }
}


