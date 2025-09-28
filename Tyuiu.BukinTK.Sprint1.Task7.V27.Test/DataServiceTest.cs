using Tyuiu.BukinTK.Sprint1.Task7.V27.Lib;

namespace Tyuiu.BukinTK.Sprint1.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.53, res);
        }
    }
}
