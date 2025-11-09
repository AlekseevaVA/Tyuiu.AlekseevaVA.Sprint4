using Tyuiu.AlekseevaVA.Sprint4.Task5.V30.Lib;

namespace Tyuiu.AlekseevaVA.Sprint4.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
            {
               {-1,-1,-1,-1,-1 },
               {-1,-1,-1,-1,1 },
               {-1,-1,2,-1,-1 },
               {-1,-1,-1,-1,-1 },
               {-1,-1,-1,-1,4 }
            };
            int res = ds.Calculate(matrix);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
