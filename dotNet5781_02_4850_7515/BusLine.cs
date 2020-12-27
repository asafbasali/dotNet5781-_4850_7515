using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class BusLine
    {
        private List<BusStation> Stations = new List<BusStation>();
        internal string FirstStation;
        internal string LastStation;
        internal int Bus_Line;
        internal string Area;
        int timeswecreatedastation = 0;
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
            timeswecreatedastation++;
        }

        public override string ToString()
        {
            Console.WriteLine("Bus Line: " + Bus_Line + " Area: " + Area + " Stations: ");
            Stations.ForEach(Console.WriteLine);
            return "" ; 
        }

        internal void AddStation(BusStation NewBusStation)
        {
            Stations.Add(NewBusStation);//הוספנו מחלקת תחנת אוטובוס לרשימת התחנות שלנו
        }

        internal void RemoveStation(int StaionNumber)
        {
            foreach (BusStation station in Stations)
            {
                if (StaionNumber == station.sBusStationKey)
                {
                    Stations.Remove(station);
                    break;
                }
            }
        }

        internal int DisBetweenstations(int key1, int key2)
        {
            BusStation dissum1=null;
            BusStation dissum2=null;
            foreach (BusStation station in Stations)
            {
                if (station.sBusStationKey == key1)
                {
                    dissum1 = station;
                }
                if (station.sBusStationKey == key2)
                {
                    dissum2 = station;
                }
            }
            if (dissum1.sBusStationKey == key1 && dissum2.sBusStationKey == key2)
            {
                return Convert.ToInt32(Math.Sqrt(Convert.ToInt32(Math.Pow(dissum1.Latitude - dissum2.Latitude,2)) + Convert.ToInt32(Math.Pow(dissum1.Longitude - dissum2.Longitude,2))));
            }
            else
            {
                return 0;
            }
        }

        internal bool isstationexist(int _ID)
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

        public List<BusStation> STations
        {
            get{ return Stations; }
        }
    }
}
