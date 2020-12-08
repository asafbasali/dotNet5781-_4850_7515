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
                Console.WriteLine("hello and welcome to our system \n here you can manage your Bus Compeny. " +
                    "\n 1.add a new bus or station.\n" + "2.deleting a bus line or bus station.\n" + 
                    "3.searching for station or bus line.\n" + "4.print the bus lines or the the stations " +
                    "with their lines.\n" + "0.quit.");
                choice = Console.Read();
                switch (choice)
                {
                    case 1:

                    default:
                        break;
                }
            }
        }
    }
}
