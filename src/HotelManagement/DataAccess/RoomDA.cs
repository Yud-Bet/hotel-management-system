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
    }
}
