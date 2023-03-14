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
            Assert.AreEqual(7, i1.GetDays());
            Assert.AreEqual(4, i1.GetHours());
            Assert.AreEqual(25, i1.GetMinutes());
        }

        [TestMethod]
        public void AddInterval_GoesOver60Mins_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 55, true);
            i1.Add(i2);
            Assert.AreEqual(7, i1.GetDays());
            Assert.AreEqual(5, i1.GetHours());
            Assert.AreEqual(5, i1.GetMinutes());
        }
        [TestMethod]
        public void SubstractInterval_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 15, true);
            i1.Subtract(i2);
            Assert.AreEqual(3, i1.GetDays());
            Assert.AreEqual(1, i1.GetHours());
            Assert.AreEqual(55, i1.GetMinutes());
        }
        [TestMethod]
        public void AddInterval_GoesOver60MinsAnd24Hours_ReturnsOk()
        {
            Interval i1 = new(5, 23, 10, true);
            Interval i2 = new(2, 1, 55, true);
            i1.Add(i2);
            Assert.AreEqual(8, i1.GetDays());
            Assert.AreEqual(1, i1.GetHours());
            Assert.AreEqual(5, i1.GetMinutes());
        }

        [TestMethod]
        public void AddInterval_1s_ReturnsOk()
        {
            var test = new Interval(28, 20, 33, true).Add(new Interval(28, 3, 32, true));
            Assert.AreEqual(57, test.GetDays());
            Assert.AreEqual(0, test.GetHours());
            Assert.AreEqual(5, test.GetMinutes());
        }
    }
}