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
        #endregion
    }
}
