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

namespace dotnet_5781_03._2._1_4850_7515
{
    /// <summary>
    /// Interaction logic for AddBus.xaml
    /// </summary>
    public partial class AddBus : Window
    {
        public DateTime date = new DateTime();
        public string Busnumber;
        public AddBus()
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
            date = this.mydate.DisplayDate;
            Busnumber = textBox.Text;
            this.Close();
        }
    }
}
