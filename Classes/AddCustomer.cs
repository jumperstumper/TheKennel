using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KennelProgram.Data;
using KennelProgram.Models;
using KennelProgram.New.Interface;

namespace KennelProgram.New
{
    public class AddCustomer : IAddCustomer
    {


        public void AddCustomers()
        {

            using (var db = new ApplicationDbContext())
            {
                Customer s = new Customer();
                Console.WriteLine("Please enter customer name");
                s.Name = Console.ReadLine();
                Console.WriteLine("Please customer Dog Name");
                s.CustomerDog = Console.ReadLine();
                Console.WriteLine("Please customer Dogs Breed");
                s.CustomerDogBreed = Console.ReadLine();
                Console.WriteLine("Please customer Dogs SocialNumber");
                s.CustomerDogSocialNumber = Convert.ToInt32(Console.ReadLine());
                db.Add(s);
                db.SaveChanges();
                var CustomerName = s.Name;
                var DogName = s.CustomerDog;

                Console.WriteLine($"{CustomerName} " + " and " + $" {DogName} " + " is now Registred!");

            }


        }
    }
}
