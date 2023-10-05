using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    class KhachHang
    {
        private string f_tenkh, f_makh,f_sdt,f_diachi,_gt;
       

        public string HOTEN
        {
            get { return f_tenkh; }
            set { f_tenkh = value; }
        }

        public string MaKH
        {
            get { return f_makh; }
            set { f_makh = value; }
        }

        public string SDT
        {
            get { return f_sdt; }
            set { f_sdt = value; }
        }

        public string DiaChi
        {
            get { return f_diachi; }
            set { f_diachi = value; }
        }

        public string gioiTinh
        {
            get { return _gt; }
            set { _gt = value; }
        }

        public KhachHang()
        {
            f_makh = "";
            f_tenkh = "";
            f_diachi = "";
            f_sdt = "";
            _gt = "Nam";
        }
        public KhachHang(string ma , string hoten , string gt , string sdt, string diachi)
        {
            f_makh = ma;
            f_tenkh = hoten;
            f_diachi = diachi;
            f_sdt = sdt;
            _gt = gt;
        }
    }
}
