using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /*
     * Problem:
     *  Dikey genişleme (implementasyon), eğer hatalı tasarlanırsa; inheritance kaosu meydana gelebilir. Bu nasıl önlenir
     *  
     *  Çözüm:
     *  is a / has a karşılaştırması
    */

    public class Report
    {
        public ReportType ReportType { get; set; }
    }

    public class ReportType
    {

    }
    public class PDFReport: ReportType
    {

    }
    public class ExcelReport: ReportType
    {

    }

    public class SalesReport: Report    
    {
        
    }

    public class FinanceReport: Report
    {

    }

    //public class FinancePdfReport: FinanceReport
    //{
        
    //}
    //public class FinanceExcelReport : FinanceReport
    //{

    //}

    //public class SalesPDFReport : SalesReport
    //{

    //}

    //public class SalesExcelReport : SalesReport
    //{

    //}

    //public class SalesHtmlReport: SalesReport
    //{

    //}
}
