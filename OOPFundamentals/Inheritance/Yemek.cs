using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public List<string> Malzemeler { get; set; }
        public int PismeSuresi { get; set; }
        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek {PismeSuresi} dakikada hazırlandı");
        }
        public virtual void SunumYap()
        {
            Console.WriteLine($"ve {GetType().Name} isimli yemek, yanında pilav ile sunuldu");
        }


    }

    public class Corba : Yemek
    {
        public bool KitirEkmekVarMi { get; set; }

    }


    public class DomatesCorbasi : Corba
    {
        public bool KasarOlsunMu { get; set; }
        public DomatesCorbasi()
        {
            PismeSuresi = 5;
        }
    }

    public class ZeytinYagli: Yemek
    {
        public bool SogukMu { get; set; }
    }

    public class Kereviz: ZeytinYagli
    {
        public Kereviz()
        {
            PismeSuresi = 30;
        }

    }

    public class Tatli: Yemek
    {
        public bool SerbetliMi { get; set; }
        public override void SunumYap() => Console.WriteLine($"{GetType().Name}, yanında dondurmayla sunuldu");
    }

    public class Kalburabasti : Tatli
    {
        public Kalburabasti()
        {
            PismeSuresi = 40;
        }

       
    }

}
