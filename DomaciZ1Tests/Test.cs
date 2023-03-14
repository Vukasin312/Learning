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
            var result = i1.Add(i2);
            Assert.AreEqual(7, result.GetDays());
            Assert.AreEqual(4, result.GetHours());
            Assert.AreEqual(25, result.GetMinutes());
        }

        [TestMethod]
        public void AddInterval_GoesOver60Mins_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 55, true);
            var result = i1.Add(i2);
            Assert.AreEqual(7, result.GetDays());
            Assert.AreEqual(5, result.GetHours());
            Assert.AreEqual(5, result.GetMinutes());
        }
        [TestMethod]
        public void SubstractInterval_ReturnsOk()
        {
            Interval i1 = new(5, 3, 10, true);
            Interval i2 = new(2, 1, 15, true);
            var result = i1.Subtract(i2);
            Assert.AreEqual(3, result.GetDays());
            Assert.AreEqual(1, result.GetHours());
            Assert.AreEqual(55, result.GetMinutes());
        }
        [TestMethod]
        public void AddInterval_GoesOver60MinsAnd24Hours_ReturnsOk()
        {
            Interval i1 = new(5, 23, 10, true);
            Interval i2 = new(2, 1, 55, true);
            var result = i1.Add(i2);
            Assert.AreEqual(8, result.GetDays());
            Assert.AreEqual(1, result.GetHours());
            Assert.AreEqual(5, result.GetMinutes());
        }

        [TestMethod]
        public void AddInterval_Exaclty60MinsAnd24Hours_ReturnsOk()
        {
            Interval i1 = new Interval(28, 20, 30, true);
            Interval i2 = new Interval(28, 3, 30, true);
            var result = i1.Add(i2);
            Assert.AreEqual(57, result.GetDays());
            Assert.AreEqual(0, result.GetHours());
            Assert.AreEqual(5, result.GetMinutes());
        }
    }
}