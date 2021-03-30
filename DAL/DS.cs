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
        //public static List<DO.StationOfBus> StationLines = new List<DO.StationOfBus>();
        public static List<DO.BusLine> BusLines = new List<DO.BusLine>();
        //public static List<DO.FolowingStation> tracking_stations = new List<DO.FolowingStation>();
        public static List<DO.Bus> Buses = new List<DO.Bus>();
        public static List<DO.User> Users = new List<User>();
        public static List<DO.exiteLine> onthemoveline = new List<exiteLine>();

        //private static DataBase instance;
        //public static DataBase Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new DataBase();
        //        };
        //        return instance;
        //    } 
        //}
        static DataBase()
        {
            Start();
        }
        static void Start()
        {
            #region Bus
            Buses.Add(new Bus(3000, 0, "123-123-123"));
            Buses.Add(new Bus(3000, 0, "123-123-124"));
            Buses.Add(new Bus(3000, 0, "123-123-126"));
            Buses.Add(new Bus(3000, 0, "123-123-125"));
            #endregion

            #region station
            Stations.Add(new Station(123, 31, 100, "avtalyn"));
            #endregion

            #region Lines
            BusLines.Add(new BusLine(12, "123-123-123"));
            #endregion

            #region users
            Users.Add(new User("levi", "770"));
            Users.Add(new User("Asaf", "771"));
            #endregion

            #region exitLine
            DataBase.onthemoveline.Add(new exiteLine(10, 123, 123456));
            DataBase.onthemoveline.Add(new exiteLine(10, 124, 123457));
            DataBase.onthemoveline.Add(new exiteLine(10, 125, 123476));
            #endregion
        }
    }
}
