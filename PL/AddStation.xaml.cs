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
    /// Interaction logic for AddStation.xaml
    /// </summary>
    public partial class AddStation : Window
    {
        BL.IBL bl = new BL.BL();
        public AddStation()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            bl.AddStation(Int32.Parse(textBox.Text), 0, 0, textBox_Copy.Text);
            this.Close();
            MessageBox.Show("Stetion Added");
        }
    }
}
