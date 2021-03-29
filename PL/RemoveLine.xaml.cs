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
    /// Interaction logic for RemoveLine.xaml
    /// </summary>
    public partial class RemoveLine : Window
    {
        BL.BLObject bl = new BL.BLI();
        public RemoveLine()
        {
            InitializeComponent();
        }

        private void onclick(object sender, RoutedEventArgs e)
        {
            int b = Int32.Parse(textBox.Text);
            bl.RemoveBusLine(b);
            this.Close();
        }
    }
}
