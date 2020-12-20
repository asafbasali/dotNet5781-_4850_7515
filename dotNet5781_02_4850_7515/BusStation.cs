using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class BusStation
    {
        internal int sBusStationKey;
        internal int Latitude;
        internal int Longitude;

        public BusStation(int _sBusStationKey = 0, int _Latitude = 0, int _Longitude = 0)
        {
            if (_sBusStationKey > 0 && _sBusStationKey < 100000)
            {
                sBusStationKey = _sBusStationKey;
            }
            else
            {

            }
            if (_Latitude >= -90 && _Latitude <= 90)
            {
                Latitude = _Latitude;
            }
            else
            {

            }
            if (_Longitude >= -180 && _Longitude <= 180)
            {
                Longitude = _Longitude;
            }
            else
            {

            }
        }
           
        public override string ToString()
        {
                return "Bus Station Code: "+sBusStationKey+", "+Latitude + " " + Longitude ; 
        }
    
    }
    
}
