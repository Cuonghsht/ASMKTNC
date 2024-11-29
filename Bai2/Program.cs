using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public Caculator Tich;
        [SetUp]

        public void Setup()
        {
            Tich = new Caculator();
        }
        [Test]
        [TestCase(5, 6, 30)]
        [TestCase(-5, -6, 30)]
        [TestCase(5, -6, -30)]
        [TestCase(5, 0, 0)]
        [TestCase(0, -6, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(int.MinValue, -1, int.MinValue)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]

        public void tich(int a, int b, int c)
        {
            int Result = Tich.Nhan(a, b);
            Assert.That(Result, Is.EqualTo(c));
        }
        [TestCase(0.1,0,0)]
        [TestCase("abc" , 3 , null)]
        public void tichngoaile( object a ,object b , object c)
        {
            if(!(a is int))
            {
                throw new InvalidCastException("A không phải là int ");
            }
            if(!(b is int))
            {
                throw new InvalidCastException("B không phải là số nguyên");
            }
        }
        public class Caculator
        {
            public int Nhan(int a, int b)
            {
                return a * b;

            }
        }

    }
}


