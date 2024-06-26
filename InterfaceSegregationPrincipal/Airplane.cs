﻿using System;

namespace InterfaceSegregationPrincipal
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Flying a plane");
        }
    }
}


/*
 * Now we can see what the problem with the IVehicle interface is.
 * It contains only one required declaration per each class. 
 * The other method, which is not required, is implemented to throw an exception. 
 * That is a bad idea because we should be writing our code to do something and not just to throw exceptions
 */