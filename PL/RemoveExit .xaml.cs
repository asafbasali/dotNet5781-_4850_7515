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
    /// Interaction logic for RemoveExit.xaml
    /// </summary>
    public partial class RemoveExit : Window
    {
        BL.BLObject bl = new BL.BLI();
        public RemoveExit()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                bl.Removeonthemovebus(Int32.Parse(textBox.Text));
                Close();
                MessageBox.Show("Line Removed From driving List");
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }
    }
}
