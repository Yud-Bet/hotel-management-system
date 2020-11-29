using System.Data;
using System;

namespace HotelManagement.DTO
{
    class RoomOverview
    {
        public int[] RoomCount;
        public RoomInfo[] Items;
        public RoomOverview()
        {
            RoomCount = new int[5];
            DataTable data = DataAccess.RoomDA.GetAllRoom();
            RoomCount[0] = data.Rows.Count;
            Items = new RoomInfo[RoomCount[0]];

            for (int i = 0; i < RoomCount[0]; i++)
            {
                var ID = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                var Status = (RoomStatus)Convert.ToInt32(data.Rows[i].ItemArray[1]);
                var Type = (RoomType)Convert.ToInt32(data.Rows[i].ItemArray[2]);
                Items[i] = new RoomInfo(ID, Status, Type);
                RoomCount[(int)Items[i].Status]++;
            }
        }

        public class RoomInfo
        {
            public int ID;
            public RoomStatus Status;
            public RoomType Type;
            public RoomInfo(int ID, RoomStatus Status, RoomType Type)
            {
                this.ID = ID;
                this.Status = Status;
                this.Type = Type;
            }
        }
    }
}
