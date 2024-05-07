// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 *  Eğer iki sınıf birbirinden türüyorsa (aralarında "inheritance" ilişkisi varsa), birbirlerinin yerine kullanılabilir olmalıdırlar.
 *  
 *  Yemek sonYemegiGetir();
 *  
 *  Eğer miras alan (derived) sınıfın nesnesi, miras veren (base) sınıfın nesnesinin davranışını değiştirecek (hata oluşacak denetim yapılacak ya da bunların dışında bir yan etki oluşturacak) şekilde implemente ediyorsa ilkeyi ihlal ediyorsunuz demektir.
 *  
 */
//var dortgen = Geometry.GetRectangle();
//dortgen.Width = 8;
//dortgen.Height = 10;

var dortgen = Geometry.GetRectangle(5);
Console.WriteLine(dortgen.GetArea());