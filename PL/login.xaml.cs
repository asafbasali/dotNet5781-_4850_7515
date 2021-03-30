using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Timers;
using System.ComponentModel;
using System.Windows.Threading;

namespace PL
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class login : Window
    {
        BL.BLObject bl = new BL.BLI();
        public DateTime CurrentDateTime = DateTime.Now;
        public login()
        {
            InitializeComponent();
            Dashboard dash = new Dashboard();
            main1.Content = dash;
        }
        
        void timer_Tick(object sender, EventArgs e)
        {
            CurrentDateTime = DateTime.Now;
        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e) 
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        } 
        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            DragMove();
        }
        private void windowloaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dt_tick;
            dt.Start();
        }
        private void dt_tick(object sender, EventArgs e)
        {
            CurrentDateTime = DateTime.Now;

            timelabel.Content = CurrentDateTime.ToString();
        }
        private void open_busses(object sender, RoutedEventArgs e)
        {
            main1.Content = new Busesss();
        }
        private void open_Profiles(object sender, RoutedEventArgs e)
        {
            main1.Content = new Profiless();
        }
        private void open_lines(object sender, RoutedEventArgs e)
        {
            main1.Content = new Liness();
        }
        private void open_stations(object sender, RoutedEventArgs e)
        {
            main1.Content = new Stationss();
        }
    }
}
