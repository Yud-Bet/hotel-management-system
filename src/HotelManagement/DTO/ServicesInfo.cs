using System.Data;
using System.Collections.Generic;
using System;

namespace HotelManagement.DTO
{
    class ServicesInfo
    {
        public List<ServiceProperties> Items;
        public ServicesInfo(ServiceType type)
        {
            DataTable data = DataAccess.Services.GetServices(type);
            Items = new List<ServiceProperties>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ServiceProperties item = new ServiceProperties();
                item.ServiceID = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                item.Name = Convert.ToString(data.Rows[i].ItemArray[2]);
                item.Price = Convert.ToInt32(data.Rows[i].ItemArray[4]);
                Items.Add(item);
            }
            
        }
        public class ServiceProperties
        {
            public int ServiceID;
            public string Name;
            public int Price;
        }
    }
}
