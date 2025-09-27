using Tyuiu.BukinTK.Sprint1.Task4.V24.Lib;

namespace Tyuiu.BukinTK.Sprint1.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0,287, res);
        }
    }
}
