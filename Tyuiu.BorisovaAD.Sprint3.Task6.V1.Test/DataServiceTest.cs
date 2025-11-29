using Tyuiu.BorisovaAD.Sprint3.Task6.V1.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 11;
            int stopValue = 17;
            // Ожидаемый результат: сумма делителей для 11, 12, 13, 14, 15, 16, 17 = 151
            int expected = 151;

            int actual = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(expected, actual);
        }
}
