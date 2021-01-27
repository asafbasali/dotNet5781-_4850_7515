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
using System.Timers;
using System.Threading;
using System.Globalization;

namespace dotnet_5781_03._2_4850_7515
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum status {readytodrive,driving,fueling,treating}
        class Bus
        {
            static int fuel;
            static int totaldis;
            static int sumdis = 0;
            public string ID { get; set; }
            public DateTime start_date = new DateTime();
            static DateTime timesincelasttreatment = new DateTime();
            public int BusNum { get; set; }
            

            public void t()
            {
                Console.WriteLine(start_date);
            }

            public Bus(string _id, DateTime date)
            {
                ID = _id;
                start_date = date;
                fuel = 1200;
                totaldis = 20000;
            }
            public void StartDrive(int _dis)
            {
                int count = 1;
                if (totaldis - _dis <= 0)
                {
                    Console.WriteLine("you can't drive you need to treat your Bus\n");
                    count = 0;
                }
                if (fuel - _dis * 0.5 <= 0 && count == 1)
                {
                    Console.WriteLine("you can't drive you need to fuel your Bus\n");
                }
                else if (count != 0)
                {
                    totaldis -= _dis;
                    sumdis += _dis;
                    fuel -= _dis;
                    Console.WriteLine("You can go");
                }
            }

            public void Treating_your_Bus()
            {
                totaldis = 40000;
                timesincelasttreatment = DateTime.Now;
            }
            public void Fuel_your_Bus()
            {
                fuel = 2000;
            }

            public void Print_deatails()
            {
                Console.WriteLine("\nID " + ID + " " + "\ntotal distance: " + totaldis + "\n all distance the Bus did: " + sumdis + "\n" + "strting date: " + start_date + "\n");
            }
            public override string ToString()
            {
                return "\nID " + ID + " " + "\ntotal distance: " + totaldis + "\n all distance the Bus did: " + sumdis + "\n" + "strting date: " + start_date + "\n";
            }
        }
        List<Bus> buses = new List<Bus>();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                DateTime temp = new DateTime();
                temp = DateTime.Now;
                buses.Add(new Bus(Convert.ToString(1+i), temp));
            }
            BusesList.ItemsSource = buses;
            
        }
        private Bus currentDisplayBus;
        public void Showbus(int index)
        {
            if (index < buses.Count)
            {
                currentDisplayBus = buses[index];
                buslist.DataContext = currentDisplayBus;
                BusesList.DataContext = currentDisplayBus;
            }
            else
            {
                MessageBox.Show("not exist");
            }
        }
        private void BusesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(BusesList.SelectedItem.ToString());
            
        }

        private void openwindow(object sender, RoutedEventArgs e)
        {
            Window1 newwindow = new Window1();
            this.Visibility = Visibility.Visible;
            newwindow.ShowDialog();
            string num = Convert.ToString(newwindow.Busnumber);
            DateTime newdate = newwindow.date;
            buses.Add(new Bus(num, newdate));
            BusesList.Items.Refresh();
            InitializeComponent();
        }
    }
}
