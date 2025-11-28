using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task4.V4.Lib
{
    public class DataService : ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0.0;
            // Цикл for проходит по всем значениям x в заданном диапазоне
            for (int x = startValue; x <= stopValue; x++)
            {
                // Если x равно 0, прерываем цикл (по условию задачи)
                if (x == 0)
                {
                    break;
                }

                // Вычисляем значение функции y = x / (cos(x) + sin(x))
                // Все расчеты в Math.Cos/Math.Sin производятся в радианах
                double y = x / (Math.Cos(x) + Math.Sin(x));

                // Суммируем полученные значения
                sum += y;
            }

            return sum;
        }
    }
}
