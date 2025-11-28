using Tyuiu.BorisovaAD.Sprint3.Task2.V28.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            double expected = -23.11187494056294; // Ожидаемое значение, рассчитанное заранее

            double actual = ds.GetMultiplySeries(startValue, stopValue);

            // Используем Assert.AreEqual с погрешностью (например, 0.0001) для сравнения вещественных чисел
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
