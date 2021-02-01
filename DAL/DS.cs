using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public static class DataBase
    {
        public static List<DO.Station> Stations = new List<DO.Station>();
        public static List<DO.StationOfBus> StationLines = new List<DO.StationOfBus>();
        public static List<DO.BusLine> Lines = new List<DO.BusLine>();
        public static List<DO.FolowingStation> tracking_stations = new List<DO.FolowingStation>();
        public static List<DO.Bus> Buses = new List<DO.Bus>();

        static DataBase()
        {
            Start();
        }
        static void Start()
        {
            Random R = new Random();
            Stations = new List<Station>
            {
                new Station
                {
                    sBusStationKey = 20,
                    Latitude = R.Next(-90, 90),
                    Longitude = R.Next(-180, 180),
                    Busstationaddres = "Avtlion"
                },
                new Station
                {
                    sBusStationKey = 23,
                    Latitude = R.Next(-90, 90),
                    Longitude = R.Next(-180, 180),
                    Busstationaddres = "Shamay"
                }
            };
            Lines = new List<BusLine>
            {
                new BusLine
                {
                    Id = 1234,
                    busnumber = 279,
                    Idfirststation = 1
                }
            };
        }

    }
}
