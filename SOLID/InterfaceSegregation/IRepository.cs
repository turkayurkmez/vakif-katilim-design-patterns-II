using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();

        void Create(T entity);

     

    }

    public interface ISearchableRepo<T>
    {
        List<T> Search(string name);
    }

    public class Order
    {
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class OrderRepository : IRepository<Order>
    {
        public void Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

      
    }

    public class ProductRepository : IRepository<Product>, ISearchableRepo<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string name)
        {
            throw new NotImplementedException();
        }
    }


}
