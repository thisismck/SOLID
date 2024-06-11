namespace OpenClosedPrensible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var customer = new Customer
            {
                Name = "John Doe",
                CardType = new GoldCard(),
            };
             var order=   new OrderManagement
                {
                    Customer = customer
                }.GetDiscountedPrice(1000);

            Console.WriteLine(order);
            Console.WriteLine(order);
        }
    }
}
/**
 **
 ** Open-Closed Principle
 ** Bir nesne hatta tüm yazılım varlıkları genişletmeye açık ancak değişikliklere kapalı olmalıdır.
 ** Yani mevcut kodu değiştirmeden yeni özellikler ekleyebilmeliyiz.
 ** 
 ** Örneğin bir araba sınıfı düşünelim. Araba sınıfı içerisinde birçok özellik ve metot bulunmaktadır.
 ** Araba sınıfına yeni bir özellik eklemek istediğimizde sınıfın içerisinde değişiklik yapmamız gerekmektedir.
 ** Bu durumda Open-Closed Principle'a uymamış oluruz.
 ** 
 ** Bu durumu düzeltmek için Araba sınıfını genişletmeye açık ancak değişikliklere kapalı hale getirmemiz gerekmektedir.
 ** 
 ** 
 **/