using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52005810
{
    class QuanLyHoaDon
    {
          
        List<HoaDon> arrList = new List<HoaDon>();
        public List<HoaDon> SearchProduct(string s)
        {
            List<HoaDon> result = new List<HoaDon>();
            while (result.Count == 0)
            {
                if (result.Count == 0)
                {
                    result = SearchWithNumberHD(s);
                }

                if (s.Length <= 1)
                {
                    break;
                }
                s = s.Substring(0, s.Length - 1);
            }
            return result;
        }
        public List<HoaDon> SearchWithNumberHD(string s)
        {
            List<HoaDon> result = new List<HoaDon>();
            foreach (HoaDon value in arrList)
            {
                if (value.SoDT.Length >= s.Length)
                {
                    string temp = value.SoDT;
                    temp = temp.Substring(0, s.Length);
                    if (s.ToLower().Contains(temp.ToLower()))
                    {
                        result.Add(value);
                    }
                }
            }
            return result;
        }
        public void createListHD()
        {
            string[] lines = File.ReadAllLines("hoadon.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');


                HoaDon p = new HoaDon(values[0], values[1],values[2], Convert.ToDouble(values[3]), Convert.ToDateTime(values[4]).ToShortDateString());
                arrList.Add(p);
            }
        }
    }

    
}
