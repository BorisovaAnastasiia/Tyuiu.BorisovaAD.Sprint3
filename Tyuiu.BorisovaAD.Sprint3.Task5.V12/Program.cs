using Tyuiu.BorisovaAD.Sprint3.Task5.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #5 | Вариант #12 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-23-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет значение функции по формуле:      *");
        Console.WriteLine("* y = Sum[i=1 to 3] Sum[k=1 to 10] cos(k) + x/2                           *");
        Console.WriteLine("* при X=5                                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 10;

        Console.WriteLine($"Переменная X = {x}");
        Console.WriteLine($"i меняется от {startValue1} до {stopValue1}");
        Console.WriteLine($"k меняется от {startValue2} до {stopValue2}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
        Console.WriteLine($"Результат вычислений: {result}");

        Console.ReadKey();
    }
}