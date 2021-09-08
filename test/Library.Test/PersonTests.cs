using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestName()
        {
            Person p = new Person("Marcelo", "5.068.112-9", "24/12/2000");
            string expected = "Marcelo";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestValidId()
        {
            Person p = new Person("Marcelo", "5.068.112-9", "24/12/2000");
            string expected = "5.068.112-9";
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestWrongId()
        {
            Person p = new Person("Marcelo", "1.234.567-8", "24/12/2000");
            string expected = null;
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestValidDoB()
        {
            Person p = new Person("Marcelo", "1.234.567-8", "24/12/2000");
            string expected = "24/12/2000";
            Assert.AreEqual(expected, p.FechaNacimiento);
        }

        [Test]
        public void TestWrongDoB()
        {
            Person p = new Person("Marcelo", "1.234.567-8", "8/13/1988");
            string expected = "1/1/1900";
            Assert.AreEqual(expected, p.FechaNacimiento);
        }
    }
}