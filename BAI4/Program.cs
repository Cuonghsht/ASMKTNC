using System;
using System.Linq;
using NUnit.Framework;

namespace Bai3
{
    public class MathOperations
    {
        static void Main(string[] args)
        {
        }

        public double TinhTrungBinh(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Danh sách không được rỗng hoặc null");
            }
            return numbers.Average();
        }

      
        public int GetElementAtIndex(int[] array, int index)
        {
            if (array == null || index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ số nằm ngoài phạm vi mảng");
            }
            return array[index];
        }
    }

    [TestFixture]
    public class MathOperationsTests
    {
        private MathOperations mathOps;

        [SetUp]
        public void SetUp()
        {
            mathOps = new MathOperations();
        }

        
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]      
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -3)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]            
        public void TinhTrungBinh_ValidInputs_ReturnsCorrectAverage(int[] numbers, double expected)
        {
            var result = mathOps.TinhTrungBinh(numbers);
            Assert.That(result, Is.EqualTo(expected).Within(0.01));
        }

        [Test]
        public void TinhTrungBinh_EmptyArray_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => mathOps.TinhTrungBinh(new int[] { }));
        }

        [Test]
        public void TinhTrungBinh_NullArray_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => mathOps.TinhTrungBinh(null));
        }

       
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 3)] 
        [TestCase(new int[] { 10, 20, 30 }, 0, 10)]   
        public void GetElementAtIndex_ValidInputs_ReturnsCorrectElement(int[] array, int index, int expected)
        {
            var result = mathOps.GetElementAtIndex(array, index);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetElementAtIndex_InvalidIndex_ThrowsException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => mathOps.GetElementAtIndex(new int[] { 1, 2, 3 }, 5));
        }

        [Test]
        public void GetElementAtIndex_NullArray_ThrowsException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => mathOps.GetElementAtIndex(null, 0));
        }
    }
}
