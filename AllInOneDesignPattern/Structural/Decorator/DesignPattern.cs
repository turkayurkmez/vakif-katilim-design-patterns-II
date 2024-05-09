using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /*
     * Problem:
     *    
     *    Çekirdek bir nesneye, sürekli yeni işlev veya özellik kazandırıyoruz. Özellikler kombine olabileceğinden miras alamıyorsunuz. Bellekte zaten var olan nesneye özelliği nasıl eklersiniz.
     *    
     *    
     */

    public interface IMail
    {
        void Send();
    }

    public class Mail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Mail oluşturuldu ve gönderildi");
        }
    }

    public abstract class MailDecorator : IMail
    {
        protected readonly IMail mail;

        public MailDecorator(IMail mail)
        {
            this.mail = mail;
        }
        public virtual void Send()
        {
          mail.Send();
        }
    }

    public class SignedMail : MailDecorator
    {
        public SignedMail(IMail mail) : base(mail)
        {
        }

        public void SignAndSend()
        {
            Console.WriteLine("Mail imzaiandı");
            this.mail.Send();
        }

    }

    public class CryptedMail : MailDecorator
    {
        public CryptedMail(IMail mail) : base(mail)
        {
        }

        public void CryptedSend()
        {
            Console.WriteLine("Eposta şifrelendi");
            this.mail.Send();
        }
    }

    public class ArchivedMail : MailDecorator
    {
        public ArchivedMail(IMail mail) : base(mail)
        {
        }

        public void Archive()
        {
            Console.WriteLine("Mail arşive taşındı");
        }
    }
}
