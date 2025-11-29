using Tyuiu.BorisovaAD.Sprint3.Task1.V3.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            // Ожидаемое значение, рассчитанное заранее: ~0.0000000000000001
            double expected = 1.2589254425442531E-16;

            double actual = ds.GetMultiplySeries(startValue, stopValue);

            // Используем Assert.AreEqual с погрешностью (например, 0.0001) для сравнения вещественных чисел
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
