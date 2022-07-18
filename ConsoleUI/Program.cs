using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var theCar = new Car();
            theCar.Make = "Kia";
            theCar.Year = 2019;
            theCar.Model = "Forte";
            theCar.HasTrunk = true;

            var theMotorcyle = new Motorcycle();
            theMotorcyle.Make = "Harley";
            theMotorcyle.Year = 2000;
            theMotorcyle.Model = "The Best One";
            theMotorcyle.HasSideCart = true;

            Vehicle sedan = new Car();
            sedan.Make = "Chevy";
            sedan.Year = 2004;
            sedan.Model = "Malibu";          
            

            Vehicle sportsCar = new Car();
            sportsCar.Make = "Mazda";
            sportsCar.Year = 1991;
            sportsCar.Model = "Miata";

            vehicles.Add(theCar);
            vehicles.Add(sedan);
            vehicles.Add(sportsCar);
            vehicles.Add(theMotorcyle);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}.");
                vehicle.DriveAbstract();
                Console.WriteLine("---------------");
                vehicle.DriveVirtual();
                Console.WriteLine("--------------");
            }

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

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
