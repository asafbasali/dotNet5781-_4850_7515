using System.Collections.Generic;
using DAL;

namespace BL
{
   public class BLI : BLObject
    {
        //DS.DataBase ds = DS.DataBase.Instance;
        DALObject dl = new IDAL();
        #region AddFunctions
        void BLObject.AddBus(int _fuel, int _sumdis, string ID)
        {
            dl.AddBus(new DO.Bus(_fuel,_sumdis,ID));
        }
        void BLObject.AddBusLine(int _Id, string _busnumber, int _Idfirststation, int _Idlaststation)
        {
            dl.AddBusLine(new DO.BusLine(_Id,_busnumber,_Idfirststation,_Idlaststation));
        }
        void BLObject.AddStation(int _sBusStationKey, double _Latitude, double _Longitude, string _Busstationaddres)
        {
            dl.AddStation(new DO.Station(_sBusStationKey,_Latitude,_Longitude,_Busstationaddres));
        }
        void BLObject.AddUser(string _UserName, string _UserPassword)
        {
            dl.AddUser(new DO.User(_UserName,_UserPassword));
        }
        void BLObject.Addonthemovebus(int finishtime, int ID, int busnum)
        {
            dl.AddOnTheMoveBus(new DO.exiteLine(finishtime, ID, busnum));
        }
        #endregion

        #region RemoveFunctions
        void BLObject.RemoveBus(string ID)
        {
            dl.RemoveBus(ID);
        }
        void BLObject.RemoveBusLine(int ID)
        {
            dl.RemoveBusLine(ID);
        }
        void BLObject.RemoveStation(int stationkey)
        {
            dl.removeStation(stationkey);
        }
        void BLObject.RemoveUser(string UserName, string Password)
        {
            dl.RemoveUser(UserName, Password);
        }
        void BLObject.Removeonthemovebus(int ID)
        {
            dl.RemoveOnTheMoveBus(ID);
        }
        #endregion

        #region UpdaeFunctions
        bool BLObject.checkifuserexist(string username)
        {
            return dl.Checkifuserexsist(username);
        }
        #endregion

        #region GetFunctions
        DO.BusLine BLObject.GetBusLine(int ID)
        {
            return dl.GetBusLine(ID);
        }
        DO.Station BLObject.GetStation(int ID)
        {
            return dl.GetStation(ID);
        }
        DO.Bus BLObject.GetBus(string ID)
        {
            return dl.GetBus(ID);
        }
        string BLObject.GetUserPass(string name)
        {
            return dl.GetUserPass(name);
        }
        List<BO.Bus> BLObject.GetAllBuses()
        {
            List<BO.Bus> buses1 = new List<BO.Bus>();
            List<DO.Bus>buses = dl.GetallBuses();
            for (int i = 0; i < buses.Count; i++)
            {
                buses1.Add(new BO.Bus(buses[i].fuel, buses[i].sumdis, buses[i].iD));
            }
            return buses1;
        }
        List<BO.BusLine> BLObject.GetAllBusLines()
        {
            List<BO.BusLine> busesLines1 = new List<BO.BusLine>();
            List<DO.BusLine> buseLines = dl.GetallBusLines();
            for (int i = 0; i < buseLines.Count; i++)
            {
                busesLines1.Add(new BO.BusLine(buseLines[i].Id, buseLines[i].busnumber, buseLines[i].Idfirststation, buseLines[i].Idlaststation));
            }
            return busesLines1;
        }
        List<BO.User> BLObject.GetAllUsers()
        {
            List<DO.User> users = dl.GetAllUsers();
            List<BO.User> users1 = new List<BO.User>();
            for (int i = 0; i < users.Count; i++)
            {
                users1.Add(new BO.User(users[i].UserName));
            }
            return users1;
        }
        List<BO.Station> BLObject.GetAllStations()
        {
            List<DO.Station> stations = dl.GetallStations();
            List<BO.Station> stations1 = new List<BO.Station>();
            for (int i = 0; i < stations.Count; i++)
            {
                stations1.Add(new BO.Station(stations[i].sBusStationKey, stations[i].Busstationaddres));
            }
            return stations1;
        }
        List<BO.exitLine> BLObject.GetExiteLines()
        {
            List<DO.exiteLine> lines = new List<DO.exiteLine>();
            List<BO.exitLine> lines1 = new List<BO.exitLine>();
            lines = dl.GetAllOntheMoveBus();
            foreach (DO.exiteLine line in lines)
            {
                lines1.Add(new BO.exitLine(line.IDLinebus, line.exitLine, line.finishtime));   
            }
            return lines1;
        }
        #endregion
    }
}
