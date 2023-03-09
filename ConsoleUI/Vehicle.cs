using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {/* The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.*/
        public int Year { get; set; } = 2019;
        public string Make { get; set; } = "generic";
        public string Model { get; set; } = "generic";
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("default Virtual Drive");
        }

       

    }
}
