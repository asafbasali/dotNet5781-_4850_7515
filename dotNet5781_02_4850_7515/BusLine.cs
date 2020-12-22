using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class BusLine
    {
        internal List<BusStation> Stations = new List<BusStation>();
        internal string FirstStation;
        internal string LastStation;
        internal int Bus_Line;
        internal string Area;

        public BusLine( int _Bus_Line = 0, string _Area = "")
        {
            //if (_FirstStation!="")
            //{
            //    FirstStation = _FirstStation;
            //}
            //else
            //{

            //}
            //if (_LastStation != "")
            //{
            //    LastStation = _FirstStation;
            //}
            //else
            //{

            //}
            if (_Bus_Line != 0)
            {
                Bus_Line = _Bus_Line;
            }
            if (Area != "")
            {
                Area = _Area;
            }
            else
            {
                Console.WriteLine("your input is wrong please try again!");
            }
            Stations.Add(new BusStation());
        }

        public override string ToString()
        {
            Stations.ForEach(Console.WriteLine);
            return base.ToString()+ "Bus Line: " + Bus_Line + " Area: "+Area+" Stations: " ; 
        }

        void AddStation(BusStation NewBusStation)
        {
            Stations.Add(NewBusStation);//הוספנו מחלקת תחנת אוטובוס לרשימת התחנות שלנו
        }

        bool isstationexist(int _ID)
        {
            foreach (BusStation station in Stations)
            {
                if (station.sBusStationKey ==_ID)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
