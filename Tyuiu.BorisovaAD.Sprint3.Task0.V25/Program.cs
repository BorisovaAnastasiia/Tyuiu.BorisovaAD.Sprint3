using Tyuiu.BorisovaAD.Sprint3.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #0 | Вариант #25 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | СМАРТб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле:            *");
        Console.WriteLine("* S = Sum[i=1 to 14] ((4 / (1 + x^i))^i) при X=5                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        int startValue = 1;
        int stopValue = 14;

        Console.WriteLine($"Переменная X = {x}");
        Console.WriteLine($"i меняется от {startValue} до {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSeries(startValue, stopValue, x);
        Console.WriteLine($"Сумма ряда S = {result}");

        Console.ReadKey();
    }
}