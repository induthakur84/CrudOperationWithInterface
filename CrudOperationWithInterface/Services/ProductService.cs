using CrudOperationWithInterface.Models;
using CrudOperationWithInterface.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationWithInterface.Services
{

    // what is the enccapsulation in programming?


    // it means wrapping the data (variables) and code acting on the data (methods) together as a single unit.
    // In encapsulation, the variables of a class are hidden from other classes and can only be accessed through
    //
    // methods of their current class. This is achieved using access modifiers like private, protected, and public. Encapsulation helps to protect the integrity of the data and prevents unauthorized access or modification.




    //all the business logic related to products will be implemented in this class. It will interact with the database context to perform CRUD operations on the Product entity. By using an interface (IProductService), we can easily swap out the implementation of the service without affecting the rest of the application, which promotes loose coupling and makes the code more maintainable and testable.
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
           _context.Products.Add(product);
              _context.SaveChanges();

        }

        public void Delete(int id)
        {
          var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        /// <summary>
        ///  here we can write the query to get all the products from the database. We are using AsNoTracking() method to improve the performance of the query by not tracking the changes of the entities. This is useful when we only want to read the data and not update it.
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Product> GetAll()
        {
           return _context.Products.AsNoTracking().ToList();

        }

        public Product GetById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public void Update(Product product)
        {
           var existingProduct = _context.Products.Find(product.Id);
            if (existingProduct == null)
            {
                throw new Exception("Product not found");
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            _context.SaveChanges();
        }
    }
}





//Interface Segregation Principle (ISP) - Clients should not be forced to depend on interfaces they do not use.