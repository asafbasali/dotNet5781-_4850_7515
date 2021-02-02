using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface BLObject
    {
        #region AddFunctions
        void AddBus(DO.Bus bus);
        void AddBusLine(DO.BusLine busLine);
        void AddStation(Station station);
        void AddUser(User user);
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
    }
}
