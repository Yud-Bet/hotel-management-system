using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DataAccess
{
    public static class Report
    {
        public static DataTable GetRoomRevenue(int RevenueType, DateTime FromDate, DateTime ToDate)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetRoomRevenue @RevenueType , @FromDate , @ToDate",
                new object[] { RevenueType, FromDate, ToDate });
        }
        public static DataTable GetEatServiceRevenue (int RevenueType, DateTime FromDate, DateTime ToDate)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetEatServiceRevenue @RevenueType , @FromDate , @ToDate",
                new object[] { RevenueType, FromDate, ToDate });
        }
        public static DataTable GetLaudryServiceRevenue(int RevenueType, DateTime FromDate, DateTime ToDate)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetLaudryServiceRevenue @RevenueType , @FromDate , @ToDate",
                new object[] { RevenueType, FromDate, ToDate });
        }
    }
}
