using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task6.V1.Lib
{
    public class DataService : ISprint3Task6V1
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSumOfDivisors = 0;

            // Внешний цикл проходит по всем числам в заданном диапазоне [11, 17]
            for (int x = startValue; x <= stopValue; x++)
            {
                // Внутренний цикл находит все делители текущего числа x
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        // Если d является делителем x, добавляем его к общей сумме
                        totalSumOfDivisors += d;
                    }
                }
            }

            return totalSumOfDivisors;
        }
    }
}
