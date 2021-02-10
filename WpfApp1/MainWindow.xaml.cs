using System.Windows;
using System.Windows.Controls;
using BL;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void userpassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            new Window1().Show();
            Close();
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
