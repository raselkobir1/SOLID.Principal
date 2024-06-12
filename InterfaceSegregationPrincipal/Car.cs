using System;

namespace InterfaceSegregationPrincipal
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
