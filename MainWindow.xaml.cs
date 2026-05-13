using SmartHotelManagement.Services;
using SmartHotelManagement.Views;
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

namespace SmartHotelManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new Dashboard_View();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Dashboard_View();
        }

        private void Room_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Room_View();
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Booking_View();
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Customer_View();
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Service_View();
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Setting_View();
        }
    }
}