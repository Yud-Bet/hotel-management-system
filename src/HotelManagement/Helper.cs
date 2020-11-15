using System.Configuration;

namespace HotelManagement
{
    public static class Helper
    {
        public static string ConnectionStringVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
