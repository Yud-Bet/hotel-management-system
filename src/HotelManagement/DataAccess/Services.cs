using System.Data;

namespace HotelManagement.DataAccess
{
    public static class Services
    {
        public static DataTable GetServices(ServiceType type)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetServiceInfo @SeviceType", new object[] { type });
        }
    }
}
