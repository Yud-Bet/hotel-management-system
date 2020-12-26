using System;
using System.Data;

namespace HotelManagement.DTO
{
    class StaffOverview
    {
        public string Name;
        public string Position;
        public string IDNo;
        public StaffOverview(string Username)
        {
            DataTable data = DataAccess.Account.GetStaffInfor(Username);
            if (data.Rows.Count == 0)
            {
                throw new NullReferenceException("Load data failed!");
            }
            Name = data.Rows[0].ItemArray[1].ToString();
            Position = ((StaffPosition)Convert.ToInt32(data.Rows[0].ItemArray[2]) == StaffPosition.Manager) ?
                "Quản lý" : "Nhân viên";
            IDNo = data.Rows[0].ItemArray[4].ToString();
        }
    }
}
