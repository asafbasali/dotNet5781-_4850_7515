using System.Windows.Controls;

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
