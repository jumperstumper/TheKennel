using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KennelProgram.Crud.Interface;
using KennelProgram.Models;
using KennelProgram.New;
using KennelProgram.New.Interface;

namespace KennelProgram
{
    public class StartUp : IStartUp
    {

        private readonly AddCustomer _addCustomer;
        private readonly Booking _booking;
        private readonly GetCustomer _getCustomer;
        private readonly Service _service;


        public StartUp(AddCustomer addCustomer, Booking booking, GetCustomer getCustomer, Service service)
        {
            _addCustomer = addCustomer;
            _booking = booking;
            _getCustomer = getCustomer;
            _service = service;
        }



    
        public void RunApp() 
        {

            Console.WriteLine("Hi! Welcome to Kennel GoldenRetriver. What would you like to do?");

            Console.WriteLine("Press 1 to register a new customer and dog");
            Console.WriteLine("Press 2 to show all customers");
            Console.WriteLine("Press 3 to get all dogs");
            Console.WriteLine("Press 4 to show customers and thier related dogs");
            Console.WriteLine("Press 5 to leave dog on service");
            Console.WriteLine("Press 6 to show all dogs on service");
            Console.WriteLine("Press 7 to get your dog from service");

  

            bool isNumber = int.TryParse(Console.ReadLine(), out int start);

     
            if (isNumber)
            {
                switch (start)
                {
                    case 1:
                        _addCustomer.AddCustomers();
                        break;
                    case 2:
                        _getCustomer.GetCustomers();
                        break;
                    case 3:
                        _getCustomer.GetDogs();
                        break;
                    case 4:
                        _getCustomer.GetRelatedCustomerToDog();
                        break;
                    case 5:
                        _booking.AddBooking();
                        break;
                    case 6:
                        _getCustomer.GetDogOnService();
                        break;
                    case 7:
                        _service.DeleteFromService();
                        break;
                    default:
                        Console.WriteLine("Please enter valid number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter a number");
            }

        }
    }
}

       

