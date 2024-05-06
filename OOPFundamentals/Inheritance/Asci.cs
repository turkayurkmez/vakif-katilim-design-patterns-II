using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Asci
    {
        public string Ad { get; set; }
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
            yemek.SunumYap();
        }

        public void Hazirla(Yemek yemek)
        {

        }
    }
}
