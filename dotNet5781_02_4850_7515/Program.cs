using System;
using System.Collections.Generic;
using System.Linq;

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
                switch (choice)
                {
                    case 1:
                        choice = -1;
                        Console.WriteLine("for adding a new bus line enter 1 \nfor adding a bus station enter 2");
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
                        if (choice1 == 2)
                        {
                            Console.WriteLine("please enter a line you want to add a station to");
                            int lineNumber = Convert.ToInt32(Console.ReadLine());
                            int again = 1;
                            bool DidWeDo;
                            foreach (BusLine line in lines)
                            {
                                if (line.Bus_Line == lineNumber)
                                {
                                    DidWeDo = true;
                                    while (again!=0)
                                    {
                                        Console.WriteLine("please enter a station key: ");
                                        int newkey = Convert.ToInt32(Console.ReadLine());

                                        if (newkey != 0)
                                        {
                                            Console.WriteLine("please enter time from last station in miutes.");
                                            int timefrom = Convert.ToInt32(Console.ReadLine());
                                            line.AddStation(new BusStation(newkey));
                                            again = 0;
                                        }
                                        else
                                        {
                                            again = 1;
                                            Console.WriteLine("your input is wrong please try again!");
                                        }
                                    }
                                
                                }
                            }
                            if (!(DidWeDo=false))
                            {
                                Console.WriteLine("there is no bus line in that number\n");
                            }
                        }
                        if(choice1 !=1 && choice1 != 2)
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case 2:
                        Console.WriteLine("for deleting a new bus line enter 1 \nfor deleting a bus station enter 2");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2==1)
                        {
                            Console.WriteLine("please enter a line to delete: ");
                            int linenumber = Convert.ToInt32(Console.ReadLine());
                            foreach (BusLine line in lines)
                            {
                                if (line.Bus_Line == linenumber)
                                {
                                    lines.Remove(line);
                                    Console.WriteLine("The line was removed!");
                                }
                                else
                                {
                                    Console.WriteLine("there is no line in that number");
                                }
                            }
                        }
                        if (choice2 == 2)
                        {
                            Console.WriteLine("please enter a station key");
                            int Key = Convert.ToInt32(Console.ReadLine());
                            foreach (BusLine line in lines)
                            {
                                line.RemoveStation(Key);
                            }
                            Console.WriteLine("The station was removed (in case it exist)");
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case 3:
                        Console.WriteLine("for searching a line that throghu certain station enter 1.\nfor searching a line for path enter 2.");
                        int choice3 = Convert.ToInt32(Console.ReadLine());
                        if (choice3 == 1)
                        {
                            bool DidWeDo;
                            Console.WriteLine("please enter a bus station code: ");
                            int BusStationcode = Convert.ToInt32(Console.ReadLine());
                            foreach (BusLine line in lines)
                            {
                                if (line.isstationexist(BusStationcode))
                                {
                                    Console.WriteLine(line.Bus_Line);
                                    DidWeDo = false;
                                }
                            }
                            if ((DidWeDo = false))
                            {
                                Console.WriteLine("There is no line or station matching your input");
                            }
                        }
                        if (choice3 == 2)
                        {
                            Console.WriteLine("Please enter the first bus station key: ");
                            int firstKey = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the second bus station key: ");
                            int secondKey = Convert.ToInt32(Console.ReadLine());
                            bool DidWeDo;

                            foreach (BusLine line in lines)
                            {
                                if (line.isstationexist(firstKey) && line.isstationexist(secondKey))
                                {
                                    Console.WriteLine(line.Bus_Line);
                                    DidWeDo = false;
                                }
                            }
                            if ((DidWeDo = false))
                            {
                                Console.WriteLine("There is no line or station matching your input");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("for viewing all the lines enter 1");
                        int choice4;
                        choice4 = Convert.ToInt32(Console.ReadLine());
                        if (choice4 == 1)
                        {
                            foreach (BusLine line in lines)
                            {
                                line.ToString();
                            }
                        }
                        if (choice4 == 2)
                        {
                            foreach (BusLine line in lines)
                            {
                                Console.WriteLine("line:",line.Bus_Line);
                                List<BusStation> Toprint = new List<BusStation>();
                                Toprint = line.STations;
                                foreach (BusStation station in Toprint)
                                {
                                    Console.WriteLine(station.ToString());
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("WRONG INPUT");
                        break;
                }
            }
            Console.WriteLine( "End Of Program");
        }
    }
}
