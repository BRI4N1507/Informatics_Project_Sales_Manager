using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    class QuanLySP
    {
        List<Sanpham> arrList = new List<Sanpham>();
        public List<Sanpham> SearchProduct(string s)
        {
            List<Sanpham> result = new List<Sanpham>();
            while (result.Count == 0)
            {
                if (result.Count == 0)
                {
                    result = SearchName(s);
                }
                if (s.Length <= 1)
                {
                    break;
                }
                s = s.Substring(0, s.Length - 1);
            }
            return result;
        }
        public List<Sanpham> SearchName(string s)
        {
            List<Sanpham> result = new List<Sanpham>();
            foreach (Sanpham value in arrList)
            {
                if (value.NAME.Length >= s.Length)
                {
                    string temp = value.NAME;
                    temp = temp.Substring(0, s.Length);
                    if (s.ToLower().Contains(temp.ToLower()))
                    {
                        result.Add(value);
                    }
                }
            }
            return result;
        }


        public void CreateListSP()
        {
            string[] lines = File.ReadAllLines("data.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');

                values[3] = Convert.ToDateTime(values[3]).ToShortDateString();
                Sanpham p = new Sanpham(values[0], values[1], int.Parse(values[2]), 
                    Convert.ToDateTime(values[3]).ToShortDateString(),
                    double.Parse(values[4]),
                    double.Parse(values[5]));
                arrList.Add(p);
            }
        }
    }
}
