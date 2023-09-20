using System.Globalization;

namespace stimulepdf.Models
{
    public class SummaryResult
    {
        public int row { get; set; }
        public string accno { get; set; } //شماره حساب 
        public string accname { get; set; } // نام صاحب  حساب 
        public string Lasttrnsdate { get; set; } //تاریخ اخرین ترذاکنش 
        public string Filedate { get; set; } //مانده در تاریخ 
        public decimal Ballance { get; set; } //حساب ریال  مانده 

        private string _shamsiDate;

        public string ShamsiDate
        {
            get
            {
                if (_shamsiDate == null)
                {
                    DateTime date = DateTime.ParseExact(Filedate, "yyyyMMdd", CultureInfo.InvariantCulture);
                    _shamsiDate = date.ToString("yyyy/MM/dd");
                }
                return _shamsiDate;
            }
            set
            {
                _shamsiDate = value;
            }
        }


    }
}
