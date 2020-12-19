﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DataAccess
{
    public static class Manager
    {
        public static DataTable GetStaffIdOfNewStaff ()
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetStaffIdOfNewStaff");
        }
        public static int AddNewStaff(string name, string user, string pass, DateTime birthday, bool sex, string addr, string phone, string idNo, bool position, DateTime startDate, int salary, string note)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_AddNewStaff @Name , @Username , @Password , @Birthday , @Sex , @Addr , @PhoneNumber , @IdentityNumber , @Position , @StartingDate , @Salary , @Note",
                new object[] { name, user, pass, birthday, sex, addr, phone, idNo, position, startDate, salary, note});
        }
        public static int SetStaffInfo(int ID, string name, DateTime birthday, bool sex, string addr, string phone, string idNo, bool position, DateTime startDate, int salary, string note)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_SetStaffInfo @ID , @Password , @Birthday , @Sex , @Addr , @PhoneNumber , @IdentityNumber , @Position , @StartingDate , @Salary , @Note",
                new object[] { ID, name, birthday, sex, addr, phone, idNo, position, startDate, salary, note });
        }
        public static int RemoveStaff(int id)
        {
            return ExecuteQuery.ExecuteNoneQuery("QLKS_RemoveStaff @StaffID",
                new object[] { id });
        }
        public static DataTable GetAllCustomerInfo(int sort)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetAllCustomer @Sort", new object[] { sort });
        }

    }
}
