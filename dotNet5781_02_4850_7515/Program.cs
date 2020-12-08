using System;
using System.Collections.Generic;

namespace dotNet5781_02_4850_7515
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            List<BusLine> lines = new List<BusLine>();
            while (choice != 0)
            {
                Console.WriteLine("hello and welcome to our system \n \nhere you can manage your Bus Compeny. " +
                    "\n\n1.add a new bus or station.\n\n" + "2.deleting a bus line or bus station.\n\n" + 
                    "3.searching for station or bus line.\n\n" + "4.print the bus lines or the the stations " +
                    "with their lines.\n\n" + "0.quit.");
                choice = Console.Read();
                switch (choice)
                {
                    case 1:

                    default:
                        break;
                }
            }
            Console.WriteLine( "end of program");
        }
    }
}
