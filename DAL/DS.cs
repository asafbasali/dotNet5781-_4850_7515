﻿using DO;
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
        public static List<DO.BusLine> BusLines = new List<DO.BusLine>();
        public static List<DO.FolowingStation> tracking_stations = new List<DO.FolowingStation>();
        public static List<DO.Bus> Buses = new List<DO.Bus>();
        public static List<DO.User> Users = new List<User>();

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
            #endregion

            #region station
            Stations.Add(new Station(123, 31, 100, "avtalyn"));
            #endregion

            #region Lines
            BusLines.Add(new BusLine(12, "123-123-123"));
            #endregion

            #region users
            Users.Add(new User("levi", "770"));
            #endregion

        }
    }
}
