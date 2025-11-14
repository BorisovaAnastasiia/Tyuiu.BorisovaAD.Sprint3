using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1.0;
            int k = startValue;
            double denominator = Math.Cos(5) + 1;

            while (k <= stopValue)
            {
                double term = k / denominator;
                result *= term * term; // возводим в квадрат
                k++;
            }

            return result;
        }
    }
}
