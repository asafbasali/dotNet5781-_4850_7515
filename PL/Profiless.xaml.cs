using System.Windows.Controls;


namespace PL
{
    /// <summary>
    /// Interaction logic for Profiless.xaml
    /// </summary>
    public partial class Profiless : Page
    {
        BL.IBL bl = new BL.BL();
        public Profiless()
        {
            InitializeComponent();
            profiles.ItemsSource = bl.GetAllUsers();
        }
    }
}
