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

namespace PL
{
    /// <summary>
    /// Interaction logic for Stationss.xaml
    /// </summary>
    public partial class Stationss : Page
    {
        BL.BLObject bl = new BL.BLI();
        public Stationss()
        {
            InitializeComponent();
            stations.ItemsSource = bl.GetAllStations();
        }
    }
}
