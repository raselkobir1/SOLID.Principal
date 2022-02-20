using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipal
{
    public class MultiFunctionalCar : IMultiFunctionalVehicle  //or ICar, IAirplane
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;
        public MultiFunctionalCar(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }
        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}

//This is working great. Our interface covers all the required actions.
//but But now, we want to implement the Car class and the Airplane class as well:




/*
 public class MultiFunctionalCar : IMultiFunctionalVehicle  //or ICar, IAirplane
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
 */