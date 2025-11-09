using Tyuiu.AlekseevaVA.Sprint4.Task2.V12.Lib;

namespace Tyuiu.AlekseevaVA.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 5, 7, 4, 9, 6, 5, 8, 7, 9, 4, 5, 7, 9, 5 };

            int wait = 68;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
