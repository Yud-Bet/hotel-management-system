using System;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.DTO
{
    class RoomServices
    {
        public List<ServiceProperties> items;
        public RoomServices(int BillID = 0, int ReservationID = 0, int RoomID = 0)
        {
            items = new List<ServiceProperties>();
            //DataTable roomTB = DataAccess.CustomerDA.GetRoomReservationDetailInfo(0, 0, RoomID);
            //DataTable serviceTB = DataAccess.CustomerDA.GetBillDetailInfo(0, 0, RoomID);
            DataTable roomTB = DataAccess.Room.GetRoomReservationDetailInfo(BillID, ReservationID, RoomID);
            DataTable serviceTB = DataAccess.Bill.GetBillDetailInfo(BillID, ReservationID, RoomID);

            for (int i = 0; i < roomTB.Rows.Count; i++)
            {
                ServiceProperties item = new ServiceProperties();
                item.Name = "Phòng " + Convert.ToString(roomTB.Rows[i].ItemArray[0]);
                item.Count = Convert.ToInt32(roomTB.Rows[i].ItemArray[1]);
                item.Price = Convert.ToInt32(roomTB.Rows[i].ItemArray[2]);
                item.IntoMoney = Convert.ToInt32(roomTB.Rows[i].ItemArray[3]);
                items.Add(item);
            }
            for (int i = 0; i < serviceTB.Rows.Count; i++)
            {
                ServiceProperties item = new ServiceProperties();
                item.Name = Convert.ToString(serviceTB.Rows[i].ItemArray[0]);
                item.Count = Convert.ToInt32(serviceTB.Rows[i].ItemArray[1]);
                item.Price = Convert.ToInt32(serviceTB.Rows[i].ItemArray[2]);
                item.IntoMoney = Convert.ToInt32(serviceTB.Rows[i].ItemArray[3]);
                items.Add(item);
            }
        }
        public RoomServices()
        {
            items = new List<ServiceProperties>();
            DataTable servicesDB = DataAccess.ExecuteQuery.ExecuteReader(
                "Eco_Hotel_PayForServices");
            for (int i = 0; i < servicesDB.Rows.Count; i++)
            {
                ServiceProperties item = new ServiceProperties();
                item.Name = Convert.ToString(servicesDB.Rows[i].ItemArray[0]);
                item.Count = Convert.ToInt32(servicesDB.Rows[i].ItemArray[1]);
                item.Price = Convert.ToInt32(servicesDB.Rows[i].ItemArray[2]);
                item.IntoMoney = Convert.ToInt32(servicesDB.Rows[i].ItemArray[3]);
                items.Add(item);
            }
        }
        public class ServiceProperties
        {
            public string Name;
            public int Count;
            public int Price;
            public int IntoMoney;
        }
    }
}
