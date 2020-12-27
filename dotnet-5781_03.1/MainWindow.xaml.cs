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
        List<BusLine> izick = new List<BusLine>();
        class BusLine
        {
            List<BusLine> Stations = new List<BusLine>();
            internal string FirstStation;
            internal string LastStation;
            internal int Bus_Line;
            internal string Area;

            public override string ToString()
            {
                return "Bus Line: " + Bus_Line + " Area: " + Area + " Stations: " + Stations;
            }


        }
        public MainWindow()
        {
            InitializeComponent();

            
            for (int i = 0; i < 10; i++)
            {
                izick.Add(new BusLine());
            }
        }

        private void cbBusLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
