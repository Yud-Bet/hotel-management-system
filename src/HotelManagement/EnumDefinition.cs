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
}
