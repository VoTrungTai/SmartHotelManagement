using SmartHotelManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHotelManagement.Services
{
    internal class AuthService
    {
        public bool Login(string username, string password)
        {
            using (var db = new HotelContext())
            {
                return db.Users.Any(x =>
                    x.Username == username &&
                    x.Password == password);
            }
        }

        
    }
}
