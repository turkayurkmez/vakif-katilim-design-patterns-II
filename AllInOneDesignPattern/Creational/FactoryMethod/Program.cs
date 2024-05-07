// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");

/*
 * Belirli bir işlevi, belirli nesneler ile gerçekleştiren bir sınıf olsun. Gelecekte işlevin aynen kalmasını fakat, nesnelerin değişmesini istediğiniz bir an geldiğinde; bu değişimi sistemi bozmadan nasıl oluşturursunuz?
 * 
 * 
 * Bir turistik harita üretmek istiyorsunuz.
 * Bu harita turistin, amacına göre "gidilmesi gereken yerler"i gösterecek.
 * 3 Kategori.  
 *   1. Kültür turizmi
 *         - Müzeler
 *         - Sergiler
 *         
 *   2. İnanç Turizmi
 *         - Camii
 *         - Kilise
 *                  
 *   3. Eğlence Turizmi
 *         - Bar
 *         - Kafe
 *        
 *   4. Doğa Turizmi:
 *         
 *
 *  
 *       
 * 
 * 
 */

ReligionMapCreator religionMap = new ReligionMapCreator();
religionMap.Show();

CultureMapCreator cultureMapCreator = new CultureMapCreator();
cultureMapCreator.Show();
