using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface BLObject
    {
        #region AddFunctions
        void AddBus(int _fuel, int _sumdis, string ID);
        void AddBusLine(int _Id, int _busnumber, int _Idfirststation, int _Idlaststation);
        void AddStation(int _sBusStationKey, double _Latitude, double _Longitude, string _Busstationaddres);
        void AddUser(string _UserName, string _UserPassword);
        #endregion

        #region RemoveFunctions
        void RemoveUser(string UserName, string Password);
        void RemoveBus(string ID);
        void RemoveStation(int stationkey);
        void RemoveBusLine(int ID);
        #endregion

        #region UpdateFunctions
        void Updatebuslines(int station);
        #endregion

        #region GetFunctions
        DO.BusLine GetBusLine(int ID);
        DO.Station GetStation(int ID);
        DO.Bus GetBus(string ID);
        DO.User GetUser(string name);
        #endregion
    }
}
