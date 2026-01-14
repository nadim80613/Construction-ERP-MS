using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_ERP__Management_System
{
    public static class Session
    {
        public static int UserID { get; set; }
        public static int CompanyID { get; set; }
        public static string UserName { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }

        public static bool IsAdmin()
        {

            if (Role == null)
            {
                return false;
            }

            return Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);


        }

        public static bool IsSuperAdmin()
        {
            if (Email != null && Email.Equals("admin@system.com", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (CompanyID == 1)
            {
                return true;
            }

            return false;


        }
    }
}
