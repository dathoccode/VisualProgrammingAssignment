using CoffeeHouseABC.Models;

namespace CoffeeHouseABC.Utils
{
    public static class SessionManager
    {
        public static KhachHang? CurrentUser { get; set; }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}