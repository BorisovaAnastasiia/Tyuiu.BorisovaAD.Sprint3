using Tyuiu.BorisovaAD.Sprint3.Task3.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #3 | Вариант #29 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование оператора foreach в строках                         *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-23-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach удалить из строки все буквы h в строке:          *");
        Console.WriteLine("* \"chgr vhhtg hnht\"                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string initialString = "chgr vhhtg hnht";
        char charToDelete = 'h';

        Console.WriteLine($"Исходная строка: {initialString}");
        Console.WriteLine($"Удаляемый символ: {charToDelete}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string result = ds.DeleteCharInString(initialString, charToDelete);
        Console.WriteLine($"Строка после удаления символа '{charToDelete}': {result}");

        Console.ReadKey();
    }
}