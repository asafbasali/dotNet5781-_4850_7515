using System;
using System.Collections.Generic;
using DO;
namespace DALPI
{
    public interface IDL 
    {
        #region bus
        IEnumerable<DO.Bus> GetAllBuses();
        IEnumerable<DO.Bus> GetAllCusesBy(Predicate<DO.Bus> predicate);
        DO.Bus GetBus(int id);
        void AddBus(DO.Bus bus);
        void UpdateBus(DO.Bus bus);
        void UpdateBus(int id, Action<DO.Bus> update); //method that knows to updt specific fields in Person
        void DeleteBus(int id);
        #endregion

        #region Station

        #endregion
    }
}
