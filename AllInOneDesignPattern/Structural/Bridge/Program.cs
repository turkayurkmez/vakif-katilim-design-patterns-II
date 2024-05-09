// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");
SalesReport salesReport = new SalesReport();
salesReport.ReportType = new PDFReport();
salesReport.ReportType = new ExcelReport();
