using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue; // Инициализируем счетчик цикла

            // Вычисляем произведение ряда с помощью do...while
            do
            {
                // Формула: (2^k / (k+1))
                double term = Math.Pow(2, k) / (k + 1);
                product *= term;
                k++;
            } while (k <= stopValue); // Условие продолжения цикла

            // Умножаем итоговое произведение на cos(1.8) (в радианах)
            product *= Math.Cos(1.8);

            return product;
        }
    }
}
