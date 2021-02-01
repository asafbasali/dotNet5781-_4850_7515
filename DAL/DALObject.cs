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
        DO.BusLine GetBusLine(int ID);
        void UpdateBusLine(int ID, BusLine newbusline);
        void RemoveStationFromBusLine(int StationNumber, int ID);
        void AddStationToBusLine(Station NewBusStation, int ID);
        #endregion

        #region Station
        void AddStation(Station newsstation);
        void removeStation(int ID);
        #endregion

        #region Bus
        void AddBus(DO.Bus Bus);
        void RemoveBus(string ID);
        //bool IsBusExist(string ID);

        #endregion
    }
}
