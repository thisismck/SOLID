namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liskov Substitution Principle
            // Bir sınıfın alt sınıfları, üst sınıfın yerine kullanılabilmelidir.
            // Yani bir sınıfın alt sınıfları, üst sınıfın tüm özelliklerini kullanabilmelidir.
            //
            // Örneğin bir kare ve dikdörtgen sınıfı düşünelim.
            // Kare sınıfı, Dikdörtgen sınıfından türetilmiş olsun.
            // Kare sınıfı, Dikdörtgen sınıfının tüm özelliklerini kullanabilmelidir.
            // Ancak Kare sınıfı, Dikdörtgen sınıfının özelliklerini değiştiremez.
            //  
            // Bu durumda Liskov Substitution Principle'a uymuş oluruz.

            //Square square = new Square();
            //square.Width = 5;
            //square.Height = 5;
            //Console.WriteLine($"Square Area: {square.Area()}");

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            Console.WriteLine("Hello, World!");
        }
    }
}
