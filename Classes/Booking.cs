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
    public class Booking : IBooking
    {


        public void AddBooking()
        {


            using (var db = new ApplicationDbContext())
            {
                Services s = new Services();
                Console.WriteLine("Enter your Id: ");
                s.CustomerId = Convert.ToInt32(Console.ReadLine());
                db.Add(s);
                db.SaveChanges();

                var i = s.Id;
                Console.WriteLine("Here are your Booking number " + $"{i} " + " make sure you save it!");

                Console.WriteLine("What service would you like to do?");
                Console.WriteLine("Press 1 For Clawcutting");
                Console.WriteLine("Press 2 for Haircut");
                Console.WriteLine("Press 3 for Washing");

                int service = Convert.ToInt32(Console.ReadLine());

                if (service == 1)
                {
                    s.ClawCutting = true;
                    db.Update(s);
                    db.SaveChanges();
                    
                }
                else if (service == 2)
                {
                    s.HairCut = true;
                    db.Update(s);
                    db.SaveChanges();

                }
                else if (service == 3)
                {

                    s.Washing = true;
                    db.Update(s);
                    db.SaveChanges();


                }
            }
        }
    }
}

