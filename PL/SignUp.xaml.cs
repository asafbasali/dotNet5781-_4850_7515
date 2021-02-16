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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        BL.BLObject bl = new BL.BLI();
        public SignUp()
        {
            InitializeComponent();
        }
        private void AddUser(object sender, RoutedEventArgs e)
        {
            if (bl.checkifuserexist(this.emailbox1.Text))
            {
                MessageBox.Show("you already signed up \n maybe try to reset your password");
            }
            else
            {
                if (emailbox1.Text != "" && passbox2.Password == passbox3.Password)
                {
                    bl.AddUser(this.emailbox1.Text, this.passbox2.Password);
                    MessageBox.Show("you are sgined up now");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
        }
    }
}
