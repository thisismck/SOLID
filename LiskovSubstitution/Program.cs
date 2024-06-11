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
            
            

            Console.WriteLine("Hello, World!");
        }
    }
}
