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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        BL.BLObject bl = new BL.BLI();
        public Dashboard()
        {
            InitializeComponent();
            dashboard.ItemsSource = bl.GetExiteLines();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddexitLine ae = new AddexitLine();
            ae.ShowDialog();
            dashboard.ItemsSource = bl.GetExiteLines();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RemoveExit re = new RemoveExit();
            re.ShowDialog();
            dashboard.ItemsSource = bl.GetExiteLines();
        }
    }
}
