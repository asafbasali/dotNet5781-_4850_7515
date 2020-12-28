using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dotnet_5781_03._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class BusStation
        {
            public Random location = new Random();
            internal int sBusStationKey;
            internal double Latitude;
            internal double Longitude;
            internal string Busstationaddres = "look for me";


            public BusStation(int _sBusStationKey = 0)
            {
                Latitude = location.Next(-90, 90);
                Longitude = location.Next(-180, 180);
                if (_sBusStationKey > 0 && _sBusStationKey < 100000)
                {
                    sBusStationKey = _sBusStationKey;
                }
                else
                {
                    Console.WriteLine("your input is wrong please try again!");
                }

            }

            public override string ToString()
            {
                return "Bus Station Code: " + sBusStationKey + " ,location: " + Latitude + ", " + Longitude + " address" + Busstationaddres;
            }
        }
        List<BusLine> busLines = new List<BusLine>();
        class BusLine
        {
            private List<BusStation> Stations = new List<BusStation>();
            internal string FirstStation;
            internal string LastStation;
            internal int Bus_Line;
            internal string Area;
            int timeswecreatedastation = 0;
            public BusLine(int _Bus_Line = 0, string _Area = "")
            {
                //if (_FirstStation!="")
                //{
                //    FirstStation = _FirstStation;
                //}
                //else
                //{

                //}
                //if (_LastStation != "")
                //{
                //    LastStation = _FirstStation;
                //}
                //else
                //{

                //}
                if (_Bus_Line != 0)
                {
                    Bus_Line = _Bus_Line;
                }
                if (Area != "")
                {
                    Area = _Area;
                }
                else
                {
                    Console.WriteLine("your input is wrong please try again!");
                }
                timeswecreatedastation++;
            }

            public override string ToString()
            {
                Console.WriteLine("Bus Line: " + Bus_Line + " Area: " + Area + " Stations: ");
                Stations.ForEach(Console.WriteLine);
                return "";
            }

            internal void AddStation(BusStation NewBusStation)
            {
                Stations.Add(NewBusStation);//הוספנו מחלקת תחנת אוטובוס לרשימת התחנות שלנו
            }

            internal void RemoveStation(int StaionNumber)
            {
                foreach (BusStation station in Stations)
                {
                    if (StaionNumber == station.sBusStationKey)
                    {
                        Stations.Remove(station);
                        break;
                    }
                }
            }

            internal int DisBetweenstations(int key1, int key2)
            {
                BusStation dissum1 = null;
                BusStation dissum2 = null;
                foreach (BusStation station in Stations)
                {
                    if (station.sBusStationKey == key1)
                    {
                        dissum1 = station;
                    }
                    if (station.sBusStationKey == key2)
                    {
                        dissum2 = station;
                    }
                }
                if (dissum1.sBusStationKey == key1 && dissum2.sBusStationKey == key2)
                {
                    return Convert.ToInt32(Math.Sqrt(Convert.ToInt32(Math.Pow(dissum1.Latitude - dissum2.Latitude, 2)) + Convert.ToInt32(Math.Pow(dissum1.Longitude - dissum2.Longitude, 2))));
                }
                else
                {
                    return 0;
                }
            }

            internal bool isstationexist(int _ID)
            {
                foreach (BusStation station in Stations)
                {
                    if (station.sBusStationKey == _ID)
                    {
                        return true;
                    }
                }
                return false;
            }

            public List<BusStation> STations
            {
                get { return Stations; }
            }
        }
        public MainWindow()
        {

            InitializeComponent();
            cbBusLines.ItemsSource = busLines;
            cbBusLines.DisplayMemberPath = " BusLineNum ";
            cbBusLines.SelectedIndex = 0;
            BusLine currentDisplayBusLine;
            for (int i = 0; i < 10; i++)
            {
                busLines.Add(new BusLine());
            }
        }
        private BusLine currentDisplayBusLine;

        private void ShowBusLine(int index)
        {
            currentDisplayBusLine = busLines[index];
            UpGrid.DataContext = currentDisplayBusLine;
            lbBusLineStations.DataContext = currentDisplayBusLine.STations;
        }


        private void cbBusLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowBusLine((cbBusLines.SelectedValue as BusLine).BusLineNum);
        }
    }
}

