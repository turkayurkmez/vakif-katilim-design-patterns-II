// See https://aka.ms/new-console-template for more information
using Constructor;

Console.WriteLine("Hello, World!");

Report report = new Report("C:\\Users\\turka\\OneDrive\\Belgeler\\data.xlsx");
Console.WriteLine(report.ReportType);

Report salesReport = new Report("C:\\Users\\turka\\OneDrive\\Belgeler\\data.xlsx", "HTML");

