using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "İlker";
            customer1.LastName = "Gürhan";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Sena",
                LastName = "Aslaner"
            };
           
            Console.WriteLine(customer2.FirstName);
            
            Console.ReadLine();
        }
    }

    
    
}
