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
    public class Service : IService
    {

        public void DeleteFromService()
        {
      

            using (var db = new ApplicationDbContext())
            {
              


                double claw = 2.99;
                double hair = 3.99;
                double washing = 4.99;
              

                Console.WriteLine("Add your booking number on your service");
                Services s = new Services();
                var id = Convert.ToInt32(Console.ReadLine());
                var a = db.Services.Find(id);
                if (s == null)
                {
                    Console.WriteLine($"No service with {id} was found");
                    return;
                }
                if (a.ClawCutting == true)
                {
                    Console.WriteLine("Here are your receipt " + claw);
                }
                else if(a.HairCut == true)
                {
                    Console.WriteLine("Here are your receipt " + hair);
                }
                else if (a.Washing == true)
                {
                    Console.WriteLine("Here are your receipt " + washing);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                db.Services.Remove(a);
                db.SaveChanges();
            }
        }
    }
} 

