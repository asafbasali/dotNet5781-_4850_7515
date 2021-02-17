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
using BL;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL.BLObject bl = new BL.BLI();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (bl.checkifuserexist(this.emailbox.Text))
            {
                string pass = bl.GetUserPass(this.emailbox.Text);
                MessageBox.Show(pass);
                if (this.passbox.Password == pass)
                {
                    login win = new login();
                    win.Show();
                }
                else
                {
                    MessageBox.Show("Name or Password are Incorrect");
                }
            }
            else
            {
                MessageBox.Show("Name or Password are Incorrect");
            }
        }
        private void click_delete(object sender, MouseEventArgs e)
        {
            this.emailbox.Text = "";
        }
        private void click_delete_pass(object sender, MouseEventArgs e)
        {
            this.passbox.Password = "";
        }
        private void emailbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void opennewwindow(object sender, MouseEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }
        private void opennewwindow(object sender, RoutedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }
        private void click_add(object sender, MouseEventArgs e)
        {
            if (this.emailbox.Text == "")
            {
                this.emailbox.Text = "Email";
            }
        }
        private void click_add_pass(object sender, MouseEventArgs e)
        {
            if (this.passbox.Password == "")
            {
                this.passbox.Password = "Password";
            }
        }
    }
}
