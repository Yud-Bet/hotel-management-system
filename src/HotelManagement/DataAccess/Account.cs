﻿using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace HotelManagement.DataAccess
{
    public static class Account
    {
        private static string Encrypt(string text)
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
            DataTable data = ExecuteQuery.ExecuteReader("QLKS_SearchAccount @Username , @Password", new object[] { Username, /*EncryptedPass*/ Password });
            return data.Rows.Count == 1;
        }
        public static int ChangePassword(string Username, string oldPass, string newPass)
        {
            //string EncryptedPass = Encrypt(Password);
            return ExecuteQuery.ExecuteNoneQuery("QLKS_ChangePassword @Username , @OldPassword , @NewPassword",
                new object[] { Username, oldPass, newPass });
                //new object[] { Username, EncryptedPass }) > 0;
        }
        public static DataTable GetStaffInfor(string Username)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetStaffInfo @Username", new object[] { Username });
        }
    }
}
