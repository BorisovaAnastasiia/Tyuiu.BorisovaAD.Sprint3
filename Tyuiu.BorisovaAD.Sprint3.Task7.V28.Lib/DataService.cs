using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Определяем размер массива: количество значений в диапазоне [startValue, stopValue]
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;

            // Цикл проходит по всем значениям x в заданном диапазоне
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: x + 2.5 == 0, то есть x == -2.5
                // Поскольку x - целое число в цикле, точного совпадения x == -2.5 не будет, 
                // но проверка все равно необходима, если бы шаг был другим.
                // В данной задаче знаменатель никогда не будет равен 0 при целых x.

                // Вычисляем значение функции F(x) = cos(2x) + sin(x)/(x+2.5) + 2x
                y = Math.Cos(2 * x) + Math.Sin(x) / (x + 2.5) + 2 * x;

                // Округляем результат до двух знаков после запятой
                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
