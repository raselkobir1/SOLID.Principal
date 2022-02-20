using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipal
{
    public class MultiFunctionalCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}

//This is working great. Our interface covers all the required actions.
//but But now, we want to implement the Car class and the Airplane class as well: