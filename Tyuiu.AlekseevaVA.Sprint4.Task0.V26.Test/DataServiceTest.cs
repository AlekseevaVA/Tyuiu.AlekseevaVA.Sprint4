using Tyuiu.AlekseevaVA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.AlekseevaVA.Sprint4.Task0.V26.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 9 ,3 ,7 ,1, 5 ,5 ,3 ,2 ,1, 7};
          
            int wait = 41;

            int res = ds.GetSumOddArrEl(nums);

            Assert.AreEqual(wait, res);

        }
    }
}
