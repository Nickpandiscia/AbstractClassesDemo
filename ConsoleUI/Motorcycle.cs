using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The motorcyle is moving foward.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"The person is riding the motorcycle.");
        }
    }
}
