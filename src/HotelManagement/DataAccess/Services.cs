using System.Data;

namespace HotelManagement.DataAccess
{
    public static class Services
    {
        public static DataTable GetServicesInfo(ServiceType type)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetServiceInfo @SeviceType", new object[] { type });
        }
        public static int InsertServicetoBillDetail(int RoomID, int ServiceID, int Count)
        {
            string Query = "QLKS_InsertServiceIntoBillDetail @RoomID , @ServiceID , @ServiceCount";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomID, ServiceID, Count });
        }
        public static int InsertServiceToServicesBillOnlyDetail(int ServiceID, int Count)
        {
            string Query = "QLKS_InsertServiceIntoServicesBillOnlyDetail @ServiceID , @ServiceCount";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { ServiceID, Count });
        }
        public static int InsertNewServicesBillOnly(string Username)
        {
            string Query = "QLKS_InsertNewServicesBillOnly @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { Username });
        }
        public static int PayForServicesOnly()
        {
            string Query = "QLKS_PayForServices";
            return ExecuteQuery.ExecuteNoneQuery(Query);
        }
        public static DataTable GetServiceBillOnlyDetail(int SvcBillID)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetServicesBillOnlyInfo @ServiceBillID", new object[] { SvcBillID });
        }
    }
}
