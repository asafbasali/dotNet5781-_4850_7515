using System.Collections.Generic;
using DO;
using System;
namespace DS
{
    public static class DataBase
    {
  
        public static  List<Station> Stations = new List<DO.Station>();
        public static List<StationOfBus> StationLines = new List<DO.StationOfBus>();
        public static List<BusLine> Lines = new List<DO.BusLine>();
        public static List<FolowingStation> tracking_stations = new List<DO.FolowingStation>();

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


        }
        
    }
}





