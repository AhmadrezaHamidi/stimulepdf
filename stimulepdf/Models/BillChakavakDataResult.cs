namespace stimulepdf.Models
{
    public class BillChakavakDataResult
    {
        public int row { get; set; }
        public string CreditorIBAN { get; set; }
        public string ChequeID { get; set; }
        public string expireDate { get; set; }
        public string ChequeDate { get; set; }
        public string DebtorBranch { get; set; }
        public string DebtorBank { get; set; }
        public string amount { get; set; }
        public string Status { get; set; }
        public string CreditorBranch { get; set; }
        public string CreditorPayCode { get; set; }
        public string SenderCity { get; set; }
        public string ReciverCity { get; set; }
    }


}


