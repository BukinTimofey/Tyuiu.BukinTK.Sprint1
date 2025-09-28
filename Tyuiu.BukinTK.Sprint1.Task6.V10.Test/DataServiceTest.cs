using Tyuiu.BukinTK.Sprint1.Task6.V10.Lib;

namespace Tyuiu.BukinTK.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "Hello world";
            string res = ds.DeleteMiddleLetter(x);
            Assert.AreEqual("Helo wold", res);
        }
    }
}
