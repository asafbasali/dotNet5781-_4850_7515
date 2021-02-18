using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BO
{
    public class Bus
    {
        public int fuel { get; set; }
        public int totaldis { get; set; }
        public int sumdis { get; set; }
        public string iD { get; set; }
        public DateTime start_date { get; set; }
        public Bus(int _fuel,int _sumdis,string ID)
        {
            this.fuel = _fuel;
            this.iD = ID;
            this.sumdis = _sumdis;
            start_date = DateTime.Now;
        }
        public Bus()
        {

        }
        public void Print_deatails()
        {
            Console.WriteLine("\nID " + iD + " " + "\ntotal distance: " + totaldis + "\n all distance the Bus did: " + sumdis + "\n" + "strting date: " + start_date + "\n");
        }
    }
}
