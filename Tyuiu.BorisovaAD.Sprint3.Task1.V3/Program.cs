using Tyuiu.BorisovaAD.Sprint3.Task1.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
        Console.WriteLine("* ряда по формуле p = ∏[(a^k - 1/4)*cos(5)] при a=2, k от 1 до 6          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 2;
        int startValue = 1;
        int stopValue = 6;

        Console.WriteLine($"Переменная a = {value}");
        Console.WriteLine($"Старт шага = {startValue}");
        Console.WriteLine($"Конец шага = {stopValue}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double result = ds.GetMultiplySeries(startValue, stopValue);

        Console.WriteLine($"Произведение ряда = {result}");

        Console.ReadKey();
    }
}