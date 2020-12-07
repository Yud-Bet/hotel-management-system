using System;
using System.Data;

namespace HotelManagement.DataAccess
{
    public static class CustomerDA
    {
        public static DataTable GetCustomerInfo(int RoomID)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return ExecuteQuery.ExecuteReader("QLKS_GetCustomerInfo @ID", new object[] { RoomID });
        }
        public static int InsertNewClient(string Name, DateTime Birthday, string IdeNum, string Passport, string Addr, string Phone,
            Sex sex, string Note = null)
        {
            string query = "QLKS_InsertNewClient @Name , @Birthday , @IdentityNumber , @Passport , @Addr , @PhoneNumber , @Sex";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] {Name, Birthday, IdeNum, Passport, Addr, Phone, sex});
        }
        public static int InsertNewRoomReservation(DateTime ArrivalDate, int ClientID, string Username, int DownPayment = 0, string Note = null)
        {
            string query = "QLKS_InsertNewRoomReservation @ArrivalDate , @ClientID , @Username , @DownPayment , @Note";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] {ArrivalDate, ClientID, Username, DownPayment, Note });
        }
        public static int InsertRoomReservationDetail(int RoomReservationID, int RoomID)
        {
            string query = "QLKS_InsertRoomReservationDetail @RoomReservationID , @RoomID";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] {RoomReservationID, RoomID});

        }
        public static int AddReservation(int RoomID, string Name, DateTime Birthday, string Phone,
            Sex sex, string IdeNum, string Passport, string Addr, DateTime ArrivalDate, string Note = null)
        {
            string query = "QLKS_AddReservation @RoomID , @Name , @Birthday , @Phone , @Sex , @IdeNum , @Passport , @Addr , @Note , @ArrivalDate";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { RoomID, Name, Birthday, Phone, sex, IdeNum, Passport, Addr, Note, ArrivalDate });
        }
        public static int ChangeReservationInfo(int RoomID, string Name, DateTime Birthday, string Phone,
            Sex sex, string IdeNum, string Passport, string Addr, DateTime ArrivalDate, string Note = null)
        {
            string query = "QLKS_ChangeReservationInfo @RoomID , @Name , @Birthday , @Phone , @Sex , @IdeNum , @Passport , @Addr , @Note , @ArrivalDate";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { RoomID, Name, Birthday, Phone, sex, IdeNum, Passport, Addr, Note, ArrivalDate });
        }
        public static int InsertNewBill(int RoomReservationID, string Username)
        {
            string Query = "QLKS_InsertNewBill @RoomReservationID , @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomReservationID, Username });
        }
        public static int Payment(int BillID, int RoomReservation, int RoomID, string Username)
        {
            string Query = "QLKS_Payment @BillID , @RoomeReservationID , @RoomID , @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] {BillID, RoomReservation, RoomID, Username });
        }
        public static int SetRoomReservationStatus(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "QLKS_SetRoomReservationStatus @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { BillID, RoomReservation, RoomID });
        }
        public static DataTable GetRoomReservationDetailInfo(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "QLKS_GetRoomReservationDetailInfo @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteReader(Query, new object[] { BillID, RoomReservation, RoomID });
        }
        public static DataTable GetBillDetailInfo(int BillID, int RoomReservation, int RoomID)
        {
            string Query = "QLKS_GetBillDetailInfo @BillID , @RoomeReservationID , @RoomID";
            return ExecuteQuery.ExecuteReader(Query, new object[] { BillID, RoomReservation, RoomID });
        }
    }
}
