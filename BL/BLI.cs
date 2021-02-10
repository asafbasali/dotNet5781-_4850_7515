using System;
using System.Collections.Generic;
using System.Text;

using DS;

namespace BL
{
    public class BLI
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
        void AddStationToBusLine(DO.Station NewBusStation,int ID)
        {
            foreach (DO.BusLine Busline in DS.DataBase.Lines)
            {
                if (Busline.Id == ID)
                {
                    Busline.Stations.Add(NewBusStation);
                }
            }    
        }
        void RemoveStationFromBusLine(int StationNumber,int ID)
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

        #region Station
        public void AddStation(DO.Station newsstation)
        {
            DS.DataBase.Stations.Add(newsstation);
        }

        public void removeStation(int ID)
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
        //public string GetID()
        //{
        //    return DS.DataBase.Buses.iD;
        //}
        //public void t(int ID)
        //{

        //    Console.WriteLine(start_date);
        //}

        //public Bus(string _id, DateTime date)
        //{
        //    bus.iD = _id;
        //    start_date = date;
        //    fuel = 1200;
        //    totaldis = 20000;
        //}
        public void StartDrive(int _dis,int ID)
        {
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == ID)
                {
                    int count = 1;
                    if (bus.totaldis - _dis <= 0)
                    {
                        Console.WriteLine("you can't drive you need to treat your Bus\n");
                        count = 0;
                    }
                    if (bus.fuel - _dis * 0.5 <= 0 && count == 1)
                    {
                        Console.WriteLine("you can't drive you need to fuel your Bus\n");
                    }
                    else if (count != 0)
                    {
                        bus.totaldis -= _dis;
                        bus.sumdis += _dis;
                        bus.fuel -= _dis;
                        Console.WriteLine("You can go");
                    }
                }
            }

        }

        public void Treating_your_Bus(int ID)
        {
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == ID)
                {
                    bus.totaldis = 20000;
                    break;
                }
            }
        }

        public void Fuel_your_Bus(int ID)
        {
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == ID)
                {
                    bus.fuel = 20000;
                    break;
                }
            }
        }

        //public void Print_deatails()
        //{
        //    Console.WriteLine("\nID " + iD + " " + "\ntotal distance: " + totaldis + "\n all distance the Bus did: " + sumdis + "\n" + "strting date: " + start_date + "\n");
        //}
        #endregion

        #region user

        #endregion
    }
}
