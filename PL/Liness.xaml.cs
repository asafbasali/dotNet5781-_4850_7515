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
    /// Interaction logic for Liness.xaml
    /// </summary>
    public partial class Liness : Page
    {
        BL.BLObject bl = new BL.BLI();
        public Liness()
        {
            InitializeComponent();
            List<BO.BusLine> lists = bl.GetAllBusLines();
            linesss.ItemsSource = lists;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonFechar_Click1(object sender, RoutedEventArgs e)
        {
            login login = new login();
            this.Content = null;
            login.Show();
        }
    }
}
