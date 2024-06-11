using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ReportNotifiers
    {
        public INotifier mailSender2;
        private readonly INotifier mailSender3;
        public ReportNotifiers(INotifier mailSender)
        {
            this.mailSender3 = mailSender;
        }
        public void SendReport(INotifier mailSender)
        {
            //MailSender mailSender = new MailSender();
            mailSender.Send();
            Console.WriteLine("Report sent");
        }
        public void SendReport2()
        {
            //MailSender mailSender = new MailSender();
            //mailSender2.Send();
            Console.WriteLine("Report sent");
        }

        public void SendReport3()
        {
            mailSender3.Send();
            Console.WriteLine("Report sent");
        }


    }


    public class MailSender : INotifier
    {
        public void Send()
        {
            Console.WriteLine("Mail sent");
        }
    }

    public class GeneralSender : INotifier
    {
        public void Send()
        {
            Console.WriteLine("General sent");
        }
    }
    public class WhatsAppSender : INotifier
    {
        public void Send()
        {
            Console.WriteLine("WhatsApp sent");
        }
    }

    public interface INotifier
    {
        void Send();
    }

}
