using FCC;

namespace FCC_Test
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
            FCCMath fc = new();
            int result = fc.multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }
    }
}