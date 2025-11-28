using Tyuiu.BorisovaAD.Sprint3.Task5.V12.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            // Ожидаемое значение, рассчитанное заранее: 
            // 3 * (cos(1) + ... + cos(10)) + 5/2 = -2.977413697... + 2.5 = -0.477413697...
            double expected = -0.4774136973307521;

            double actual = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Используем Assert.AreEqual с погрешностью (например, 0.0001) для сравнения вещественных чисел
            Assert.AreEqual(expected, actual, 0.0001);
        }
}
