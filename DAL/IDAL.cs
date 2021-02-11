using System;
using System.Collections.Generic;

namespace DAL
{
    public class IDAL : DALObject
    {
        #region BusLine
        void DALObject.AddBusLine(DO.BusLine busline)
        {
            bool B = false;
            foreach (DO.BusLine bus in DS.DataBase.BusLines)
            {
                if (bus.busnumber == busline.busnumber)
                {
                    B = true;
                }
            }
            if (!B)
            {
                DS.DataBase.BusLines.Add(busline);
            }
            else
            {
                //throw exeption
            }
        }
        void DALObject.RemoveBusLine(int ID)
        {
            DO.BusLine temp = new DO.BusLine();
            foreach (DO.BusLine busline in DS.DataBase.BusLines)
            {
                if (busline.Id == ID)
                {
                    temp = busline;
                }
            }
            if (temp != null)
            {
                DS.DataBase.BusLines.Remove(temp);
            }
            else
            {
                //throw exeption
            }
        }
        DO.BusLine DALObject.GetBusLine(int ID)
        {
            try
            {
                foreach (DO.BusLine Bus in DS.DataBase.BusLines)
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
            return null;
        }
        void DALObject.RemoveStationFromBusLine(int StationNumber, int ID)
        {
            foreach (DO.BusLine Busline in DS.DataBase.BusLines)
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
            foreach (DO.BusLine bus in DS.DataBase.BusLines)
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
        List<DO.BusLine> DALObject.GetallBusLines()
        {
            return DS.DataBase.BusLines;   
        }
        #endregion

        #region Station
        void DALObject.AddStation(DO.Station newsstation)
        {
            DS.DataBase.Stations.Add(newsstation);
        }
        DO.Station DALObject.GetStation(int ID)
        {
            foreach (DO.Station station in DS.DataBase.Stations)
            {
                if (station.sBusStationKey == ID)
                {
                    return station;
                }
            }
            return null;
        }
        void DALObject.removeStation(int ID)
        {
            DO.Station station1 = new DO.Station();
            foreach (DO.Station station in DS.DataBase.Stations)
            {
                if (station.sBusStationKey == ID)
                {
                    station1 = station;
                    DS.DataBase.Stations.Remove(station);
                    break;
                }
                foreach (DO.BusLine Line in DS.DataBase.BusLines)
                {
                    if (Line.Stations.Contains(station1))
                    {
                        Line.Stations.Remove(station1);
                    }
                }
            }
        }
        List<DO.Station> DALObject.GetallStations()
        {
            return DS.DataBase.Stations;
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
        bool DALObject.IsBusExist(string ID)
        {
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == ID)
                {
                    return true;
                }
            }
            return false;
        }
        DO.Bus DALObject.GetBus(string ID)
        {
            foreach (DO.Bus Bus in DS.DataBase.Buses)
            {
                if (Bus.iD == ID)
                {
                    return Bus;
                }
            }
            return null;
        }
        List<DO.Bus> DALObject.GetallBuses()
        {
            return DS.DataBase.Buses;
        }
        #endregion

        #region user
        void DALObject.AddUser(DO.User User)
        {
            bool B = false;
            foreach (DO.User user in DS.DataBase.Users)
            {
                if (User.UserName == user.UserName)
                {
                    B = true;
                }
            }
            if (!B)
            {
                DS.DataBase.Users.Add(User);
            }
            else
            {
                //throw exeption
            }
        }
        bool DALObject.Checkifuserexsist(string username, string password)
        {
            foreach (DO.User user in DS.DataBase.Users)
            {
                if (user.UserName == username)
                {
                    if (user.UserPassword == password)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        void DALObject.RemoveUser(string UserName, string Password)
        {
            DO.User temp = new DO.User();
            foreach (DO.User user in DS.DataBase.Users)
            {
                if (user.UserName == UserName)
                {
                    temp = user;
                }
            }
            if (temp != null && temp.UserPassword == Password)
            {
                DS.DataBase.Users.Remove(temp);
            }
            else
            {
                //throw exeption
            }
        }
        DO.User DALObject.GetUser(string name)
        {
            foreach (DO.User user in DS.DataBase.Users)
            {
                if (user.name == name)
                {
                    return user;
                }
            }
            return null;
        }
        #endregion
    }
}
