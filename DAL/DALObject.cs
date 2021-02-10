﻿using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface DALObject
    {
        #region BusLine
        void AddBusLine(BusLine busline);
        void RemoveBusLine(int ID);
        DO.BusLine GetBusLine(int ID);
        void UpdateBusLine(int ID, BusLine newbusline);
        void RemoveStationFromBusLine(int StationNumber, int ID);
        void AddStationToBusLine(Station NewBusStation, int ID);
        List<BusLine> GetallBusLines();
        #endregion

        #region Station
        void AddStation(Station newsstation);
        void removeStation(int ID);
        DO.Station GetStation(int ID);
        List<Station> GetallStations();
        #endregion

        #region Bus
        void AddBus(DO.Bus Bus);
        void RemoveBus(string ID);
        bool IsBusExist(string ID);
        DO.Bus GetBus(string ID);
        List<Bus> GetallBuses();
        #endregion

        #region User
        void AddUser(DO.User user);
        void RemoveUser(string UserName, string Password);
        DO.User GetUser(string name);
        #endregion
    }
}