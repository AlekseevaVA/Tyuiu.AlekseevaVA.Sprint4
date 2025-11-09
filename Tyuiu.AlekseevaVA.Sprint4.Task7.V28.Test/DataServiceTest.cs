using Tyuiu.AlekseevaVA.Sprint4.Task7.V28.Lib;

namespace Tyuiu.AlekseevaVA.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "623351179845632";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4608;
            Assert.AreEqual(wait, res);


        }
    }
}
