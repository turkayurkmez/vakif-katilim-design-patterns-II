using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	/*
   * Problem:
   *    Bir sınıfın constructor'u çalışması çok zaman alıyorsa, aynı sınıftan diğer nesneleri üretmeyi hızlandırabilir misiniz?
   *
   * Çözüm:
   * Sadece 1 tane nesneyi bellekte oluşturun. Sonra, O nesneyi klonlayın
   *
   *
   * 1. Adım: ICloneable isminde bütün klonlama ihtiyacı için kullanılacak bir interface oluştur:
   */

	public class Color : ICloneable
	{
        public int R { get; set; } = 0;
		public int G { get; set; } = 0;
		public int B { get; set; } = 0;

        public Color()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Thread.Sleep(2000);
            Console.WriteLine(DateTime.Now.ToLongTimeString());


        }

        public object Clone()
        {
            //Genellikle kompleks tipler için tercih edilen Deep Clone da burada kullanılabilir.
            return MemberwiseClone();
        }
        public override string ToString()
        {
            return $"{DateTime.Now.ToLongTimeString()} {R} {G} {B}";
        }
    }

}
