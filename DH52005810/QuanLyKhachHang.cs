using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    class QuanLyKhachHang
    {
        List<KhachHang> arrList = new List<KhachHang>();
        public List<KhachHang> SearchProduct(string s)
        {
            List<KhachHang> result = new List<KhachHang>();
            while (result.Count == 0)
            {
                if (result.Count == 0)
                {
                    result = SearchWithNumberPhone(s);
                }

                if (s.Length <= 1)
                {
                    break;
                }
                s = s.Substring(0, s.Length - 1);
            }
            return result;
        }
        public List<KhachHang> SearchWithNumberPhone(string s)
        {
            List<KhachHang> result = new List<KhachHang>();
            foreach (KhachHang value in arrList)
            {
                if (value.SDT.Length >= s.Length)
                {
                    string temp = value.SDT;
                    temp = temp.Substring(0, s.Length);
                    if (s.ToLower().Contains(temp.ToLower()))
                    {
                        result.Add(value);
                    }
                }
            }
            return result;
        }
        public void CreateListKH()
        {
            string[] lines = File.ReadAllLines("ListKH.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                KhachHang p = new KhachHang(values[0], values[1],values[2], values[3], values[4]);
                arrList.Add(p);
            }
        }
    }

}
