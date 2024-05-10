// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");

CheckOwnerHandler response1 = new CheckOwnerHandler();
CheckInAndCheckOutDateHandler response2 = new CheckInAndCheckOutDateHandler();
SaveToDatabaseHandler response3 = new SaveToDatabaseHandler();

response1.Next = response2;
response2.Next = response3;

Reservation reservation = new Reservation() {  Owner="Türkay Ürkmez ", CheckIn=new DateOnly(2024,5,15), CheckOut = new DateOnly(2024,5,19), City="Roma" };

response1.Handler(reservation);