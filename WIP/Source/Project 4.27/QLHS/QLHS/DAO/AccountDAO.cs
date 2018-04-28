using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { get { if (instance == null) instance = new AccountDAO(); return instance; }  set => instance = value; }
        private AccountDAO() { }

        public string GetType(string user)
        {
            string query = "SELECT Type FROM Account WHERE UserName = N'" + user + "'";
            string Type = DataProvider.Instance.ExecuteSchalar(query).ToString();
            return Type;
        }
        public bool PasswordChange(string username, string password)
        {
            string query = "EXEC dbo.DoiMatKhau @username = N'" + username + "' , @pasword = N'" + password + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }

    }
}
