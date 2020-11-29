using System.Data;

namespace HotelManagement.DataAccess
{
    public static class Services
    {
        public static DataTable GetServices(ServiceType type)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetServiceInfo @SeviceType", new object[] { type });
        }
        public static int InsertServicetoBillDetail(int RoomID, int ServiceID, int Count)
        {
            string Query = "QLKS_InsertServiceIntoBillDetail @RoomID , @ServiceID , @ServiceCount";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomID, ServiceID, Count });
        }
    }
}
