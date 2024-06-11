namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dependency Inversion Principle
            // English explanation
            // High-level modules should not depend on low-level modules.
            // Both should depend on abstractions.
            // Abstractions should not depend on details.
            // Details should depend on abstractions.
            // 
            // Türkçe açıklama
            // Yüksek seviye modüller düşük seviye modüllere bağlı olmamalıdır.
            // Her ikisi de soyutlamalara bağlı olmalıdır.
            // Soyutlamalar ayrıntılara bağlı olmamalıdır.
            // Ayrıntılar soyutlamalara bağlı olmalıdır.
            //
            // Example
            // We have a class that sends emails.
            // We have a class that logs messages.
            // The email sender class should not depend on the logger class.
            // Both classes should depend on an interface.
            // The interface should not depend on the details.
            // The details should depend on the interface.

            ReportNotifiers reportNotifiersM = new ReportNotifiers(new MailSender());

            ReportNotifiers reportNotifiersW = new ReportNotifiers(new WhatsAppSender());

            ReportNotifiers reportNotifiersG = new ReportNotifiers(new GeneralSender());
            reportNotifiersM.SendReport2();
            reportNotifiersW.SendReport3();
            reportNotifiersG.SendReport2();
            reportNotifiersM.SendReport3();



            Console.WriteLine("Hello, World!");
        }
    }
}
