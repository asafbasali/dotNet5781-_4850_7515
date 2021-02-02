using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLI : BLObject
    {
        DALObject dl = new IDAL();
        #region AddFunctions
        void BLObject.AddBus(DO.Bus bus)
        {
            dl.AddBus(bus);
        }

        void BLObject.AddBusLine(DO.BusLine busLine)
        {
            dl.AddBusLine(busLine);
        }

        void BLObject.AddStation(DO.Station station)
        {
            dl.AddStation(station);
        }

        void BLObject.AddUser(DO.User user)
        {
            dl.AddUser(user);
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
        void BLObject.Updatebuslines(int stationnum)
        {
            foreach (DO.BusLine busLine in DS.DataBase.Lines)
            {
                dl.RemoveStationFromBusLine(busLine.busnumber, stationnum);
            }
        }
        #endregion
    }
}
