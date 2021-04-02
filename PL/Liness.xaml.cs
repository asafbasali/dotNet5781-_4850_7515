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
        BL.IBL bl = new BL.BL();
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

        private void AddLine_Click(object sender, RoutedEventArgs e)
        {
            AddLine al = new AddLine();
            al.ShowDialog();
            linesss.ItemsSource = bl.GetAllBusLines();
        }

        private void RemoveLine_Click(object sender, RoutedEventArgs e)
        {
            RemoveLine ar = new RemoveLine();
            ar.ShowDialog();
            linesss.ItemsSource = bl.GetAllBusLines();
        }
        private void fuel_click(object sender, RoutedEventArgs e)
        {
            
        }
        private void trip_click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
