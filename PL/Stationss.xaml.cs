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

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddStation As = new AddStation();
            As.ShowDialog();
            stations.ItemsSource = bl.GetAllStations();
        }

        private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            RemveStation rs = new RemveStation();
            rs.ShowDialog();
            stations.ItemsSource = bl.GetAllStations();
        }
    }
}
