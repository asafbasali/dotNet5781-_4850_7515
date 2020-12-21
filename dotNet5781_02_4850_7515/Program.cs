using System;
using System.Collections.Generic;

namespace dotNet5781_02_4850_7515
{
    class Program
    {
        public enum areaenum { south , north, central, general };
        
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
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(choice);
                switch (choice)
                {
                    case 1:
                        choice = -1;
                        Console.WriteLine("for adding a new bus line enter 1 \n for adding a bus station enter 2");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            areaenum e = areaenum.central;
                            Console.WriteLine("please enter a bus line number");
                            int BuslineID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("please choose area for your bus line: \n0) south \n1) north \n2) central\n3) general");
                            int area = Convert.ToInt32(Console.ReadLine());
                            areaenum newarea = (areaenum)(Enum.GetValues(e.GetType())).GetValue(area);
                            lines.Add(new BusLine(BuslineID, newarea.ToString()));
                        }
                        if (choice1==2)
                        {
                            Console.WriteLine("please enter a line you wat to add a station to");
                            int lineNumber = Convert.ToInt32(Console.ReadLine());
                            foreach (BusLine line in lines)
                            {
                                if (line.Bus_Line == lineNumber)
                                {
                                    line.Stations.Add(new BusStation());
                                }
                                else
                                {
                                    Console.WriteLine("there is no bus line in that number");
                                }
                            }

                        }
                        break;
                    case 2:

                    default:
                        break;
                }
            }
            Console.WriteLine( "End Of Program");
        }
    }
}
