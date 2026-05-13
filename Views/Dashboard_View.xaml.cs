using SmartHotelManagement.Data;
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
    /// Interaction logic for Dashboard_View.xaml
    /// </summary>
    public partial class Dashboard_View : UserControl
    {
         private HotelContext db = new HotelContext();

        public Dashboard_View()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Tổng số phòng
            int totalRooms = db.Rooms.Count();

            // Phòng trống
            int availableRooms =
                db.Rooms.Count(x => x.Status == "Available");

            // Tổng doanh thu
            decimal revenue = 0;

            if (db.Bookings.Any())
            {
                revenue =
                    db.Bookings.Sum(x => x.TotalPrice);
            }

            // Hiển thị dữ liệu
            txtTotalRooms.Text =
                totalRooms.ToString();

            txtAvailableRooms.Text =
                availableRooms.ToString();

            txtRevenue.Text =
                revenue.ToString("N0") + " VNĐ";

            // Load bảng phòng
            dgRooms.ItemsSource =
                db.Rooms.ToList();
        }
    }
}