using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelProgram.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string CustomerDog { get; set; }

        public string CustomerDogBreed { get; set; }

        public int CustomerDogSocialNumber { get; set; }

        public Services services { get; set; }

        //List<Dog> Dogs { get; set; }
    }
}
