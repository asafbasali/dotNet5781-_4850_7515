using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataBase
    {
        public List<DO.Station> Stations = new List<DO.Station>();
        public List<DO.StationOfBus> StationLines = new List<DO.StationOfBus>();
        public List<DO.BusLine> Lines = new List<DO.BusLine>();
        public List<DO.FolowingStation> tracking_stations = new List<DO.FolowingStation>();
        public List<DO.Bus> Buses = new List<DO.Bus>();
        public List<DO.User> Users = new List<User>();

        private static DataBase instance;
        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                };
                return instance;
            } 
        }
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
