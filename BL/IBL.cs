﻿using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        #region AddFunctions
        void AddBus(int _fuel, int _sumdis, string ID);
        void AddBusLine(int _Id, string _busnumber, int _Idfirststation, int _Idlaststation);
        void AddStation(int _sBusStationKey, double _Latitude, double _Longitude, string _Busstationaddres);
        void AddUser(string _UserName, string _UserPassword);
        void Addonthemovebus(int finishtime, int ID, int busnum);
        #endregion

        #region RemoveFunctions
        void RemoveUser(string UserName, string Password);
        void RemoveBus(string ID);
        void RemoveStation(int stationkey);
        void RemoveBusLine(int ID);
        void Removeonthemovebus(int ID);
        #endregion

        #region UpdateFunctions
        bool checkifuserexist(string username);
        #endregion

        #region GetFunctions
        DO.BusLine GetBusLine(int ID);
        DO.Station GetStation(int ID);
        DO.Bus GetBus(string ID);
        string GetUserPass(string name);
        List<BO.Bus> GetAllBuses();
        List<BO.BusLine> GetAllBusLines();
        List<BO.User> GetAllUsers();
        List<BO.Station> GetAllStations();
        List<BO.exitLine> GetExiteLines();
        #endregion
    }
}
