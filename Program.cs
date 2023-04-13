using NUnit.Framework;

namespace Mob
{
    public class LeapYear
    {
        public bool IsLeap(int i)
        {
            return true;
        }
    }

    public class Tests
    {
        private readonly LeapYear _leapYear = new LeapYear();

        [TestCase(400, true)]
        public void ShouldYear400BeLeap(int year, bool expected)
        {
            Assert.AreEqual(_leapYear.IsLeap(year), expected);
        }
    }
}

