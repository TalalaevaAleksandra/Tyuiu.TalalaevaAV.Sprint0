using Tyuiu.TalalaevaAV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TalalaevaAV.Sprint0.V0.Task2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "����������";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("������..., ����������", res);
        }
    }
}