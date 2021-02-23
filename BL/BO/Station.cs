using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public class Station
    {
        public int sBusStationKey { get; set; }
        public string Busstationaddres { get; set; }
        public Station(int _sBusStationKey, string _Busstationaddres)
        {
            this.Busstationaddres = _Busstationaddres;
            this.sBusStationKey = _sBusStationKey;
        }
        public Station() { }
    }
}
