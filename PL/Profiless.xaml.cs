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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for Profiless.xaml
    /// </summary>
    public partial class Profiless : Page
    {
        BL.BLObject bl = new BL.BLI();
        public Profiless()
        {
            InitializeComponent();
            profiles.ItemsSource = bl.GetAllUsers();
        }
    }
}
