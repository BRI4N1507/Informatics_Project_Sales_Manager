using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DH52005810
{
    public class ChucNangLogin
    {
        // khởi tạo danh sách


        public static List<Account> listUser = new List<Account>();     
        public void ReadFileUser()
        {         
            string[] lines = File.ReadAllLines(@"account.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                string[] sUser = lines[i].Split('|');
                string userName = sUser[0];
                string pass = sUser[1];
                Account tk = new Account(userName, pass);
                listUser.Add(tk);
            }
        }

        public bool CheckDuplicateUser(string userName, string pass)
        {
            foreach (Account value in listUser)
            {
                if (value.Taikhoan == userName && value.Matkhau == pass)
                {          
                    return true;
                }
            }
            return false;
        }
        public string Login(string userName, string pass)
        {
            for (int i = 0; i < userName.Length; i++)
            {
                string str1;
                str1 = userName.Substring(i, 1);
                if (str1 == " ")
                    return "error_whiteSpace";
            }
            for (int j = 0; j < pass.Length; j++)
            {
                string str2;
                str2 = pass.Substring(j, 1);
                if (str2 == " ")
                    return "error_whiteSpace";
            }

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(userName))
            {
                return "error_SpecialChar";
            }

            if (userName == "" || pass == "")
            {
                return "error_empty";
            }
            bool result2 = CheckDuplicateUser(userName, pass);
            if (result2)
                return "success";
            return "error_fail";         
        }

       


    }
}
