using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     * Fabrika oluşturan bir fabrikaya ihtiyacınız varsa?
     * 
     *     Senaryo:
     *       Ekranda çizilen bir formun (textbox ve button çizimleri), istenen platforma (HTML, Android, Windows, IOS vs) dönüştüren bir uygulamanın mimarisi nasıl olur?
     *       
     *       HTML                   Android         Windows          IoS
     *         - Textbox (input)    
     *         - Button (button)
     *         
     *         
     * Çözüm ve yapı
     *   1. Nihai ürünün (Button) abstract ya da interface'i ile başlayın.
     *   2. Bu ürünü, platforma göre çoğaltın (AndroidButton HTMLButton)
     *   
     *   3. Platforma göre button veya textbox üretecek olan abstract factory sınıfını yazın (Ya android ya da html). Bu sınıf içinde; 1. Adımda belirtilen nesneyi üretecek fonksiyonlar olmalı.
     *   4. 3. Adımda yazdığınız sınıfı miras alan (Android ve HTML) sınıfları yazın abstract üretim fonksiyonları platforma göre üretmelidir.
     *   
     *   5. Nesne üretme isteğini ve sonucu stabil hale getir.
     *    
     */
    //1. 
    public interface IConnection
    {
        void Open();
    }
    public interface ICommand
    {
        void Execute();
    }

    //2.
    public class MSSqlConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("MS SQL ile bağlantı kuruldu!");
        }
    }

    public class OracleConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Oracle ile bağlantı kuruldu!");
        }
    }

    public class MSSqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("MSSQL komutu çalıştı");
        }
    }

    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle komutu çalıştı");
        }
    }

    //3:
    public interface IDbFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
    }

    //4.
    public class MSSQLDbFactory : IDbFactory
    {
        public ICommand CreateCommand()
        {
            return new MSSqlCommand();
        }

        public IConnection CreateConnection()
        {
            return new MSSqlConnection();
        }
    }

    public class OracleDbFactory : IDbFactory
    {
        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
    //5
    public class DbFactoryCreator<T> where T: class, IDbFactory, new()
    {
        private T factory = new T();
        public void ConnectAndExecute()
        {
            factory.CreateConnection().Open();
            factory.CreateCommand().Execute();
        }
    }
}
