using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    public class Sanpham
    {
        private string f_name,f_id;
        private int f_amount;
        private string f_ngaynhap;
        private double f_price, f_ban;



        public string ID
        {
            get { return f_id; }
            set {f_id = value; }

        }

        public string NAME
        {
            get { return f_name; }
            set { f_name = value; }

        }

        public int AMOUNT 
        {
            get { return f_amount; }
            set { f_amount = value; }

        }

        public double GIANHAP
        {
            get { return f_price; }
            set { f_price = value; }

        }


        public double GIABAN
        {
            get { return f_ban; }
            set { f_ban = value; }

        }


        public string NGAYNHAP
        {
            get { return f_ngaynhap; }
            set { f_ngaynhap = value; }
        }


       public Sanpham()
        {
            f_id = "";
            f_name = "";
            f_amount = 0;
            f_ngaynhap ="";
            f_price = 0;
            f_ban = 0;
           
        }
        public Sanpham(string ma, string ten,  int soluong, string ngaynhap, double gia, double giaban)
        {
           f_id = ma;
            f_name = ten;
            f_price = gia;
            f_ngaynhap = ngaynhap;
            f_amount = soluong;
            f_ban = giaban;
        }
    }
}
