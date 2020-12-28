using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class BusStation
    {
        internal LineBusStation discal = new LineBusStation();
        public Random location = new Random();
        internal int sBusStationKey;
        internal double Latitude;
        internal double Longitude;
        internal string Busstationaddres = "some address";


        public BusStation(int _sBusStationKey = 0)
        {
            Latitude = location.Next(-90, 90);
            Longitude = location.Next(-180, 180);
            if (_sBusStationKey > 0 && _sBusStationKey < 100000)
            {
                sBusStationKey = _sBusStationKey;
            }
            else
            {
                Console.WriteLine("your input is wrong please try again!");
            }

        }
           
        public override string ToString()
        {
                return "Bus Station Code: "+sBusStationKey+" ,location: "+Latitude + ", " + Longitude+ " address"+Busstationaddres ; 
        }
    }
}
