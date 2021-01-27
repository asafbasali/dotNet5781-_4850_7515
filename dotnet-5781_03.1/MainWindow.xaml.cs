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
        Random R;
        class BusStation
        {
            public Random location = new Random();
            internal int sBusStationKey;
            internal double Latitude;
            internal double Longitude;
            internal string Busstationaddres = "look for me";


            public BusStation(int _sBusStationKey)
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
        List<BusLine> busLines;
        class BusLine
        {
            private List<BusStation> Stations = new List<BusStation>();
            internal string FirstStation;
            internal string LastStation;
            internal int Bus_Line;
            internal string Area;
            int timeswecreatedastation = 0;
            public int BusLineNum { get; set; }

            public BusLine()
            {

            }

            public BusLine(int _Bus_Line, string _Area)
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
                    BusLineNum = _Bus_Line;
                    Area = _Area;
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

            busLines = new List<BusLine>();

            for (int i = 0; i < 10; i++)
            {
                busLines.Add(new BusLine(i + 1, "north"));
            }
            #region addstations
            busLines[0].STations.Add(new BusStation(6));
            busLines[0].STations.Add(new BusStation(7));
            busLines[0].STations.Add(new BusStation(4));


            busLines[1].STations.Add(new BusStation(11));
            busLines[1].STations.Add(new BusStation(65));
            busLines[1].STations.Add(new BusStation(98));


            busLines[2].STations.Add(new BusStation(76));
            busLines[2].STations.Add(new BusStation(89));
            busLines[2].STations.Add(new BusStation(78));


            busLines[3].STations.Add(new BusStation(65));
            busLines[3].STations.Add(new BusStation(47));
            busLines[3].STations.Add(new BusStation(54));


            busLines[4].STations.Add(new BusStation(53));
            busLines[4].STations.Add(new BusStation(34));
            busLines[4].STations.Add(new BusStation(23));


            busLines[5].STations.Add(new BusStation(90));
            busLines[5].STations.Add(new BusStation(09));
            busLines[5].STations.Add(new BusStation(8));


            busLines[6].STations.Add(new BusStation(66));
            busLines[6].STations.Add(new BusStation(69));
            busLines[6].STations.Add(new BusStation(1));


            busLines[7].STations.Add(new BusStation(100));
            busLines[7].STations.Add(new BusStation(102));
            busLines[7].STations.Add(new BusStation(103));


            busLines[8].STations.Add(new BusStation(200));
            busLines[8].STations.Add(new BusStation(202));
            busLines[8].STations.Add(new BusStation(203));


            busLines[9].STations.Add(new BusStation(300));
            busLines[9].STations.Add(new BusStation(301));
            busLines[9].STations.Add(new BusStation(302));
            #endregion

            cbBusLines.ItemsSource = busLines;
            cbBusLines.DisplayMemberPath = "BusLineNum";
            cbBusLines.SelectedIndex = 0;
            BusLine currentDisplayBusLine = new BusLine();
            ShowBusLine(cbBusLines.SelectedIndex);
        }
        private BusLine currentDisplayBusLine;

        private void ShowBusLine(int index)
        {
            if (index<busLines.Count)
            {
                currentDisplayBusLine = busLines[index];
                UpGrid.DataContext = currentDisplayBusLine;
                lbBusLineStations.DataContext = currentDisplayBusLine.STations;
            }
            else
            {
                MessageBox.Show("not exist");
            }

        }


        private void cbBusLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowBusLine((cbBusLines.SelectedValue as BusLine).BusLineNum);
        }

        private void lbBusLineStations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowBusLine((cbBusLines.SelectedValue as BusLine).BusLineNum);
            lbBusLineStations.Items.Refresh();
        }

        private void cbBusLines_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

