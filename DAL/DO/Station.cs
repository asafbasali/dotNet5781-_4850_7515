using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public class Station
    {
        public Station(int _sBusStationKey, double _latitude, double _longitude, string _busstationaddres)
        {
            this.sBusStationKey = _sBusStationKey;
            Latitude = _latitude;
            Longitude = _longitude;
            Busstationaddres = _busstationaddres;
        }
        public Station() { }

        public int sBusStationKey { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Busstationaddres { get; set; }
    }
}
