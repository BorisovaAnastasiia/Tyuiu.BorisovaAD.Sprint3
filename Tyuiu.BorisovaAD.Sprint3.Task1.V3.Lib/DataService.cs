using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue; // Инициализируем счетчик цикла while

            // Вычисляем знаменатель, так как он константа
            double denominator = Math.Pow(Math.Cos(5) + 1, 2);

            // Цикл while проходит по всем значениям k в заданном диапазоне
            while (k <= stopValue)
            {
                // Формула: (k / denominator)
                double term = (double)k / denominator;
                product *= term;
                k++; // Инкрементируем счетчик цикла
            }

            return product;
        }
    }
}
