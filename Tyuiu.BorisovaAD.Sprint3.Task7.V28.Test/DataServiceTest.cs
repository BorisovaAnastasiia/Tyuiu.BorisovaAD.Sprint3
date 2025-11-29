using Tyuiu.BorisovaAD.Sprint3.Task7.V28.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            // Ожидаемые значения, округленные до двух знаков после запятой
            double[] expected = new double[] {
                -10.42, -8.67, -5.92, -3.93, -1.97, 0.0, 2.01, 3.99, 5.96, 7.95, 10.02
            };

            double[] actual = ds.GetMassFunction(startValue, stopValue);

            // Сравниваем массивы поэлементно
            CollectionAssert.AreEqual(expected, actual);
        }
}
