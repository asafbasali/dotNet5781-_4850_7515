using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IDAL : DALObject
    {
        #region BusLine
        DO.BusLine DALObject.GetBusLine(int ID)
        {
            try
            {
                foreach (DO.BusLine Bus in DS.DataBase.Lines)
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
        void DALObject.AddStationToBusLine(DO.Station NewBusStation, int ID)
        {
            foreach (DO.BusLine Busline in DS.DataBase.Lines)
            {
                if (Busline.Id == ID)
                {
                    Busline.Stations.Add(NewBusStation);
                }
            }
        }
        void DALObject.RemoveStationFromBusLine(int StationNumber, int ID)
        {
            foreach (DO.BusLine Busline in DS.DataBase.Lines)
            {
                if (Busline.Id == ID)
                {
                    foreach (DO.Station station in Busline.Stations)
                    {
                        if (station.sBusStationKey == StationNumber)
                        {
                            Busline.Stations.Remove(station);
                            break;
                        }
                    }
                }
            }
        }
        void DALObject.UpdateBusLine(int ID, DO.BusLine newbusline)
        {
            DO.BusLine temp = new DO.BusLine();
            foreach (DO.BusLine bus in DS.DataBase.Lines)
            {
                if (bus.Id == ID)
                {
                    temp = bus;
                }
            }
            if (temp != null)
            {
                temp = newbusline;
            }
            else
            {
                Console.WriteLine("there is no bus with this ID");
            }
        }

        #endregion

        #region Station
        void DALObject.AddStation(DO.Station newsstation)
        {
            DS.DataBase.Stations.Add(newsstation);
        }

        void DALObject.removeStation(int ID)
        {
            foreach (DO.Station station in DS.DataBase.Stations)
            {
                if (station.sBusStationKey == ID)
                {
                    DS.DataBase.Stations.Remove(station);
                    break;
                }
            }
        }
        #endregion

        #region Bus
        
        void DALObject.AddBus(DO.Bus Bus)
        {
            bool B = false;
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == Bus.iD)
                {
                    B = true;
                }
            }
            if (B == false)
            {
                DS.DataBase.Buses.Add(Bus);
            }
            else
            {
                //throw exeption
            }
            
        }

        void DALObject.RemoveBus(string ID)
        {
            DO.Bus B = new DO.Bus();
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == ID)
                {
                    B = bus;
                }
            }
            if (B == null)
            {
                DS.DataBase.Buses.Remove(B);
            }
            else
            {
                //throw exeption
            }
        }
        //bool DALObject.IsBusExist(string ID)
        //{
        //    foreach (DO.Bus bus in DS.DataBase.Buses)
        //    {
        //        if (bus.iD == ID)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public void Print_deatails()
        //{
        //    Console.WriteLine("\nID " + iD + " " + "\ntotal distance: " + totaldis + "\n all distance the Bus did: " + sumdis + "\n" + "strting date: " + start_date + "\n");
        //}
        #endregion

        #region user

        #endregion
    }
}
