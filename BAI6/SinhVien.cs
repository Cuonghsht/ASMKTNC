using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI6
{
    public class SinhVien
    {
        public string ID { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public SinhVien(string id, string masv, string hoten, string malop, string tenlop)
        {
            ID = id;
            MaSV = masv;
            HoTen = hoten;
            MaLop = malop;
            TenLop = tenlop;
        }
    }
}
