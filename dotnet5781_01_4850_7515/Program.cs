using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dotNet5781_01_4850_7515
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> Buses = new List<Bus>();
            int choice = -1;
            string id;
            while (choice != 0)
            {
                Console.WriteLine("hello and welcome to our system here you can track your bus handling\n");
                Console.WriteLine("1.add a new bus.\n" + "2.start driving.\n" + "3.treat and fuel your Bus.\n" + "4.print the details.\n" + "0.quit.");
                int v = Convert.ToInt32(Console.ReadLine());
                choice = v;
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        AddNewBuss();
                        break;
                    case 2:
                        StartDrive();
                        break;
                    case 3:
                        Repair();
                        break;
                    case 4:
                        PrintTheDetails();
                        break;
                    default:
                        Console.WriteLine("you entered wrong number, please try again.");
                        break;
                }
            }
            void AddNewBuss()
            {
                Console.WriteLine("please enter ID, in this format: xx-xxx-xx");
                string id = Console.ReadLine();
                //id = getInfo();
                Console.Write("please enter start day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("please enter start month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("please enter start year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime date = new DateTime(day: day, month: month, year: year);
                Buses.Add(new Bus(id, date));
            }
            void StartDrive()
            {
                Console.WriteLine("please enter Id for the bus");
                id = Console.ReadLine();
                Random R = new Random();
                foreach (Bus bus in Buses)
                {
                    if (bus.GetID() == id)
                    {
                        bus.StartDrive(R.Next(20000));
                    }
                    else
                    {
                        Console.WriteLine("sorry can't find your bus! ");
                    }
                }
            }
            void Repair()
            {
                Console.WriteLine("please enter Id for the bus");
                id = Console.ReadLine();
                foreach (Bus bus in Buses)
                {
                    if (bus.GetID() == id)
                    {
                        bus.Fuel_your_Bus();
                        bus.Treating_your_Bus();
                        Console.WriteLine("your bus is like new now\nyou can drive now");
                    }
                    else
                    {
                        Console.WriteLine("sorry can't find your bus! ");
                    }
                }
            }
            void PrintTheDetails()
            {
                Console.WriteLine("please enter ID");
                id = Console.ReadLine();
                foreach (Bus bus in Buses)
                {
                    if (bus.GetID() == id)
                    {
                        bus.Print_deatails();
                    }
                    else
                    {
                        Console.WriteLine("sorry can't find your bus! ");
                    }
                }
            }
            string getInfo()
            {
                return id;
            }
        }
    }
}
