using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    class HoaDon
    {
        private string h_tenkh, h_madh, h_sdt;
        private double h_tien;
        private string h_ngaymua;

        public string TenHD
        {
            get { return h_tenkh; }
            set { h_tenkh = value; }
        }
        public string MaDH
        {
            get { return h_madh; }
            set { h_madh = value; }
        }
        public string SoDT
        {
            get { return h_sdt; }
            set { h_sdt = value; }
        }
        public double TongTien
        {
            get { return h_tien; }
            set { h_tien = value; }
        }

        public string NgayMua
        {
            get { return h_ngaymua; }
            set { h_ngaymua = value; }
        }

        public HoaDon()
        {
            h_madh = "";
            h_tenkh = "";
            h_sdt = "";
            h_tien = 0;
            
        }
        public HoaDon(string ma, string ten , string sdt , double tien, string ngay)
        {
            h_madh = ma;
            h_tenkh = ten;
            h_sdt = sdt;
            h_tien = tien;
            h_ngaymua = ngay;
        }
    }
}
