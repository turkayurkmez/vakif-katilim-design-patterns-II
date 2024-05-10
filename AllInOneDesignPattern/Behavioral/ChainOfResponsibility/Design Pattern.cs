using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /*
     * Problem:
     * 
     *   Bir işlemin gerçekleşmesi için birkaç adımdan oluşan bir "handler" serisine ihtiyacınız var. Örneğin, bir web uygulamasında Http isteğinin çeşitli değerlendirmelerden geçmesi gibi
     *   Http Request
     *            - Güvenlik
     *            - Kimlik
     *            - Yetkilendirme
     *            - Hata yönetimi
     *            - Durum Yönetimi
     *            
     *  Çözüm:
     *     Bu handler'ları bir zincirin halkalarına dönüştürün.
     *     
     * Senaryo: Bir otel rezervasyon sisteminiz var 
     *           1. Rezervasyon bir kişi adına olmalı
     *           2. Rezervasyon tarihleri uygun olmalı
     *           3. Db'ye kaydedilmeli
     */

    public class Reservation
    {
        public string Owner { get; set; }
        public DateOnly CheckIn { get; set; }
        public DateOnly CheckOut { get; set; }
        public int ParticipantsCount { get; set; }
        public string City { get; set; }
        public bool? HasOwner { get; set; }
    }

    public interface IHandler
    {
        public IHandler Next { get; set; }

        public void Handler(Reservation reservation);


    }

    public abstract class HandlerBase : IHandler
    {
        public IHandler Next { get; set; }

        public HandlerBase()
        {

        }

        public HandlerBase(IHandler handler)
        {
            Next = handler;
        }

        public abstract void Handler(Reservation reservation);

    }

    public class CheckOwnerHandler : HandlerBase
    {
        public CheckOwnerHandler()
        {
        }

        public CheckOwnerHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (string.IsNullOrEmpty(reservation.Owner))
            {
                throw new ArgumentException("Reservasyon kimin adına?");
            }
            reservation.HasOwner = true;
            Next.Handler(reservation);

        }
    }

    public class CheckInAndCheckOutDateHandler : HandlerBase
    {
        public CheckInAndCheckOutDateHandler()
        {
        }

        public CheckInAndCheckOutDateHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (reservation.CheckIn > reservation.CheckOut)
            {
                throw new ArgumentException("Rezervasyon tarihleri hatalı");
            }

            //Db'de otelin uygun salonu olup olmadığına bak
            Next.Handler(reservation);
        }
    }

    public class SaveToDatabaseHandler : HandlerBase
    {
        public SaveToDatabaseHandler()
        {
        }

        public SaveToDatabaseHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handler(Reservation reservation)
        {
            Console.WriteLine($"{reservation.Owner} tarafından {reservation.CheckIn.ToShortDateString()} tarihinde rezervasyon kaydedildi");
        }
    }
}
