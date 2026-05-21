using CrudOperationWithInterface.Models;

namespace CrudOperationWithInterface.Services.IServices
{

    //what is abstraction in programming?
    // in C# we can achieve abstraction using interfaces. An interface defines a contract that specifies the methods and properties that a class must implement, without providing any implementation details. This allows us to hide the internal workings of a class and only expose the necessary functionality to the outside world.
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);

    }
}
//  what is the difference between IEnumberable and IQueryable?


//Open -closed principle (OCP) - Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.


// means a interface or class is open for extension if we can add new functionality without changing the existing code. It is closed for modification if we cannot change the existing code to add new functionality. By following this principle, we can create software that is more maintainable and less prone to bugs, as we can add new features without affecting the existing functionality.


// what is abstraction>

// what is the interface?

// what is dependency injection?

// how we can achive mulitple inheritance