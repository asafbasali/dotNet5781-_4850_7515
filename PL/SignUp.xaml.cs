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

        private void email_add_1(object sender, MouseEventArgs e)
        {
            if (this.emailbox1.Text == "Email")
            {
                this.emailbox1.Text = "";
            }
           
        }
        private void passbox(object sender, MouseEventArgs e)
        {
            if (this.passbox2.Password == "Password")
            {
                this.passbox2.Password = "";
            }
        }
        private void Passbox3(object sender, MouseEventArgs e)
        {
            if (this.passbox3.Password == "Password")
            {
                this.passbox3.Password = "";
            }
        }

        private void emailbox_del_1(object sender, MouseEventArgs e)
        {
            if (this.emailbox1.Text == "")
            {
                this.emailbox1.Text = "Email";
            }
        }
        private void passbox_dsl_2(object sender, MouseEventArgs e)
        {
            if (this.passbox2.Password == "")
            {
                this.passbox2.Password = "Password";
            }
        }
        private void passbox3_del(object sender, MouseEventArgs e)
        {
            if (this.passbox3.Password == "")
            {
                this.passbox3.Password = "Password";
            }
        }
    }
}
