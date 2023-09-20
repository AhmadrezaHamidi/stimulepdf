using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;
using Zamin.EndPoints.Web.Controllers;
using stimulepdf.Models;
using MySqlX.XDevAPI.Relational;
using Microsoft.AspNetCore.Hosting;
using Stimulsoft.Base;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Export;
using MySqlX.XDevAPI.Common;

namespace stimulepdf.Controllers
{
    [Route("api/[controller]")]
    public class StimuleController : BaseController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration Configuration;

        public StimuleController(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            Configuration = configuration;
        }
        #region   خلاصه حسابPDF

        [HttpGet("kholasehHesabPDF")]
        public async Task<IActionResult> kholasehHesabPDF()
        {
            StiReport report = new StiReport();
            string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:kholasehHesab"]);
            var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
            report.Load(reportPath);

            #region data for mrt file
            List<SummaryResult> Result = new List<SummaryResult>
            {
                new SummaryResult()
                {
                    row=1,
                    accno="5898774454566",
                    accname="سعید رضایی",
                    Lasttrnsdate="14020427",
                    Filedate="14020212",
                    Ballance=2200000000
                },
                   new SummaryResult()
                {
                    row=2,
                    accno="1234567893300",
                    accname="علی کاظمی",
                    Lasttrnsdate="14020422",
                    Filedate="14020209",
                    Ballance=2800000000
                },
                      new SummaryResult()
                {
                    row=3,
                    accno="123456789879",
                    accname="حمید لرستانی ",
                    Lasttrnsdate="14020517",
                    Filedate="14020710",
                    Ballance=1800000000
                },
            };

            SummaryHeader Header = new SummaryHeader()
            {

            };
          
            #endregion
            report.RegBusinessObject("SummaryResult", Result);
            report.RegBusinessObject("SummaryHeader", Header);
          
            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        #endregion

        #region  جست  و جوی اصلاعاتPDF

        [HttpGet("SearchingDataPDF")]
        public async Task<IActionResult> SearchingDataPDF()
        {
            StiReport report = new StiReport();
            string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:SearchingData"]);
            var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
            report.Load(reportPath);

            #region data for mrt file
            List<SearchingItemDataResult> Result = new List<SearchingItemDataResult>
            {
                new SearchingItemDataResult()
                {
                    row=1,
                    Descript="تست 1"
                },
                 new SearchingItemDataResult()
                {
                    row=2,
                    Descript="تست 2"
                }
            };

            SearchingDataHeader Header = new SearchingDataHeader()
            {
                AcctNo="124598789300",
                Date1="14010508",
                Date2="14020427",
                Amount="285000000",
                BranchCode="200"
            };
            #endregion

            report.RegBusinessObject("SearchingDataHeader", Header);
            report.RegBusinessObject("SearchingItemDataResult", Result);

            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        #endregion

        #region  صورت حساب قبوض دریافتیPDF

        [HttpGet("GetBillesGhobozPDF")]
        public async Task<IActionResult> GetBillesGhobozPDF()
        {
            StiReport report = new StiReport();
            string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:BillesGhoboz"]);
            var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
            report.Load(reportPath);

            #region data for mrt file
            List<BillesGhobozDataResult> Result = new List<BillesGhobozDataResult>
            {
                new BillesGhobozDataResult()
                {
                    row = 1,
                    BillId="12356",
                    PayDate="14010512"
                },
                  new BillesGhobozDataResult()
                {
                    row = 2,
                    BillId="78954",
                    PayDate="14020910"
                }
            };

            BillesGhobozDataHeader Header = new BillesGhobozDataHeader()
            {
                AcctNo="12685795",
                Date1="14010501",
                Date2="14020427",
                Amount="250000"
            };
            #endregion

            report.RegBusinessObject("BillesGhobozDataHeader", Header);
            report.RegBusinessObject("BillesGhobozDataResult", Result);

            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        #endregion

        #region قبض های پرداخت اینترنتیPDF

        [HttpGet("GetBillesInternetPDF")]
        public async Task<IActionResult> GetBillesInternetPDF()
        {
            StiReport report = new StiReport();
            string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:BillesInternet"]);
            var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
            report.Load(reportPath);

            #region data for mrt file
            List<BillesInternetResult> Result = new List<BillesInternetResult>
            {
                new BillesInternetResult()
                {
                    row = 1,
                    Date="14010503",
                    Mablagh="25990000"
                },
                  new BillesInternetResult()
                {
                    row = 2,
                    Date="14010803",
                    Mablagh="2750000"
                }
            };

            BillesInternetHeader Header = new BillesInternetHeader()
            {
                AcctNo = "12685795",
                Date1 = "14010501",
                Date2 = "14020427",
                Amount = "250000"
            };
            #endregion

            report.RegBusinessObject("BillesInternetHeader", Header);
            report.RegBusinessObject("BillesInternetResult", Result);

            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        #endregion

        #region صورتحساب تلفیقیPDF

        [HttpGet("GetConsolidatedInvoicePDF")]
        public async Task<IActionResult> GetConsolidatedInvoicePDF()
        {
            StiReport report = new StiReport();
            string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:ConsolidatedInvoice"]);
            var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
            report.Load(reportPath);

            #region data for mrt file
            List<ConsolidatedInvoiceResult> Result = new List<ConsolidatedInvoiceResult>
            {
                new ConsolidatedInvoiceResult()
                {
                    row=1,
                    Date="14010503",
                    Credit="25000",
                    Debit="82000"
                },
                new ConsolidatedInvoiceResult()
                {
                    row=2,
                    Date="140205007",
                    Credit="28000",
                    Debit="72000"
                },
            };

            ConsolidatedInvoiceHeader Header = new ConsolidatedInvoiceHeader()
            {
                AcctNo = "12685795",
                Date1 = "14010501",
                Date2 = "14020427",
                Amount = "250000"
            };
            #endregion

            report.RegBusinessObject("ConsolidatedInvoiceHeader", Header);
            report.RegBusinessObject("ConsolidatedInvoiceResult", Result);

            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        #endregion

        #region صورتحساب چکاوک

        [HttpGet("GetBillChakavakPDF")]
        public async Task<IActionResult> GetBillChakavakPDF()
        {
            StiReport report = new StiReport();
            string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:BillChakavak"]);
            var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
            report.Load(reportPath);

            #region data for mrt file
            List<BillChakavakDataResult> Result = new List<BillChakavakDataResult>
            {
                new BillChakavakDataResult()
                {
                    row=1,
                    CreditorIBAN="1265897",
                    ChequeID="123"

                },
                new BillChakavakDataResult()
                {
                    row=2,
                    CreditorIBAN="324897",
                    ChequeID="324"
                },
            };

            BillChakavakDataHeader Header = new BillChakavakDataHeader()
            {
                Accno = "12685795",
                date1 = "14010501",
                date2 = "14020427",
                amount = "250000"
            };

            #endregion

            report.RegBusinessObject("BillChakavakDataHeader", Header);
            report.RegBusinessObject("BillChakavakDataResult", Result);

            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        #endregion

        [HttpGet("TEST")]
        public async Task<IActionResult> TEST()
        { 
       StiReport report = new StiReport();
        string mrtFilePath = Path.Combine(_webHostEnvironment.WebRootPath, Configuration["PrintReport:SearchingData"]);
        var reportPath = StiNetCoreHelper.MapPath(this, mrtFilePath);
        report.Load(reportPath);

            //var datas = await _billPayingService.SearchingDataReport(
            //  input?.AcctNo,
            //  input?.TR_Type,
            //  input?.Date1,
            //  input?.Date2,
            //  input?.Amount,
            //  input?.serial,
            //  input?.BranchCode,
            //  input?.sort,
            //  input.PageNo);

            //var result = datas?.ToList();


            //var Header = new SearchingDataHeader(input.AcctNo,
            //    input.Date1, input.Date2);

            //var dats = new SearchingData(result,Header);
            
            //report.RegBusinessObject("SearchingData", dats);
            //report.RegBusinessObject("SearchingDataHeader", Header);
            //report.RegBusinessObject("GetSearchingItemResultDataDto", result);


            return StiNetCoreReportResponse.PrintAsPdf(report);}
    }
}
