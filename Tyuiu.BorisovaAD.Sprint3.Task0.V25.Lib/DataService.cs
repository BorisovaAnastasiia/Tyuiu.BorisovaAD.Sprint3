using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int x = 5; // по условию x=5
            double baseValue = (double)4 / (1 + x); // выражение под степенью

            for (int i = startValue; i <= stopValue; i++)
            {
                sum += Math.Pow(baseValue, i);
            }

            return sum;
        }
    }
}
