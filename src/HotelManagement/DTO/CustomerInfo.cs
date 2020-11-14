using System;
using System.Data;

namespace HotelManagement.DTO
{
    class CustomerInfo
    {
        public string Name;
        public DateTime Birthday;
        public string PhoneNumber;
        public Sex sex;
        public string IDNumber;
        public string Passport;
        public string Addr;
        public string Note;
        public DateTime CheckInDate;
        public CustomerInfo(int RoomID)
        {
            DataTable data = DataAccess.CustomerDA.GetCustomerInfo(RoomID);
            Name = data.Rows[0].ItemArray[0].ToString();
            Birthday = Convert.ToDateTime(data.Rows[0].ItemArray[1]);
            PhoneNumber = data.Rows[0].ItemArray[2].ToString();
            sex = (Sex)Convert.ToInt32(data.Rows[0].ItemArray[3]);
            IDNumber = data.Rows[0].ItemArray[4].ToString();
            Passport = data.Rows[0].ItemArray[5].ToString();
            Addr = data.Rows[0].ItemArray[6].ToString();
            Note = data.Rows[0].ItemArray[7].ToString();
            CheckInDate = Convert.ToDateTime(data.Rows[0].ItemArray[8]);
        }
    }
}
