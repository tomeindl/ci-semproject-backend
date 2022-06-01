using NUnit.Framework;

namespace CSBackend_UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            //Arrange
            string s = "Test";

            //Act
            

            //Assert
            Assert.AreEqual(s, "Test");
        }
    }
}