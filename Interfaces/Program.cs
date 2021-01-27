using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal() );

            Console.ReadLine();
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "İlker",
                LastName = "Gürhan",
                Address = "İstanbul"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "İlker",
                LastName = "Gürhan",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
            manager.Add(customer);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
