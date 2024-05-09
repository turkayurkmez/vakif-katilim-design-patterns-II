// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

OrderServiceFacade orderService =  new OrderServiceFacade();
Customer customer = new Customer { Name = "Türkay" };
List<Product> products = new()
{
    new(){ Id=1, Name="Ürün 1", Stock = 100},
    new(){ Id=2, Name="Ürün 2", Stock = 100},
    new(){ Id=3, Name="Ürün 3", Stock = 100},

};


orderService.CreateOrder(customer, products, 2);