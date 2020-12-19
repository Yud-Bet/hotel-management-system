using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public enum RoomType
    {
        SingleVIP = 1,
        DoubleVIP = 2,
        Single = 3,
        Double = 4
    }
    public enum RoomStatus
    {
        Empty = 1,
        Rented = 2,
        Cleaning = 3,
        Repairing = 4
    }
    public enum Sex
    {
        Male = 0,
        Female = 1
    }
    public enum StaffPosition
    {
        Manager = 0,
        Receptionist = 1
    }
    public enum LoginState
    {
        CantConnect = 0,
        Successful = 1,
        Failed =2
    }

    public enum ServiceType
    {
        Eating = 1,
        Laundry = 2
    }

    public enum RevenueType
    {
        DateRevenue = 1,
        MonthRevenue = 2,
        QuarterRevenue = 3,
        YearRevenue = 4,
    }

    public enum ServiceManagerType
    {
        AddEatService = 1,
        EditEatService = 2,
        EditWashService = 3,
        EditIronService = 4,
    }
}
