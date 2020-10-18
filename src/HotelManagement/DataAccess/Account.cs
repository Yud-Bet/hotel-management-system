using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

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
    }
}
