using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class BLI
    {
        //DS.DataBase ds = DS.DataBase.Instance;
        DALObject dl = new IDAL();
        #region AddFunctions
        void BLObject.AddBus(int _fuel, int _sumdis, string ID)
        {
            dl.AddBus(new DO.Bus(_fuel,_sumdis,ID));
        }
        void BLObject.AddBusLine(int _Id, int _busnumber, int _Idfirststation, int _Idlaststation)
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
        #endregion

        #region UpdaeFunctions

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
        DO.User BLObject.GetUser(string name)
        {
            return dl.GetUser(name);
        }
        #endregion
    }
}
