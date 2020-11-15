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
        public static int AddReservation(int RoomID, string Name, DateTime Birthday, string Phone,
            Sex sex, string IdeNum, string Passport, string Addr, DateTime ArrivalDate, string Note = null)
        {
            string query = "QLKS_AddReservation @RoomID , @Name , @Birthday , @Phone , @Sex , @IdeNum , @Passport , @Addr , @Note , @ArrivalDate";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { RoomID, Name, Birthday, Phone, sex, IdeNum, Passport, Addr, Note, ArrivalDate });
        }
    }
}
