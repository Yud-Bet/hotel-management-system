using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DataAccess
{
    public static class Bill
    {
        public static DataTable GetData(int BillID)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetAdditionalInfoForBillViewing @BillID", new object[] { BillID });
        }
        public static int InsertNewBill(int RoomReservationID, string Username)
        {
            string Query = "Eco_Hotel_InsertNewBill @RoomReservationID , @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomReservationID, Username });
        }
        public static DataTable GetBillInfoOfCustomer(int customerID)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetBillInfoOfCustomer @CustomerID", new object[] { customerID });
        }
        public static int InsertServicetoBillDetail(int RoomID, int ServiceID, int Count)
        {
            string Query = "Eco_Hotel_InsertServiceIntoBillDetail @RoomID , @ServiceID , @ServiceCount";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomID, ServiceID, Count });
        }
        public static DataTable GetBillDetailInfo(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "Eco_Hotel_GetBillDetailInfo @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteReader(Query, new object[] { BillID, RoomReservation, RoomID });
        }
        public static int RemoveBillDetail(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "Eco_Hotel_RemoveBillDetail @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { BillID, RoomReservation, RoomID });
        }

        public static DataTable GetAllBillInfo(DateTime FromDate, DateTime ToDate, int staffID, int sort)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetAllBillInfo @FromDate , @ToDate , @StaffID , @Sort",
                new object[] { FromDate, ToDate, staffID, sort });
        }
        public static int InsertServiceToServicesBillOnlyDetail(int ServiceID, int Count)
        {
            string Query = "Eco_Hotel_InsertServiceIntoServicesBillOnlyDetail @ServiceID , @ServiceCount";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { ServiceID, Count });
        }
        public static DataTable GetServiceBillOnlyDetail(int SvcBillID)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetServicesBillOnlyDetailInfo @ServiceBillID", new object[] { SvcBillID });
        }
        public static int InsertNewServicesBillOnly(string Username)
        {
            string Query = "Eco_Hotel_InsertNewServicesBillOnly @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { Username });
        }
        public static DataTable GetAllServicesBillOnlyInfo(DateTime FromDate, DateTime ToDate, int staffID, int sort)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetAllServicesBillOnlyInfo @FromDate , @ToDate , @StaffID , @Sort",
                new object[] { FromDate, ToDate, staffID, sort });
        }

    }
}
