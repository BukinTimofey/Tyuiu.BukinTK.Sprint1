using Tyuiu.BukinTK.Sprint1.Task6.V10.Lib;

internal class Program
{
    //private static void Main(string[] args)
    //{
    //    DataService ds = new DataService();
    //    Console.Title = "Спринт #1 | Выполнил: Букин Т.К. | ИСПБ-25-1";
    //    Console.WriteLine("***************************************************************************");
    //    Console.WriteLine("* Спринт #1                                                               *");
    //    Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
    //    Console.WriteLine("* Задание #6                                                              *");
    //    Console.WriteLine("* Вариант #10                                                             *");
    //    Console.WriteLine("* Выполнил: Букин Тимофей Константинович | ИСПБ-25-1                      *");
    //    Console.WriteLine("***************************************************************************");
    //    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    //    Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,    *");
    //    Console.WriteLine("* удалив среднюю букву у слов нечетной длины.                             *");
    //    Console.WriteLine("*                                                                         *");
    //    Console.WriteLine("***************************************************************************");
    //    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    //    Console.WriteLine("***************************************************************************");

    //    string x;

    //    Console.WriteLine("Введите текст");
    //    x = Console.ReadLine();

    //    Console.WriteLine("***************************************************************************");
    //    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    //    Console.WriteLine("***************************************************************************");

    //    Console.WriteLine(ds.DeleteMiddleLetter(x));

    //    Console.ReadLine();
    //}
    static void Main(string[] args)

    {

        int a = 0, b = 0, c = 0, d = 0;

        Console.WriteLine("Enter data");

        a = Convert.ToInt32(Console.ReadLine());

        b = Convert.ToInt32(Console.ReadLine());

        c = Convert.ToInt32(Console.ReadLine());

        b *= a * c;

        d = a + c;

        a = b - d;

        c -= a;

        Console.WriteLine("Result = {0}", d);

    }
}