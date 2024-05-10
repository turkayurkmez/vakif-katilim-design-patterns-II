using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /*
     * Problem:
     * 
     * Bir uygulama, kullanıcıdan aldığı çeşitli komutları çalıştırmaktadır. Bu komutlar her zaman aynı olmak veya aynı sırayla çalışmak zorunda değil (yani her an değişebilir). Komutun ne olduğunu bilmese de çalıştıran bir sistemi nasıl oluştururuz?
     * 
     * 
     */
    public interface ICommand
    {
        void Execute();
    }

    public class DbCommandReceiver
    {
        public void CreateNewOrder(string customer) => Console.WriteLine("Yeni bir sipariş oluşturuldu");

        public void UpdateStock(string products) => Console.WriteLine("Ürünlerin stokları güncellendi");
    }

    public class CreateOrderCommand : ICommand
    {

        private DbCommandReceiver receiver;
        private string customer;

        public CreateOrderCommand(DbCommandReceiver receiver, string customer)
        {
            this.receiver = receiver;
            this.customer = customer;
        }

        public void Execute()
        {
           receiver.CreateNewOrder(customer);
        }
    }

    public class UpdateStockCommand : ICommand
    {
        private DbCommandReceiver receiver;
        private string products;

        public UpdateStockCommand(DbCommandReceiver receiver, string products)
        {
            this.receiver = receiver;
            this.products = products;
        }

        public void Execute()
        {
            receiver.UpdateStock(products);
        }
    }

    public class CommandInvoker
    {
        /*Bu nesne, hangi komutların çalıştığını bilmiyor*/
        private Queue<ICommand> commands = new Queue<ICommand>();
        public void Add(ICommand command) => commands.Enqueue(command);

        public void  Clear() => commands.Clear();
        public void ExecuteCommands()
        {
            while (commands.Count >0)
            {
                commands.Dequeue().Execute();
            }
        }
    }

}
