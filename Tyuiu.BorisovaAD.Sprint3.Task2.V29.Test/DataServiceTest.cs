using Tyuiu.BorisovaAD.Sprint3.Task3.V29.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hnht";
            char item = 'h';
            string expected = "cgr vtg nt"; // Ожидаемый результат: все 'h' удалены

            string actual = ds.DeleteCharInString(value, item);

            Assert.AreEqual(expected, actual);
        }
    }
}
