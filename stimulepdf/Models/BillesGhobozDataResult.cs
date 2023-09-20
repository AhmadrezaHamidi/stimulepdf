namespace stimulepdf.Models
{
    public class BillesGhobozDataResult
    {
        public int row { get; set; }
        public string PayDate { get; set; }
        public string BranchCode { get; set; }
        public string BillId { get; set; }
        public string PaymentId { get; set; }
        public long RefCode { get; set; }   /// BigInt
        public string type { get; set; }
        public decimal realAmount { get; set; } /// numberic
        public string tabecode { get; set; }
        public string linkAccNum { get; set; }
    }
}


