using System;
using System.Collections.Generic;
using System.Text;

using DS;

namespace BL
{
    class BLI
    {
        #region BusLine
        DO.BusLine GetBusLine(int ID)
        {
            try
            {
                foreach(DO.BusLine Bus in DS.DataBase.Lines)
                {
                    if (Bus.Id == ID)
                    {
                        return Bus;
                    }
                }
            }
            catch (Exception notexist)
            {
                throw;
            }
            return new DO.BusLine();
        }
        void AddStation(DO.Station NewBusStation)
        {
            DS.DataBase.Stations.Add(NewBusStation);//הוספנו מחלקת תחנת אוטובוס לרשימת התחנות שלנו
        }
        void RemoveStation(int StaionNumber)
        {
            foreach (DO.Station station in DS.DataBase.Stations)
            {
                if (StaionNumber == station.sBusStationKey)
                {
                    DS.DataBase.Stations.Remove(station);
                    break;
                }
            }
        }
        void UpdateBusLine(int ID,DO.BusLine newbusline)
        {
            DO.BusLine temp = new DO.BusLine();
            foreach (DO.BusLine bus in DS.DataBase.Lines)
            {
                if (bus.Id == ID)
                {
                    temp = bus;
                }
            }
            if (temp!=null)
            {
                temp = newbusline;
            }
            else
            {
                Console.WriteLine("there is no bus with this ID");
            }
        }

        #endregion
    }
}
