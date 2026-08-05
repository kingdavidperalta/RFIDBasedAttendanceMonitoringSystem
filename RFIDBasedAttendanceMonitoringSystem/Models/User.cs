using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }

    public static class CurrentSession
    {
        public static User User { get; private set; }

        public static void SignIn(User user)
        {
            User = user;
        }

        public static void SignOut()
        {
            User = null;
        }

        public static bool IsSignedIn
        {
            get
            {
                return User != null;
            }
        }
    }
}
