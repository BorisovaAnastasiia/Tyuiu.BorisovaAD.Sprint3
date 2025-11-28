using Tyuiu.BorisovaAD.Sprint3.Task4.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #4 | Вариант #4 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование операторов break и continue в циклах                  *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение       *");
        Console.WriteLine("* функции y=x/(cos(x)+sin(x)). При х = 0 прервать цикл. Полученные         *");
        Console.WriteLine("* значения суммировать.                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine($"Старт диапазона: {startValue}");
        Console.WriteLine($"Конец диапазона: {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.Calculate(startValue, stopValue);
        // Результат будет суммой значений для x = -5, -4, -3, -2, -1.
        Console.WriteLine($"Сумма значений функции на отрезке до x=0: {result:F3}");

        Console.ReadKey();
    }
}