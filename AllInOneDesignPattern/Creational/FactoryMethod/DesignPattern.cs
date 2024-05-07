using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IVisitPoint
    {
        public decimal Lang { get; set; }
        public decimal Long { get; set; }
        public string Name { get; set; }
    }

    //1. Product: Fabrikanın üreteceği ürünün ortak interface'ni çıkart
    public interface IMap
    {
        List<IVisitPoint> VisitPoints { get; set; }
    }

    //2. Concrete (gerçek) nesneler: Product interface'lerini implemente eden sınıflar:
    public class ReligionMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; } = new List<IVisitPoint>();

    }

    public class CultureMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; } =new List<IVisitPoint>();
    }

    //3. Creator sınıfı: factory method (fonksiyonunu) kullanan sınıftır. Bu fonksiyonun döndürdüğü değer, Product Interface'i olmalıdır.

    public abstract class MapGenerator
    {
        public MapGenerator()
        {
            createMap();
        }
        protected IMap map;
        protected abstract void createMap();

        public void Show()
        {
            map.VisitPoints.ForEach(vp=>Console.WriteLine(vp.Name));
        }


    }

    //4. Create abstract sınıfını concrete yapılara dönüştür:

    public class ReligionMapCreator : MapGenerator
    {
        protected override void createMap()
        {
            ReligionMap religionMap = new ReligionMap();
            religionMap.VisitPoints.Add(new SultanAhmetCamii());
            religionMap.VisitPoints.Add(new AyasofyaCamii());

            this.map = religionMap;
        }
    }

    public class CultureMapCreator : MapGenerator
    {
        protected override void createMap()
        {
            CultureMap cultureMap = new CultureMap();
            cultureMap.VisitPoints.Add(new YerebatanSarnici());
            cultureMap.VisitPoints.Add(new TopkapiSarayi());

            this.map = cultureMap;
        }
    }

    public class SultanAhmetCamii : IVisitPoint
    {
        public decimal Lang { get; set; }
        public decimal Long { get; set; }
        public string Name { get; set; } = "Sultanahmet";
    }

    public class AyasofyaCamii : IVisitPoint
    {
        public decimal Lang { get; set; }
        public decimal Long { get; set; }
        public string Name { get; set; } = "Ayasofya";
    }


    public class TopkapiSarayi : IVisitPoint
    {
        public decimal Lang { get; set; }
        public decimal Long { get; set; }
        public string Name { get; set; } = "Topkapi Sarayi";
    }

    public class YerebatanSarnici : IVisitPoint
    {
        public decimal Lang { get; set; }
        public decimal Long { get; set; }
        public string Name { get; set; } = "Yerebatan sarnıcı";

    }

}
