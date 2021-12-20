using System;
using System.Linq;
using KennelProgram.Crud.Interface;
using KennelProgram.Data;
using KennelProgram.Models;
using KennelProgram.New;
using KennelProgram.New.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KennelProgram
{
    class Program 
    {
    

        static void Main(string[] args)
        {
            IServiceProvider services = new ServiceCollection()
            .AddDbContext<ApplicationDbContext>()
            .AddTransient<AddCustomer>()
            .AddTransient<Booking>()
            .AddTransient<GetCustomer>()
            .AddTransient<Service>()
            .AddTransient<StartUp>()
            .BuildServiceProvider();

            StartUp s = services.GetService<StartUp>();
            s.RunApp();
        }
    }


}

       



            
    


      
