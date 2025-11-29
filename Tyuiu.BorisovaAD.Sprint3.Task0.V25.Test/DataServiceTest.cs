using Tyuiu.BorisovaAD.Sprint3.Task0.V25.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 14;
            // Ожидаемое значение, рассчитанное заранее: ~0.835472855...
            double expected = 0.835472855146522;

            double actual = ds.GetSumSeries(startValue, stopValue, x);

            // Используем Assert.AreEqual с погрешностью (например, 0.0001) для сравнения вещественных чисел
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
