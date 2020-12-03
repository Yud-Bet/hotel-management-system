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
            string query = "QLKS_InsertNewClient @Name, @Birthday, @IdentityNumber, @Passport, @Addr, @PhoneNumber, @Sex";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] {Name, Birthday, IdeNum, Passport, Addr, Phone, sex});
        }
        public static int InsertNewRoomReservation(DateTime ArrivalDate, int ClientID, int DownPayment = 0, string Note = null)
        {
            string query = "QLKS_InsertNewRoomReservation @ArrivalDate, @ClientID, @DownPayment, @Note";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] {ArrivalDate, ClientID, DownPayment, Note });
        }
        //public static int InsertNewRoomReservation
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
        public static int AddBill(int RoomID, string Username)
        {
            string Query = "QLKS_InsertNewBill @RoomID , @Username";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomID, Username });
        }
        public static int Pay(int RoomID)
        {
            string Query = "QLKS_Payment @RoomID";
            return ExecuteQuery.ExecuteNoneQuery(Query, new object[] { RoomID});
        }
    }
}
