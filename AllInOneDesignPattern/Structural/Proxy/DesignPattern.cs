using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /*Problem:
     * Bir nesneye gönderilen istekleri -bir biçimde- denetlemeniz gerekmektedir. Yani "vekil" olarak atamanız ve nesne yerine vekilin işyapmasını istiyorsunuz....
     * 
     * 
     */

    public interface IMath
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
    }

    public class RealMath : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }


    }

    public class ProxyMath : IMath
    {
        private RealMath math;

        public ProxyMath(RealMath math)
        {
            this.math = math;
        }

        public double Add(double x, double y)
        {
            if (x<0 || y<0)
            {
                Console.WriteLine("Negatif sayılar math üzerinde işlem yapamazlar");
                return 0;
            }
            return math.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return math.Subtract(x, y);
        }
    }
}
