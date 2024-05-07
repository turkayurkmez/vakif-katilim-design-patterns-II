// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

//Dependency: Bir ilişki türü; iki nesnenin arasında bulunabilecek "olmazsa olmaz" türünden bir bağ oluşmasını sağlar.
//Inversion: Tersine çevirme (invert)

/*
 * Bir nesne, bağımlı olduğu diğer nesneyi üretmemeli; nesne dışardan atanmalı.
 *     mouse                  pil                    ; pil   
 * 
 * Bir sınıfın bir çok işlevinde (fonksiyon) aynı instance (object - nesne) kullanılıyorsa; muhtemelen prensibi ihlal ediyorsunuz demektir. 
 */

MailSender mailSender = new MailSender();
WhatsAppSender   whatsAppSender = new WhatsAppSender(); 
TelegramSender telegramSender = new TelegramSender();
Report report = new Report(whatsAppSender);
report.Send("abc");

Report report2 = new Report(telegramSender);
report2.Send("abc");

Report report1 = new Report(mailSender);
report1.Send("abc");


