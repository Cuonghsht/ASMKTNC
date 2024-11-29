using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI1
{
    internal class BAI1
    {
        static void Main(string[] args)
        {
        }
        public Class tong;
        [SetUp]
        public void Setup()
        {
            tong = new Class();
        }
        [Test]
        [TestCase(5, 6, 11)]         
        [TestCase(-5, -6, -11)]     
        [TestCase(-5, 6, 1)]     
        [TestCase(5, -6, -1)]     
        [TestCase(0, 5, 5)]          
        [TestCase(0, 0, 0)]          
        [TestCase(int.MinValue, 2, int.MinValue + 2)]  
        [TestCase(int.MaxValue, -2, int.MaxValue + -2)]
        public void TinhTong(int a, int b, int c)
        {
            var result = tong.Tong(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
       [TestCase(10.1,1,11.1)]
        [TestCase("abc",1,null)]
        public void ValidateInput(object a, object b , object c)
        {
            if (!(a is int) )
            {
                throw new InvalidOperationException($"Dữ liệu không hợp lệ: '{a}' không phải là số nguyên hợp lệ.");
            }
            if (!(b is int))
            {
                throw new InvalidOperationException($"Dữ liệu không hợp lệ: '{b}' không phải là số nguyên hợp lệ.");
            }
        }
        public class Class
        {
            public int Tong(int a, int b)
            {
                return a + b;
            }
        }
    }
}
