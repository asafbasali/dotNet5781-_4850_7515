﻿using BL;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BLObject bl = new BLI();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void userpassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            bl.AddBus(2000, 0, "123-123-123");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            newListWindow window = new newListWindow();
            DO.Bus bus = new DO.Bus();
            bus = bl.GetBus("123-123-123");
            window.MyLabel.Content = bus.fuel;
            window.ShowDialog();
        }
    }
}
