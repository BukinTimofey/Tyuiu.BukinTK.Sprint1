using Tyuiu.BukinTK.Sprint1.Task3.V3.Lib;

namespace Tyuiu.BukinTK.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValisExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = 3;
            double res = ds.ParallelepipedVolume(x, y, z);
            Assert.AreEqual(6.0, res);
        }
    }
}
