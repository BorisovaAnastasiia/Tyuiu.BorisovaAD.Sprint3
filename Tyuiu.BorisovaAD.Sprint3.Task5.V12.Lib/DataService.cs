using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task5.V12.Lib
{
    public class DataService : ISprint3Task5V12
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            // Внешний цикл по i
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл по k (значение k в формуле не зависит от i)
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Суммируем cos(k). Math.Cos работает с радианами.
                    sumSeries += Math.Cos(k);
                }
            }

            // Добавляем часть x/2, которая находится вне сумм
            sumSeries += (double)x / 2;

            return sumSeries;
        }
    }
}
