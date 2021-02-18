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
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class login : Window
    {
        BL.BLObject bl = new BL.BLI();
        public login()
        {
            InitializeComponent();
            main.ItemsSource = bl.GetAllBuses();
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

        private void open_busses(object sender, RoutedEventArgs e)
        {
            //PROFILE
            MessageBox.Show("new window");
            this.Content = new Busesss();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
