// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Product product = new Product();
int testPrice = 15;
//if (testPrice < 0)
//{
//    throw new Exception("Price değeri negatif olamaz");
//}
product.SetPrice(testPrice);
product.Name = "Güneş Gözlüğü";
//product.Description = "Rayban";
Console.WriteLine(product.Description);
product.IncreaseStock(250);
Console.WriteLine(product.Stock);



