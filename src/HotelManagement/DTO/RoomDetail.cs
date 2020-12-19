using System;
using System.Data;

namespace HotelManagement.DTO
{
    public class RoomDetail
    {
        public int ID;
        public RoomType Type;
        public int Size;
        public int Price;
        public RoomDetail(int RoomID)
        {
            DataTable data = DataAccess.RoomDA.GetRoomInfo(RoomID);
            ID = RoomID;
            Type = (RoomType)Convert.ToInt32(data.Rows[0].ItemArray[0]);
            Size = Convert.ToInt32(data.Rows[0].ItemArray[1]);
            Price = Convert.ToInt32(data.Rows[0].ItemArray[2]);
        }
    }
}
