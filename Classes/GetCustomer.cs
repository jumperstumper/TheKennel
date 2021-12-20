using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KennelProgram.Data;
using KennelProgram.New.Interface;

namespace KennelProgram.New
{
    public class GetCustomer : IGetCustomer
    {
        private readonly ApplicationDbContext _db;

        public GetCustomer(ApplicationDbContext db)
        {
            _db = db;
        }

        public void GetCustomers()
        {
            var customers = _db.Customers.ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void GetDogs()
        {
            var dogs = _db.Customers.ToList();

            foreach (var dog in dogs)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Name:" + dog.CustomerDog);
                Console.WriteLine("Breed:" + dog.CustomerDogBreed);
                Console.WriteLine("Social Number: " + dog.CustomerDogSocialNumber);
                Console.WriteLine("------------------");
            }
        }

        public void GetRelatedCustomerToDog()
        {
            var c = _db.Customers.ToList();

            foreach (var customer in c)
            {
                Console.WriteLine("Name: " + customer.Name + ", Dog: " + customer.CustomerDog + ", Dog Social Number: " + customer.CustomerDogSocialNumber);
            }
        }

        public void GetDogOnService()
        {
            var GetDog = _db.Services.Select(a => a.customer.Name);
            foreach (var d in GetDog) 
            {
                Console.WriteLine(d);
            }

        }

    }
}
