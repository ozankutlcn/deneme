using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                ID = 1,
                FirstName = "Ozan",
                LastName = "Kutlucan",
                Address = "Akşemsettin"
            };
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            Console.ReadLine();
        }
    }

    interface IPerson 
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public string Address { get; set; }

    }
    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    //class PersonManager 
    //{
    //    public void Add(IPerson person) 
    //    {
    //        Console.WriteLine(customer.FirstName);
    //    }
    //}
}
