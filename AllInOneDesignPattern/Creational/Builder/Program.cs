// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");


ReportBuilder reportBuilder = new ReportBuilder();
reportBuilder.Builder = new WeeklyEffectiveDevelopmentReportBuilder();
reportBuilder.Build();
var report = ((WeeklyEffectiveDevelopmentReportBuilder)reportBuilder.Builder).GetReport();
Console.WriteLine(report.Title);
Console.WriteLine(report.Data);
Console.WriteLine(report.Graph);