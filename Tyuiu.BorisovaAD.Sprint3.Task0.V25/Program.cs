using Tyuiu.BorisovaAD.Sprint3.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
        Console.WriteLine("* по формуле S = ∑(1/sin²(k)) при k от 1 до 10                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine($"Старт шага = {startValue}");
        Console.WriteLine($"Конец шага = {stopValue}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double result = ds.GetSumSeries(startValue, stopValue);

        Console.WriteLine($"Сумма ряда = {result}");

        Console.ReadKey();
    }
}