using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    public class Account
    { 
        private string taikhoan;
        private string matkhau;
   

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }

        }

        public string Matkhau
        {
            get { return matkhau;}
            set { matkhau = value; }

        }

        public Account(string taikhoan, string matkhau)
        {
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;

        }

        
    }
}

