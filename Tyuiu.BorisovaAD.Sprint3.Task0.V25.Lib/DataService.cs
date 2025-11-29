using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            // Цикл for проходит по всем значениям i в заданном диапазоне
            for (int i = startValue; i <= stopValue; i++)
            {
                // Вычисляем значение члена ряда: (4 / (1 + x^i))^i
                double term = Math.Pow((double)4 / (1 + Math.Pow(x, i)), i);
                sumSeries += term;
            }

            return sumSeries;
        }
    }
}
