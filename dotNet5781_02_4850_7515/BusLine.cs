using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class BusLine
    {
        List<BusStation> Stations = new List<BusStation>();
        internal string FirstStation;
        internal string LastStation;
        internal int Bus_Line;
        internal string Area;

        public BusLine( int _Bus_Line = 0, string _Area = "")
        {
            if (_FirstStation!="")
            {
                FirstStation = _FirstStation;
            }
            else
            {
                   
            }
            if (_LastStation != "")
            {
                LastStation = _FirstStation;
            }
            else
            {

            }
            if (_Bus_Line != 0)
            {
                LastStation = _FirstStation;
            }
            else
            {

            }
        }

        public override string ToString()
        {
            return "Bus Line: " + Bus_Line + " Area: "+Area+" Stations: "+Stations;
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
