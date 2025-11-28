using Tyuiu.BorisovaAD.Sprint3.Task2.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #2 | Вариант #28 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл do-while                                                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | ИСПб-23-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет           *");
        Console.WriteLine("* произведение ряда по формуле: P = [Произведение от k=1 до 9] * cos(1.8) *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 1;
        int stopValue = 9;

        Console.WriteLine($"Начальное значение ряда: {startValue}");
        Console.WriteLine($"Конечное значение ряда: {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetMultiplySeries(startValue, stopValue);
        Console.WriteLine($"Произведение ряда P = {result}");

        Console.ReadKey();
    }
}