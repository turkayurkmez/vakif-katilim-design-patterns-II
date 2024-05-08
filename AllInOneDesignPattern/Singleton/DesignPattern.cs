using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	/*
	 * Problem:
	 *   Bir sınıfınız var fakat bu sınıftan sadece ve sadece 1 adet instance almanız gerekiyor. Bunu nasıl sağlarsınız?
	 *   
	 * Çözüm:
	 *   Bu sınıfın 
	 *    1. Constructor'una sınıf dışından  kimse erişemesin.
	 *    2. Nesne üretici, static bir metot olsun.
	 */


	public interface IConfigurator
	{
        string EmailAddress { get; set; }
        int Port { get; set; }
    }
	public class Configurator : IConfigurator
	{
        public string EmailAddress { get; set; }
        public int Port { get; set; }

        private Configurator()
        {
            
        }

		private static Configurator instance;
		public static Configurator CreateInstance()
		{
			if (instance == null)
			{
				instance = new Configurator();
			}
			return instance;
		}
    }


    //public static class AnotherConf : IConfigurator
    //{
    //    public string EmailAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}

}
