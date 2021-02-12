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
        public void GivenFirst(int num1,int num2,int num3)
        {
            Assert.AreEqual(num1,findMaximum.FindMaximumNumber(num1,num2,num3));
        }
    }
}