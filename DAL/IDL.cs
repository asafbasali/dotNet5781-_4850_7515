using System;
using System.Collections.Generic;
namespace DALPI
{
    public interface IDL 
    {
        #region bus
        IEnumerable<DO.BusLine> GetAllBuses();
        IEnumerable<DO.BusLine> GetAllCusesBy(Predicate<DO.BusLine> predicate);
        DO.BusLine GetBus(int id);
        void AddBus(DO.BusLine bus);
        void UpdateBus(DO.BusLine bus);
        void UpdateBus(int id, Action<DO.BusLine> update); //method that knows to updt specific fields in Person
        void DeleteBus(int id);
        #endregion

        #region Station
        IEnumerable<DO.BusLine> GetAllStations();
        IEnumerable<DO.BusLine> GetAllStationsBy(Predicate<DO.BusLine> predicate);
        DO.BusLine GetStation(int id);
        void AddStation(DO.BusLine bus);
        void UpdateStation(DO.BusLine bus);
        void UpdateStation(int id, Action<DO.BusLine> update); //method that knows to updt specific fields in Person
        void DeleteStation(int id);
        #endregion

        #region BusLine
        IEnumerable<DO.BusLine> GetAllBusLines();
        IEnumerable<DO.BusLine> GetAllBusLinesBy(Predicate<DO.BusLine> predicate);
        DO.BusLine GetBusLine(int id);
        void AddBusLine(DO.BusLine bus);
        void UpdateBusLine(DO.BusLine bus);
        void UpdateBusLine(int id, Action<DO.BusLine> update); //method that knows to updt specific fields in Person
        void DeleteBusLine(int id);
        #endregion
    }
}
