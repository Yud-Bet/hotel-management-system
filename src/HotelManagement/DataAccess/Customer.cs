using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DataAccess
{
    public static class Customer
    {
        public static DataTable GetAllCustomer(int sort)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetAllCustomer @Sort", new object[] { sort });
        }
        public static DataTable GetCustomerInfo(int RoomID)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetCustomerInfo @ID", new object[] { RoomID });
        }
        public static int InsertNewCustomer(string Name, DateTime Birthday, string IdeNum, string Passport, string Addr, string Phone,
            Sex sex)
        {
            string query = "Eco_Hotel_InsertNewCustomer @Name , @Birthday , @IdentityNumber , @Passport , @Addr , @PhoneNumber , @Sex";
            return ExecuteQuery.ExecuteNoneQuery(query,
                new object[] { Name, Birthday, IdeNum, Passport, Addr, Phone, sex });
        }
        public static DataTable GetAllCustomerInfo()
        {
            return DataAccess.ExecuteQuery.ExecuteReader("Eco_Hotel_GetAllCustomerInfo");
        }
    }
}
