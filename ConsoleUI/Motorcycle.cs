using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Currently Driving");
        }
        public bool HasSideCar { get; set; }

        public override void DriveVirtual() 
        {
            Console.WriteLine("The motorcycles virtual drive");
        }
       


    }
}
