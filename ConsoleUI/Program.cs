using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles= new();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var honda = new Car();
            honda.Year = 2019;
            honda.Make = "Honda";
            honda.Model = "Civic";
            honda.HasTrunk = true;

            vehicles.Add(honda);

            var harley = new Motorcycle();
            harley.Year = 2020;
            harley.Make = "Harley Davidson";
            harley.Model = "sportster";
            harley.HasSideCar = true;

            vehicles.Add(harley);
            
            Vehicle Car1 = new Car();
            Car1.Year = 2020;
            Car1.Make = "Honda";
            Car1.Model = "Accord";
            
            vehicles.Add(Car1);

            Vehicle motorcycle1= new Motorcycle();
            motorcycle1.Year = 2023;
            motorcycle1.Make = "Honda";
            motorcycle1.Model = "GoldWing";

            vehicles.Add(motorcycle1);

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine("");
            }

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
            

            #endregion            
            Console.ReadLine();
        }
    }
}
