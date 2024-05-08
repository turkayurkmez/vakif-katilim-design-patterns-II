// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");


string[] days = { "Pazartesi", "Salı", "Çarşamba" };
days.Clone();
Console.WriteLine("Çalışması için bir tuşa basınız...");
Console.ReadLine();
Color black = new Color();
Console.WriteLine(black);
Color white = new Color() { B=255, G = 255, R =255};
Console.WriteLine(white);

Color red = (Color)black.Clone();
red.R = 255;
red.G = 0;
red.B = 0;

Console.WriteLine(red);


