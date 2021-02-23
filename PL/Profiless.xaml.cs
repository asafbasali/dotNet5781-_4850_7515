using System.Windows.Controls;


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
