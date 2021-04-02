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
    /// Interaction logic for AddexitLine.xaml
    /// </summary>
    public partial class AddexitLine : Window
    {
        BL.IBL bl = new BL.BL();
        public AddexitLine()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "" && textBox1.Text != "" && textBox_Copy.Text != "")
            {
                bl.Addonthemovebus(Int32.Parse(textBox1.Text), Int32.Parse(textBox.Text), Int32.Parse(textBox_Copy.Text));
                Close();
                MessageBox.Show("Line Added To Driving List");
            }
            else
            {
                MessageBox.Show("Please Try Again");
            }
        }
    }
}
