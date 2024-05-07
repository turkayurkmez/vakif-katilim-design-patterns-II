using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Report
    {
        private ISender mailSender;

        public Report(ISender mailSender)
        {
                this.mailSender = mailSender;
        }

        public void Send(string to)
        {
           
            mailSender.Send(to);
        }
    }

    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)=>Console.WriteLine("Mail ile gönderildi");
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("WhatsApp ile gönderildi");

        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram ile gönderildi");

        }
    }



}
