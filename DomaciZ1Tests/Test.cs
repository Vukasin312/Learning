using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomaciZ1;

namespace DomaciZ1Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void AddInterval_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 15, true);
            i1.Add(i2);
            Assert.AreEqual(7, i1.GetDays(0));
            Assert.AreEqual(4, i1.GetHours(0));
            Assert.AreEqual(25, i1.GetMinutes(0));
        }

        [TestMethod]
        public void AddInterval_GoesOver60Mins_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 55, true);
            i1.Add(i2);
            Assert.AreEqual(7, i1.GetDays(0));
            Assert.AreEqual(5, i1.GetHours(0));
            Assert.AreEqual(25, i1.GetMinutes(0));
        }
        [TestMethod]
        public void SubstractInterval_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 15, true);
            i1.Subtract(i2);
            Assert.AreEqual(3, i1.GetDays(0));
            Assert.AreEqual(1, i1.GetHours(0));
            Assert.AreEqual(55, i1.GetMinutes(0));
        }
    }
}