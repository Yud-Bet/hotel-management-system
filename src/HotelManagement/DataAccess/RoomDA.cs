using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DataAccess
{
    public static class RoomDA
    {
        public static DataTable GetRoomInfo(int IDRoom)
        {
            return DataAccess.ExecuteQuery.ExecuteReader("QLKS_GetRoomInfo @ID", new object[] { IDRoom });
        }
        public static DataTable GetAllRoom()
        {
            return DataAccess.ExecuteQuery.ExecuteReader("QLKS_GetAllRoom");
        }
        public static int EditRoomInfo(int RoomID, RoomType roomType, int Area, int Price)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_EditRoom @ID , @Type , @Area , @Price",
                new object[] { RoomID, roomType, Area, Price });
        }
    }
}
