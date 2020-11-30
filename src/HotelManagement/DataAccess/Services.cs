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
        public static int InsertServiceIntoBillServiceOnlyDetail(int ServiceID, int Count)
        {
            string Query = "QLKS_InsertServiceIntoBillServiceOnlyDetail @ServiceID , @ServiceCount";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { ServiceID, Count });
        }
        public static int InsertNewBillServiceOnly(string Username)
        {
            string Query = "QLKS_InsertNewBillServiceOnly @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { Username });
        }
        public static int PaymentBillServiceOnly()
        {
            string Query = "QLKS_PaymentBillServiceOnly";
            return ExecuteQuery.ExecuteNoneQuery(Query);
        }
    }
}
