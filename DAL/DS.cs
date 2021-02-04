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
        public static List<DO.User> Users = new List<User>();

        static DataBase()
        {
            Start();
        }
        static void Start()
        {
            #region Bus
            Buses.Add(new DO.Bus(2000, 0, "123-123-123"));
            Buses.Add(new DO.Bus(2000, 0, "123-123-124"));
            Buses.Add(new DO.Bus(2000, 0, "123-123-125"));
            #endregion

        }
    }
}
