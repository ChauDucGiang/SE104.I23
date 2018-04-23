using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class CheckType
    {
        private static CheckType instance;
        public static CheckType Instance { get { if (instance == null) instance = new CheckType(); return instance; } set => instance = value; }
        private CheckType() { }

        public bool CheckIsMail(string email)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            return reg.IsMatch(email);
        }
        public bool CheckIsPhone(string phone)
        {
            if (phone.Length > 11 || phone.Length < 10)
            {
                return false;
            }
            Regex reg = new Regex("(\\+84|0)\\d{9,10}");
            return reg.IsMatch(phone);
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public bool CheckMaGV(string magv)
        {
            string match = @"^GV+[0-9]{3}";
            Regex regex = new Regex(match);
            return regex.IsMatch(magv);
        }
        public bool CheckMaNamHoc(string manamhoc)
        {
            string match = @"^NH+[0-9]{8}";
            Regex regex = new Regex(match);
            return regex.IsMatch(manamhoc);
        }
    }
}
