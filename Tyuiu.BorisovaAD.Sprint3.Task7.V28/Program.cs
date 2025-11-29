using Tyuiu.BorisovaAD.Sprint3.Task7.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #7 | Вариант #28 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Дополнительное задание. Табулирование функции с помощью циклов    *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("* F(x) = cos(2x) + sin(x)/(x+2.5) + 2x на диапазоне [-5; 5] с шагом 1.   *");
        Console.WriteLine("* Значения округлить до двух знаков после запятой и занести в массив.     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine($"Начало диапазона: {startValue}");
        Console.WriteLine($"Конец диапазона: {stopValue}");

        // Получаем массив значений функции
        double[] functionValues = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   F(X)   |");
        Console.WriteLine("+----------+----------+");
        for (int i = 0; i < functionValues.Length; i++)
        {
            // Вывод значений X и F(X) из массива, округленных до 2 знаков
            Console.WriteLine("| {0,8:d} | {1,8:F2} |", startValue + i, functionValues[i]);
        }
        Console.WriteLine("+----------+----------+");

        Console.ReadKey();
    }
}