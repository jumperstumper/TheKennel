using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelProgram.Models
{
   public class Services
    {
        public int Id { get; set; }

        public bool HairCut { get; set; }

        public bool ClawCutting { get; set; }

        public bool Washing { get; set; }

        public int CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}
