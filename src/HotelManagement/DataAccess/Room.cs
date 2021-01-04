using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DataAccess
{
    public static class Room
    {
        public static DataTable GetRoomInfo(int IDRoom)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetRoomInfo @ID", new object[] { IDRoom });
        }
        public static DataTable GetAllRoom()
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetAllRoom");
        }
        public static int EditRoomInfo(int RoomID, RoomType roomType, int Area, int Price)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_EditRoom @RoomID , @RoomTypeID , @Area , @Price",
                new object[] { RoomID, roomType, Area, Price });
        }
        public static int SetRoomStatus(int RoomID, RoomStatus status)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_SetRoomStatus @ID , @Status_", new object[] { RoomID, status });
        }
        public static int AddNewRoom(RoomType roomType, int area)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_AddNewRoom @RoomTypeID , @Area",
                new object[] { roomType, area });
        }
        public static DataTable GetRoomIdOfNewRoom()
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetRoomIdOfNewRoom");
        }
        public static int InsertNewRoomReservation(DateTime ArrivalDate, int CustomerID, string Username, int DownPayment = 0, string Note = null)
        {
            string query = "Eco_Hotel_InsertNewRoomReservation @ArrivalDate , @CustomerID , @Username , @DownPayment , @Note";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { ArrivalDate, CustomerID, Username, DownPayment, Note });
        }
        public static int InsertRoomReservationDetail(int RoomReservationID, int RoomID)
        {
            string query = "Eco_Hotel_InsertRoomReservationDetail @RoomReservationID , @RoomID";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { RoomReservationID, RoomID });

        }
        public static int AddReservation(int RoomID, string Name, DateTime Birthday, string Phone,
            Sex sex, string IdeNum, string Passport, string Addr, DateTime ArrivalDate, string Note = null)
        {
            string query = "Eco_Hotel_AddReservation @RoomID , @Name , @Birthday , @Phone , @Sex , @IdeNum , @Passport , @Addr , @Note , @ArrivalDate";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { RoomID, Name, Birthday, Phone, sex, IdeNum, Passport, Addr, Note, ArrivalDate });
        }
        public static int ChangeReservationInfo(int RoomID, string Name, DateTime Birthday, string Phone,
            Sex sex, string IdeNum, string Passport, string Addr, DateTime ArrivalDate, string Note = null)
        {
            string query = "Eco_Hotel_ChangeReservationInfo @RoomID , @Name , @Birthday , @Phone , @Sex , @IdeNum , @Passport , @Addr , @Note , @ArrivalDate";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { RoomID, Name, Birthday, Phone, sex, IdeNum, Passport, Addr, Note, ArrivalDate });
        }
        public static int SetRoomReservationStatus(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "Eco_Hotel_SetRoomReservationStatus @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { BillID, RoomReservation, RoomID });
        }
        public static DataTable GetRoomReservationDetailInfo(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "Eco_Hotel_GetRoomReservationDetailInfo @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteReader(Query, new object[] { BillID, RoomReservation, RoomID });
        }
        public static int Payment(int BillID, int RoomReservation, int RoomID, string Username)
        {
            string Query = "Eco_Hotel_Payment @BillID , @RoomeReservationID , @RoomID , @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { BillID, RoomReservation, RoomID, Username });
        }
        public static DataTable GetRoomRevenue(int RevenueType, DateTime FromDate, DateTime ToDate)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetRoomRevenue @RevenueType , @FromDate , @ToDate",
                new object[] { RevenueType, FromDate, ToDate });
        }
        public static DataTable GetRoomReservationInfo(int ReservationID, int RoomID)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetRoomReservationInfo @RoomReservationID , @RoomID",
                new object[] { ReservationID, RoomID });
        }
    }
}
