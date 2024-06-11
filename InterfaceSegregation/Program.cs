namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface Segregation Principle
            // English explanation
            // A client should never be forced to implement an interface that it doesn't use.
            // Instead of having one big interface, we should have multiple smaller interfaces.
            // This way, the client can implement only the methods it needs.

            // Türkçe açıklama
            // Bir istemcinin kullanmadığı bir arayüzü uygulamaya zorlanmamalıdır.
            // Büyük bir arayüz yerine, birden fazla küçük arayüze sahip olmalıyız.
            // Bu şekilde, istemci sadece ihtiyaç duyduğu yöntemleri uygulayabilir.

            // Example
            // We have a printer that can print, scan, and fax.
            // We have an interface that has all these methods.
            // But the client only needs to print and scan.
            // So, we should have two interfaces, one for printing and one for scanning.

            Console.WriteLine();
        }
    }
}
