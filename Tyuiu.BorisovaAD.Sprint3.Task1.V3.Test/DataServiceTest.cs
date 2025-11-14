using Tyuiu.BorisovaAD.Sprint3.Task1.V3.Lib;
namespace Tyuiu.BorisovaAD.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            // Arrange
            var dataService = new DataService();
            int startValue = 1;
            int stopValue = 10;

            // Act
            double actual = dataService.GetMultiplySeries(startValue, stopValue);

            // Вычислим ожидаемый результат вручную 
            double expected = 1.0;
            double denom = Math.Cos(5) + 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = k / denom;
                expected *= term * term;
            }

            // Assert
            Assert.AreEqual(expected, actual, 1e-10, "Произведение ряда вычислено неверно");
        }
    }
}
