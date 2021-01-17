using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using DO;
namespace DS
{
    public static class DataBase
    {
  
        public static  List<BusLine> Stations = new List<DO.BusLine>();
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
            Stations = new List<BusLine>
            {
                new BusLine
                {
                    sBusStationKey = 20,
                    Latitude = R.Next(-90, 90),
                    Longitude = R.Next(-180, 180),
                    Busstationaddres = "Avtlion"
                },
                new BusLine
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





