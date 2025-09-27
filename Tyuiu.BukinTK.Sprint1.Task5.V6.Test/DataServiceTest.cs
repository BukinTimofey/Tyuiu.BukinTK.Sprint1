using Tyuiu.BukinTK.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BukinTK.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10;
            double res = ds.Calculate(x);
            Assert.AreEqual(3, res);
        }
    }
}
