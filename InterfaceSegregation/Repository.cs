using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
    }

    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        //IEnumerable<T> SearchByName(string name);
    }

    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
     //OR

    public interface ISearchable<T> where T : class
    {
        IEnumerable<T> SearchByName(string name);
    }
    public class ProductRepository : IProductRepository //, ISearchable<Product>
    {
        public void Add(Product entity)
        {
            Console.WriteLine("Product added");
        }

        public void Delete(Product entity)
        {
            Console.WriteLine("Product deleted");
        }

        public IEnumerable<Product> GetAll()
        {
            return new List<Product>();
        }

        public Product GetById(int id)
        {
            return new Product();
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return new List<Product>();
        }

        public void Update(Product entity)
        {
            Console.WriteLine("Product updated");
        }
    }
    public class OrderRepository: IRepository<Order>
    {
        public void Add(Order entity)
        {
            Console.WriteLine("Order added");
        }

        public void Delete(Order entity)
        {
            Console.WriteLine("Order deleted");
        }

        public IEnumerable<Order> GetAll()
        {
            return new List<Order>();
        }

        public Order GetById(int id)
        {
            return new Order();
        }

        public void Update(Order entity)
        {
            Console.WriteLine("Order updated");
        }
    }

    public class SearchComponent<T> where T : class
    {
        public void SearchByName(string name)
        {
            Console.WriteLine("Searching by name");
        }

    }
}
