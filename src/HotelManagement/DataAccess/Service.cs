using System;
using System.Data;

namespace HotelManagement.DataAccess
{
    public static class Service
    {
        public static DataTable GetServicesInfo(ServiceType type)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetServiceInfo @SeviceType", new object[] { type });
        }
        public static int PayForServicesOnly()
        {
            string Query = "Eco_Hotel_PayForServices";
            return ExecuteQuery.ExecuteNoneQuery(Query);
        }

        public static int SetServiceInfo(int id, string name, int price)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_SetServiceInfo @ID , @Name , @Price",
                new object[] { id, name, price });
        }
        public static int AddNewService(ServiceType serviceTypeID, string name, int price)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_AddNewService @ServiceTypeID , @Name , @Price",
                new object[] { serviceTypeID, name, price });
        }
        public static DataTable GetServiceIdOfNewService()
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetServiceIdOfNewService");
        }
        public static int RemoveService(int id)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_RemoveService @ID",
                new object[] { id });
        }
        public static DataTable GetEatServiceRevenue(int RevenueType, DateTime FromDate, DateTime ToDate)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetEatServiceRevenue @RevenueType , @FromDate , @ToDate",
                new object[] { RevenueType, FromDate, ToDate });
        }
        public static DataTable GetLaudryServiceRevenue(int RevenueType, DateTime FromDate, DateTime ToDate)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetLaudryServiceRevenue @RevenueType , @FromDate , @ToDate",
                new object[] { RevenueType, FromDate, ToDate });
        }

    }
}
