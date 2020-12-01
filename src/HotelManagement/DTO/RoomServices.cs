using System;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.DTO
{
    class RoomServices
    {
        public List<ServiceProperties> services;
        public RoomServices(int RoomID, string Username)
        {
            services = new List<ServiceProperties>();
            DataTable servicesDB = DataAccess.ExecuteQuery.ExecuteReader(
                "QLKS_GetInfoForBillPrinting @RoomID , @Username", new object[] { RoomID, Username});
            for (int i = 0; i < servicesDB.Rows.Count; i++)
            {
                ServiceProperties item = new ServiceProperties();
                item.Name = Convert.ToString(servicesDB.Rows[i].ItemArray[0]);
                item.Count = Convert.ToInt32(servicesDB.Rows[i].ItemArray[1]);
                item.Price = Convert.ToInt32(servicesDB.Rows[i].ItemArray[2]);
                services.Add(item);
            }
        }
        public RoomServices()
        {
            services = new List<ServiceProperties>();
            DataTable servicesDB = DataAccess.ExecuteQuery.ExecuteReader(
                "QLKS_PayForServices");
            for (int i = 0; i < servicesDB.Rows.Count; i++)
            {
                ServiceProperties item = new ServiceProperties();
                item.Name = Convert.ToString(servicesDB.Rows[i].ItemArray[0]);
                item.Count = Convert.ToInt32(servicesDB.Rows[i].ItemArray[1]);
                item.Price = Convert.ToInt32(servicesDB.Rows[i].ItemArray[2]);
                services.Add(item);
            }
        }
        public class ServiceProperties
        {
            public string Name;
            public int Count;
            public int Price;
        }
    }
}
