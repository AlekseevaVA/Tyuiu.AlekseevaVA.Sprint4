using Tyuiu.AlekseevaVA.Sprint4.Task6.V17.Lib;


namespace Tyuiu.AlekseevaVA.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] lang = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(lang);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
