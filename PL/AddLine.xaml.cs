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
    /// Interaction logic for AddLine.xaml
    /// </summary>
    public partial class AddLine : Window
    {
        BL.IBL bl = new BL.BL();
        public AddLine()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            if (textBox.Text!= "" && textBox_Copy.Text != "")
            {
                string b = textBox.Text;
                int a = Int32.Parse(b);
                bl.AddBusLine(a, textBox_Copy.Text, 0, 0);
                this.Close();
            }
            else
            {
                MessageBox.Show("please try again !");
            }
        }
    }
}
