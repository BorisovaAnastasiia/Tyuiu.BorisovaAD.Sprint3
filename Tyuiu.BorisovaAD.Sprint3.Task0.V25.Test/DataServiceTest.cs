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

            // Параметры для вычислений:
            int value = 0; // не используется в формуле
            int startValue = 1;
            int stopValue = 14;

            // Вызов метода
            double result = ds.GetSumSeries(value, startValue, stopValue);

            // Ожидаемое значение можно заранее вычислить или использовать приблизительное значение
            // Для проверки можно взять примерное значение вручную посчитаной суммы ряда
            // Пример (вариант проверки): приблизительно 3.41 (зависит от точности вычисления)

            double expected = 3.41;
            double delta = 0.01; // допустимая погрешность

            Assert.AreEqual(expected, result, delta, "Сумма ряда вычислена неверно");
        }
    }
}
