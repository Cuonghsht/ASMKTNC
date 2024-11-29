using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public SinhVien _sv;
        public SinhVienPoly _poly;
        [SetUp]
        public void SetUp()
        {
            _poly = new SinhVienPoly();
        }
        [Test]
        [TestCase("11", "SV011", "Trần Mạnh Cường ", "L11", "Ky thuat phan mem")]  
        [TestCase("12", "SV012", "Trần Mạnh Cường", "L12", "pp")]     
        [TestCase("13", "SV013", "Trần Mạnh Cường", "L13", "aa")]      
        [TestCase("14", "SV014", "Trần Mạnh Cường", "L14", "bb")]      
        [TestCase("15", "SV015", "Trần Mạnh Cường", "L15", "cc")]        
        [TestCase("", "SV016", "Trần Mạnh Cường", "L16", "dd")]              
        [TestCase("17", "", "Trần Mạnh Cường", "L17", "Blockchain")]              
        [TestCase("18", "SV018", "", "L18", "iii")]           
        [TestCase("19", "SV019", "Trần Mạnh Cường", "L19", "")]                   
        [TestCase("20", "SV020", "Trần Mạnh Cường", "L20", null)]
        public void ThemSinhVien(string id, string masv, string hoten, string malop, string tenlop)
        {
            _sv = new SinhVien(id, masv, hoten, malop, tenlop);
            _poly.Them(_sv);
            Assert.That(_poly.DsSinhVien().Contains(_sv), Is.True);
        }
        [Test]
        [TestCase("SV011", true)]
        [TestCase("SV012", false)]
        [TestCase("11", false)]
        [TestCase("", false)]
        [TestCase(null, false)]
        public void TimKiem_MaSV(string masv, bool b)
        {
            _sv = new SinhVien("11", "SV011", "Trần Mạnh Cường", "L11", "Ky thuat phan men");
            _poly.Them(_sv);
            var kq = _poly.TimKiem(masv) != null;
            Assert.That(kq, Is.EqualTo(b));
        }
    }
}
