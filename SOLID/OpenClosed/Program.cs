// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
//Bir nesne ......gelişime...... açık ......değişime...... kapalı

//Bir nesnenin bir fonksiyonunun yeni bir davranışı ya da işlevsel akışı olduğunda o fonksiyonu değiştirmek zorunda kalıyorsanız, prensibi ihlal ediyorsunuz demektir.

Customer customer = new Customer() { Card =new PremiumCard(), Name = "Türkay Ürkmez" };
OrderManagement orderManagement = new OrderManagement() { Customer = customer };
Console.WriteLine(orderManagement.GetDiscountedPrice(1000));
