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
    /// Interaction logic for Removebus.xaml
    /// </summary>
    public partial class Removebus : Window
    {
        BL.IBL bl = new BL.BL();
        public Removebus()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            bl.RemoveBus(textBox1.Text);
            this.Close();
            MessageBox.Show("Bus Removed");
        }
    }
}
