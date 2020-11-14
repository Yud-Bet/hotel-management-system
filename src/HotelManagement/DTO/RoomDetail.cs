using System;
using System.Data;

namespace HotelManagement.DTO
{
    class RoomDetail
    {
        public RoomType Type;
        public string Size;
        public string Price;
        public RoomDetail(int RoomID)
        {
            DataTable data = DataAccess.RoomDA.GetRoomInfo(RoomID);
            Type = (RoomType)Convert.ToInt32(data.Rows[0].ItemArray[0]);
            Size = data.Rows[0].ItemArray[1].ToString();
            Price = Convert.ToInt32(data.Rows[0].ItemArray[2]).ToString();
        }
    }
}
