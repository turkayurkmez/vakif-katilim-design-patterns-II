using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /*
  * Problem:
  * 
  * Birçok alanın ve iç içe geçmiş nesnelerin oluşturduğu zorlu ve adım adım başlatılması gereken karmaşık bir nesne düşünün. Böyle bir karmaşayı nasıl düzenleriz?
  * 
  * Çözüm:
  * Her iç nesnenin üretimini ayır. Bir başka bileşen, bu üetimi denetlesin ve bir araya getirsin.
  * 
  * Senaryo:
  * Çok karmaşık bir hafalık rapor ihtiyacınız var. Çok büyük bir db yapısında çalışıyorsunuz. Bu ihtiyaca göre değişebilen raporu nasıl çözersiniz?
  * 
  * Yapısı:
  * 
  * 1. Builder interface'i ile başlanmalı. Her builder için ortak olan oluşturma adımlarını belirler
  * 
  */

    //1. 
    public interface IReportBuilder
    {

        void BuildTitle();
        void BuildData();
        void BuildGraph();



    }

    //2. Bu builder'i farklı builder'lar  için implemente et.

    public class WeeklyEffectiveDevelopmentReportBuilder : IReportBuilder
    {
        private Report report;
        public WeeklyEffectiveDevelopmentReportBuilder()
        {
            report = new Report();
        }
        public Report GetReport()
        {
            return report;
        }

        public void BuildData()
        {
            report.Data = "Yazılımcıların isimleri ve task tamamlama oranları";
        }

        public void BuildGraph()
        {
            report.Graph = "Pasta grafik raporu çizildi";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık Görev Takip Raporu";
        }
    }

    //3. Builder ne üretecek? Üreteceği nesneye Product adı verelim.
    public class Report
    {
        public string Title { get; set; }
        public string Data { get; set; }
        public string Graph { get; set; }
    }

    //4. Director sınıfı,(raporun) yapım adımlarını ve çağrı sırasını tuttuğunuz yönetici. 
    public class ReportBuilder
    {
       // private IReportBuilder builder;

        public IReportBuilder Builder { get; set; }

        public void Build()
        {
            Builder.BuildTitle();
            Builder.BuildData();
            Builder.BuildGraph();

        }


    }
}
