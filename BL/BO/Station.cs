using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public class Station
    {
        public int sBusStationKey { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Busstationaddres { get; set; }
        public Station(int _sBusStationKey, double _Latitude, double _Longitude, string _Busstationaddres)
        {
            this.Busstationaddres = _Busstationaddres;
            this.Latitude = _Latitude;
            this.Longitude = _Longitude;
            this.sBusStationKey = _sBusStationKey;
        }
        public Station() { }
    }
}
