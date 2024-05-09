using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /*
     * Çok fazla nesne tarafından yapılacak çok karmaşık süreçlerden oluşan bir işi nasıl basitleştirirsiniz? 
     * 
     * Çözüm:
     * 
     * Karmaşık işleri arkaya itip, bir sınıf ile "cephe" oluşturursunuz.
     *  
     */

    public class Customer
    {
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Stock { get; set; }

    }

    public class Order
    {
        public Order()
        {
            Id = 8;
        }
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateOnly OrderDate { get; set; }
    }

    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
    //Kişisel not: elbette "facade" kelimesi sınıfta olmamalı ama işin önemli kısmını belirtmek için sembolik olarak bu ismi verdim:
    public class OrderServiceFacade
    {
        
        public void CreateOrder(Customer customer, List<Product> products, int quantity)
        {
            Order order = new Order();
            order.Customer = customer;

            List<OrderItem> orderItems = new List<OrderItem>();

         

            products.ForEach(p =>
            {
                orderItems.Add(new OrderItem { OrderId = order.Id, ProductId = p.Id, Quantity = quantity });
                Console.WriteLine($"{customer.Name}, {order.OrderDate} tarihinde, {p.Name} isimli ürünü satın aldı");
                Console.WriteLine($"{p.Name} isimlü ürünün stoğundan {quantity} adet düşüldü");
            });
          





        }
    }




}
