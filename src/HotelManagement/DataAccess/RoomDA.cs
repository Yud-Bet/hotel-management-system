using System.Data;

namespace HotelManagement.DataAccess
{
    public static class RoomDA
    {
        public static DataTable GetRoomInfo(int IDRoom)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetRoomInfo @ID", new object[] { IDRoom });
        }
        public static DataTable GetAllRoom()
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetAllRoom");
        }
        public static int EditRoomInfo(int RoomID, RoomType roomType, int Area, int Price)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_EditRoom @RoomID , @RoomTypeID , @Area , @Price",
                new object[] { RoomID, roomType, Area, Price });
        }
        public static int SetRoomStatus(int RoomID, RoomStatus status)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_SetRoomStatus @ID , @Status_", new object[] { RoomID, status });
        }
        public static int AddNewRoom(RoomType roomType, int area)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_AddNewRoom @RoomTypeID , @Area",
                new object[] { roomType, area });
        }
        public static DataTable GetRoomIdOfNewRoom()
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetRoomIdOfNewRoom");
        }
    }
}
