using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DH52005810
{
    class Dangky
    {
        public static List<string> listTaiKhoan = new List<string>();
        public string Register(string userName, string pass, string code)
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
                return "success";
        }  
    }
}
