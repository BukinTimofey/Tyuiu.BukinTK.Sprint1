using Tyuiu.BukinTK.Sprint1.Task2.V18.Lib;

namespace Tyuiu.BukinTK.Sprint1.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            int z = 3;
            var res = ds.CalculateSideSquareParallelepiped(x, y, z);
            Assert.AreEqual(18, res);
        }
    }
}
