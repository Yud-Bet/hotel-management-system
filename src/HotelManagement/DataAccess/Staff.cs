using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace HotelManagement.DataAccess
{
    public static class Staff
    {
        public static string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
        public static bool Login(string Username, string Password)
        {
            string EncryptedPass = Encrypt(Password);
            DataTable data = ExecuteQuery.ExecuteReader("Eco_Hotel_SearchAccount @Username , @Password", new object[] { Username, EncryptedPass });
            return data.Rows.Count == 1;
        }
        public static int ChangePassword(string Username, string oldPass, string newPass)
        {
            string EncryptedOldPass = Encrypt(oldPass);
            string EncryptedNewPass = Encrypt(newPass);
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_ChangePassword @Username , @OldPassword , @NewPassword",
                new object[] { Username, EncryptedOldPass, EncryptedNewPass });
        }
        public static DataTable GetStaffInfor(string Username)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetStaffInfo @Username", new object[] { Username });
        }
        public static DataTable GetStaffIdOfNewStaff()
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetStaffIdOfNewStaff");
        }
        public static int AddNewStaff(string name, string user, string pass, DateTime birthday, bool sex, string addr, string phone, string idNo, bool position, DateTime startDate, int salary, string note)
        {
            string EncryptPass = Staff.Encrypt(pass);
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_AddNewStaff @Name , @Username , @Password , @Birthday , @Sex , @Addr , @PhoneNumber , @IdentityNumber , @Position , @StartingDate , @Salary , @Note",
                new object[] { name, user, EncryptPass, birthday, sex, addr, phone, idNo, position, startDate, salary, note });
        }
        public static int SetStaffInfo(int ID, string name, DateTime birthday, bool sex, string addr, string phone, string idNo, bool position, DateTime startDate, int salary, string note)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_SetStaffInfo @ID , @Password , @Birthday , @Sex , @Addr , @PhoneNumber , @IdentityNumber , @Position , @StartingDate , @Salary , @Note",
                new object[] { ID, name, birthday, sex, addr, phone, idNo, position, startDate, salary, note });
        }
        public static int RemoveStaff(int ID)
        {
            return ExecuteQuery.ExecuteNoneQuery("Eco_Hotel_RemoveStaff @StaffID",
                new object[] { ID });
        }
        public static DataTable GetAllStaffInfo(int sortIndex)
        {
            return ExecuteQuery.ExecuteReader("Eco_Hotel_GetAllStaffInfo @Sort", new object[] { sortIndex });
        }

    }
}
