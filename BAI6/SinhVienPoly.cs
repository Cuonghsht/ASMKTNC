using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI6
{
    public class SinhVienPoly
    {

        public List<SinhVien> DsSinhVien()
        {
            return sinhViens;
        }

        List<SinhVien> sinhViens = new List<SinhVien>();
        public void Them(SinhVien sv)
        {
            if (!Regex.IsMatch(sv.TenLop, @"^[a-zA-Z0-9\s]+$"))
            {
                throw new Exception("TenLop không được chứa ký tự đặc biệt.");
            }
            sinhViens.Add(sv);
        }
        public SinhVien TimKiem(string masv)
        {
            var svcantim = sinhViens.FirstOrDefault(x => x.MaSV == masv);
            if (svcantim != null)
            {
                return svcantim;
            }
            else
            {
                throw new NullReferenceException("Không tìm thấy sinh viên");
            }
        }
    }
}
