using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


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
