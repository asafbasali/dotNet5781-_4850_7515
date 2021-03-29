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
    /// Interaction logic for Addbus.xaml
    /// </summary>
    public partial class Addbus : Window
    {
        BL.BLObject bl = new BL.BLI();
        public Addbus()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            bl.AddBus(3000, 0, textBox.Text);
            this.Close();
            MessageBox.Show("Bus Added");
        }
    }
}
