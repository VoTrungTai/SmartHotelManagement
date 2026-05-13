using SmartHotelManagement.Services;
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

namespace SmartHotelManagement.Views
{
    /// <summary>
    /// Interaction logic for Login_Hotel.xaml
    /// </summary>
    public partial class Login_Hotel : Window
    {
        public Login_Hotel()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            AuthService auth = new AuthService();

            bool result = auth.Login(
                txtUsername.Text,
                txtPassword.Password
            );

            if (result)
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}