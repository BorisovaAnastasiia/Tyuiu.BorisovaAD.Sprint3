using Tyuiu.BorisovaAD.Sprint3.Task6.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #6 | Вариант #1 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка строковых и числовых данных при помощи циклов           *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
        Console.WriteLine("* числовому отрезку [11, 17] сумму всех делителей.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 11;
        int stopValue = 17;

        Console.WriteLine($"Начало отрезка: {startValue}");
        Console.WriteLine($"Конец отрезка: {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.GetSumTheDivisors(startValue, stopValue);
        Console.WriteLine($"Сумма всех делителей чисел из отрезка [11, 17]: {result}");

        Console.ReadKey();
    }
}