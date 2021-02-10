using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IDAL : DALObject
    {
        DS.DataBase ds = new DS.DataBase();
        #region BusLine
        void DALObject.AddBusLine(DO.BusLine busline)
        {
            bool B = false;
            foreach (DO.BusLine bus in ds.Lines)
            {
                if (bus.busnumber == busline.busnumber)
                {
                    B = true;
                }
            }
            if (!B)
            {
                ds.Lines.Add(busline);
            }
            else
            {
                //throw exeption
            }
        }
        void DALObject.RemoveBusLine(int ID)
        {
            DO.BusLine temp = new DO.BusLine();
            foreach (DO.BusLine busline in ds.Lines)
            {
                if (busline.busnumber == ID)
                {
                    temp = busline;
                }
            }
            if (temp != null)
            {
                ds.Lines.Remove(temp);
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
                foreach (DO.BusLine Bus in ds.Lines)
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
        void DALObject.AddStationToBusLine(DO.Station NewBusStation, int ID)
        {
            foreach (DO.BusLine Busline in ds.Lines)
            {
                if (Busline.Id == ID)
                {
                    Busline.Stations.Add(NewBusStation);
                }
            }
        }
        void DALObject.RemoveStationFromBusLine(int StationNumber, int ID)
        {
            foreach (DO.BusLine Busline in ds.Lines)
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
            foreach (DO.BusLine bus in ds.Lines)
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
            return ds.Lines;   
        }
        #endregion

        #region Station
        void DALObject.AddStation(DO.Station newsstation)
        {
            ds.Stations.Add(newsstation);
        }
        DO.Station DALObject.GetStation(int ID)
        {
            foreach (DO.Station station in ds.Stations)
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
            foreach (DO.Station station in ds.Stations)
            {
                if (station.sBusStationKey == ID)
                {
                    ds.Stations.Remove(station);
                    break;
                }
            }
        }
        List<DO.Station> DALObject.GetallStations()
        {
            return ds.Stations;
        }
        #endregion

        #region Bus
        void DALObject.AddBus(DO.Bus Bus)
        {
            bool B = false;
            foreach (DO.Bus bus in ds.Buses)
            {
                if (bus.iD == Bus.iD)
                {
                    B = true;
                }
            }
            if (B == false)
            {
                ds.Buses.Add(Bus);
            }
            else
            {
                //throw exeption
            }
        }
        void DALObject.RemoveBus(string ID)
        {
            DO.Bus B = new DO.Bus();
            foreach (DO.Bus bus in ds.Buses)
            {
                if (bus.iD == ID)
                {
                    B = bus;
                }
            }
            if (B == null)
            {
                ds.Buses.Remove(B);
            }
            else
            {
                //throw exeption
            }
        }
        bool DALObject.IsBusExist(string ID)
        {
            foreach (DO.Bus bus in ds.Buses)
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
            foreach (DO.Bus Bus in ds.Buses)
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
            return ds.Buses;
        }
        #endregion

        #region user
        void DALObject.AddUser(DO.User User)
        {
            bool B = false;
            foreach (DO.User user in ds.Users)
            {
                if (User.UserName == user.UserName)
                {
                    B = true;
                }
            }
            if (!B)
            {
                ds.Users.Add(User);
            }
            else
            {
                //throw exeption
            }
        }
        void DALObject.RemoveUser(string UserName, string Password)
        {
            DO.User temp = new DO.User();
            foreach (DO.User user in ds.Users)
            {
                if (user.UserName == UserName)
                {
                    temp = user;
                }
            }
            if (temp != null && temp.UserPassword == Password)
            {
                ds.Users.Remove(temp);
            }
            else
            {
                //throw exeption
            }
        }
        DO.User DALObject.GetUser(string name)
        {
            foreach (DO.User user in ds.Users)
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
