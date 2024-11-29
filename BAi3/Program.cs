using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public Hieu Hieuss;

        [SetUp]
        public void SetUp()
        {
            Hieuss = new Hieu();
        }

        [TestCase(-2147483648, 0, -2147483648)] 
        [TestCase(2147483647, 0, 2147483647)]   
        [TestCase(0, -2147483648, 2147483648)]  
        [TestCase(2147483647, -2147483648)]     
        [TestCase(10, 5, 5)]                    
        [TestCase(-10, -5, -5)]                 
        [TestCase(10, -5, 15)]                  
        [TestCase(-10, 5, -15)]            
         public void Hieutest( int a , int b , int c)
        {
            var Result = Hieuss.Tru(a, b);
            Assert.That(Result, Is.EqualTo(c));
        }
        [TestCase(10.5, 5)]                     
        [TestCase("abc", 5)]                    
        public void HieuInvalidTest(object a, object b)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                throw new InvalidOperationException("Du lieu dau vao khong hop le");
            });
        }

        public class Hieu
        {
            public int Tru(int a, int b)
            {
                return a - b; 
            }
        }
    }
}
