namespace Constructor
{
    public class Report : IDisposable
    {
        public string ReportType { get; set; }
        public string ExcelFilePath { get; set; }

        public Report(string path) : this(path, "PDF")
        {



        }

        public Report(string path, string reportType)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"{path} adresinde dosya bulunamadı!");
            }
            ExcelFilePath = path;
            ReportType = reportType;
        }

        public void Dispose()
        {

            ExcelFilePath = string.Empty;
            ReportType = string.Empty;
        }
    }
}
