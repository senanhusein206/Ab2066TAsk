using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVillaProject.BL.Exceptions
{
    public class CarException:Exception
    {
        public CarException() : base("Default excemption")
        {
            
        }

        public CarException(string message):base(message) 
        {
            
        }
    }
}
