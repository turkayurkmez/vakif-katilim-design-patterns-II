using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /*
     * Sistem harici bir bileşenle bilgi alışverişi yapmaktadır. Ancak harici bileşen, size istediğinizden farklı türde veri göndermektedir. Bu problemi nasıl çözersiniz
     * 
     * 
     */
    //1. Client: Eski ve değişmesi mümkün olmayan iş mantığı burada
    //2. Client Interface: diğer sınıfların beklentisiyle iş birliği yapabilecek arayüz.
    //3. Service: Harici bileşende çalışmasını istediğiniz fonksiyon.
    //4. Adaptör: Serviste olanı client'in istediğine dönüştüren yapı


    //Senaryo:
    /*
     *  Eski yazılmış bir obje;  geriye XML dönmektedir.
     *  Ancak bizim uygulamamıza JSON gerekmekte.
     *  *  
     */


    //2.:

    public interface IDataTransfer
    {
        public string GetData();
      
    }

    //3. 
    public class XMLSource : IDataTransfer
    {
        public string GetData()
        {
            return "XML Verisi....";
        }
    }

    //4.:
    public class JsonAdapter : IDataTransfer
    {
        private readonly XMLSource adaptee;
        public JsonAdapter(XMLSource source)
        {
            this.adaptee = source;
        }
        public string GetData()
        {
            return adaptee.GetData();
        }
    }

}
