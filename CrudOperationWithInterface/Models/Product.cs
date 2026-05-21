namespace CrudOperationWithInterface.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}


//Single Responsibility Principle (SRP) - A class should have only one reason to change.
//In this case, the Product class is solely responsible for representing the product entity
//and does not contain any business logic or data access code.
//This separation of concerns allows for easier maintenance and scalability of the application.
