using NUnit.Framework;
using FindMaxUsingGenerics;
namespace FindMaximumTest
{
    public class Tests
    {
        FindMaximum findMaximum;
        [SetUp]
        public void Setup()
        {
            findMaximum = new FindMaximum();
        }

        [Test]
        [TestCase(99,43,13)]
        public void GivenFirstNumMaximum_ReturnMaximum(int num1,int num2,int num3)
        {
            Assert.AreEqual(num1,findMaximum.FindMaximumNumber(num1,num2,num3));
        }

        [Test]
        [TestCase(55, 99, 34)]
        public void GivenSecondNumMaximum_ReturnMaximum(int num1, int num2, int num3)
        {
            Assert.AreEqual(num2, findMaximum.FindMaximumNumber(num1, num2, num3));
        }

        [Test]
        [TestCase(12, 43, 99)]
        public void GivenThirdNumMaximum_ReturnMaximum(int num1, int num2, int num3)
        {
            Assert.AreEqual(num3, findMaximum.FindMaximumNumber(num1, num2, num3));
        }


        [Test]
        [TestCase(99.23f, 43.45f, 13.45f)]
        public void GivenFirstNumFloatMaximum_ReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num1, findMaximum.FindMaximumNumber(num1, num2, num3));
        }

        [Test]
        [TestCase(55.56f, 99.56f, 34.43f)]
        public void GivenSecondNumFloatMaximum_ReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num2, findMaximum.FindMaximumNumber(num1, num2, num3));
        }

        [Test]
        [TestCase(12.57f, 43.45f, 99.3f)]
        public void GivenThirdNumFloatMaximum_ReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num3, findMaximum.FindMaximumNumber(num1, num2, num3));
        }

        [Test]
        [TestCase("Xerox","Thanos" , "Avengers")]
        public void GivenFirstStringMaximum_ReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str1, findMaximum.FindMaximumNumber(str1, str2, str3));
        }

        [Test]
        [TestCase("Thanos", "Xerox", "Avengers")]
        public void GivenSecondStringMaximum_ReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str2, findMaximum.FindMaximumNumber(str1, str2, str3));
        }

        [Test]
        [TestCase("Thanos", "Avengers", "Xerox")]
        public void GivenThirdStringMaximum_ReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str3, findMaximum.FindMaximumNumber(str1, str2, str3));
        }



    }
}