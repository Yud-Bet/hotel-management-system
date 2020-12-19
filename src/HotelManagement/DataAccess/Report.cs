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
        public static DataTable GetAllBillInfo(DateTime FromDate, DateTime ToDate, int staffID, int sort)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetAllBillInfo @FromDate , @ToDate , @StaffID , @Sort",
                new object[] { FromDate, ToDate, staffID, sort });
        }
        public static DataTable GetAllStaffInfo(int sortIndex)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetAllStaffInfo @Sort", new object[] { sortIndex });
        }
    }
}
