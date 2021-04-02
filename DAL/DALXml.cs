using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DalApi;

namespace DAL
{
    public class DALXml : IDAL
    {
        #region Singleton
        static readonly DALXml instance = new DALXml();
        static DALXml() { }
        DALXml() { }
        public static DALXml Instance => instance;
        #endregion

        internal XElement LoadXml(string path)
        {
            try { return XElement.Load(path); }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        #region Pathes
        internal static readonly string path = Path.GetFullPath(
            Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"))
                            + @"XMLFiles\{0}.xml";
        internal readonly string configPath = String.Format(path, "config");
        internal readonly string usersPath = String.Format(path, "Users");
        internal readonly string stationsPath = String.Format(path, "Stations");
        internal readonly string linesPath = String.Format(path, "Lines");
        internal readonly string adjStationsPath = String.Format(path, "Adjacent Stations");
        internal readonly string stationsLinePath = String.Format(path, "Stations Line");
        internal readonly string lineTripsPath = String.Format(path, "Line Trips");
        internal readonly string lineTimingsPath = String.Format(path, "Line Timing");
        #endregion

        #region BusLine
        public void AddBusLine(DO.BusLine busline)
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
        public void RemoveBusLine(int ID)
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
        public DO.BusLine GetBusLine(int ID)
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
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }
        public void RemoveStationFromBusLine(int StationNumber, int ID)
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
        public void UpdateBusLine(int ID, DO.BusLine newbusline)
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
        public List<DO.BusLine> GetallBusLines()
        {
            return DS.DataBase.BusLines;
        }
        #endregion

        #region Station
        internal IEnumerable<DO.Station> LoadStationsFromXml(XElement stationsRoot)
        {
            List<DO.Station> stations = new List<DO.Station>();
            foreach (var station in stationsRoot.Elements())
            {
                stations.Add(new DO.Station
                {
                    sBusStationKey = int.Parse(station.Element("sBusStationKey").Value),
                    Busstationaddres = station.Element("sBusStationKey").Value,
                    Longitude = double.Parse(station.Element("Longitude").Value),
                    Latitude = double.Parse(station.Element("sBusStationKey").Value)
                });
            }
            return stations;
        }

        public void AddStation(DO.Station newsstation)
        {
            DS.DataBase.Stations.Add(newsstation);
        }
        public DO.Station GetStation(int ID)
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
        public void removeStation(int ID)
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
        public List<DO.Station> GetallStations()
        {
            return DS.DataBase.Stations;
        }
        #endregion

        #region Bus
        public void AddBus(DO.Bus Bus)
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
        public void RemoveBus(string ID)
        {
            DO.Bus B = new DO.Bus();
            foreach (DO.Bus bus in DS.DataBase.Buses)
            {
                if (bus.iD == ID)
                {
                    B = bus;
                }
            }
            if (B != null)
            {
                DS.DataBase.Buses.Remove(B);
            }
            else
            {
                //throw exeption
            }
        }
        public bool IsBusExist(string ID)
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
        public DO.Bus GetBus(string ID)
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
        public List<DO.Bus> GetallBuses()
        {
            return DS.DataBase.Buses;
        }
        #endregion

        #region user
        public void AddUser(DO.User User)
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
        public bool Checkifuserexsist(string username)
        {
            foreach (DO.User user in DS.DataBase.Users)
            {
                if (user.UserName == username)
                {
                    return true;
                }
            }
            return false;
        }
        public void RemoveUser(string UserName, string Password)
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
        public string GetUserPass(string name)
        {
            foreach (DO.User user in DS.DataBase.Users)
            {
                if (user.UserName == name)
                {
                    return user.UserPassword;
                }
            }
            return "not exist";
        }
        public List<DO.User> GetAllUsers()
        {
            return DS.DataBase.Users;
        }
        #endregion

        #region OnTheMoveBus
        public void AddOnTheMoveBus(DO.exiteLine exite)
        {
            DS.DataBase.onthemoveline.Add(exite);
        }
        public void RemoveOnTheMoveBus(int ID)
        {
            DO.exiteLine temp = new DO.exiteLine();
            foreach (DO.exiteLine user in DS.DataBase.onthemoveline)
            {
                if (user.IDLinebus == ID)
                {
                    temp = user;
                }
            }
            if (temp != null)
            {
                DS.DataBase.onthemoveline.Remove(temp);
            }
            else
            {
                //throw exeption
            }
        }
        public List<DO.exiteLine> GetAllOntheMoveBus()
        {
            return DS.DataBase.onthemoveline;
        }
        #endregion
    }
}
