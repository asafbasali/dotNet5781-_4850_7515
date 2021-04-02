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
    /// Interaction logic for Busesss.xaml
    /// </summary>
    public partial class Busesss : Page
    {
        BL.IBL bl = new  BL.BL();
        public Busesss()
        {
            InitializeComponent();
            Busess.ItemsSource = bl.GetAllBuses();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Addbus addbus = new Addbus();
            addbus.ShowDialog();
            Busess.ItemsSource = bl.GetAllBuses();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Removebus removebus = new Removebus();
            removebus.ShowDialog();
            Busess.ItemsSource = bl.GetAllBuses();
        }
    }
}
