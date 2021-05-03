using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace dotNet5781_01_4850_7515
{
    class Bus
    {
        static int fuel;
        static int totaldis;
        static int sumdis = 0;
        static string iD;
        static DateTime start_date = new DateTime();

        public string GetID()
        {
            return iD;
        }
        public void t()
        {
            Console.WriteLine(start_date);
        }

        public Bus(string _id, DateTime date)
        {
            iD = _id;
            start_date = date;
            fuel = 1200;
            totaldis = 20000;
        }
        public void StartDrive(int _dis)
        {
            int count = 1;
            if (totaldis - _dis <= 0)
            {
                Console.WriteLine("you can't drive you need to treat your Bus\n");
                count = 0;
            }
            if (fuel - _dis*0.5 <= 0 && count == 1)
            {
                Console.WriteLine("you can't drive you need to fuel your Bus\n");
            }
            else if (count != 0)
            {
                totaldis -= _dis;
                sumdis += _dis;
                fuel -= _dis;
                Console.WriteLine("You can go");
            }
        }

        public void Treating_your_Bus()
        {
            totaldis = 20000;

        }
        public void Fuel_your_Bus()
        {
            fuel = 3000;
        }

        public void Print_deatails()
        {
            Console.WriteLine("\nID " + iD + " " + "\ntotal distance: " + totaldis + "\n all distance the Bus did: " + sumdis + "\n" + "strting date: " + start_date + "\n");
        }

    }
}
