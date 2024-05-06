namespace AbstractAndInterface
{
    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public void Copy(string from, string to) => Console.WriteLine("Kopyalandı");
        public void Move(string from, string to) => Console.WriteLine("Taşındı");

        public abstract void Load();


        public abstract void Save();


        //Her dokümanın çıktısının alınmasını istemiyoruz!
        //public abstract void Print();


    }

    public class PdfDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }



        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} çıktısı alındı");
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} çıktısı alındı");

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }


    public class PrintDocument
    {
        public void Print(IPrintable document) => document.Print();
    }

}
