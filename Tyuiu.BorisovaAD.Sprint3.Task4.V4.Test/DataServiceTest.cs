using Tyuiu.BorisovaAD.Sprint3.Task4.V4.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            // Ожидаемый результат: сумма для x = -5, -4, -3, -2, -1
            // Расчетное значение: -0.6669931885848772
            double expected = -0.6669931885848772;

            double actual = ds.Calculate(startValue, stopValue);

            // Используем Assert.AreEqual с погрешностью (например, 0.0001) для сравнения вещественных чисел
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
