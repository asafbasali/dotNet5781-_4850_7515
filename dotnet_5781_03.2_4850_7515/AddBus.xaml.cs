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

namespace dotnet_5781_03._2_4850_7515
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string date;
        public string Busnumber;
        public Window1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public void onclick(object sender, RoutedEventArgs e)
        {
            date = textBox1.Text;
            Busnumber = textBox.Text;
            this.Close();
        }
    }
}
