using Tyuiu.BukinTK.Sprint1.Task2.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Букин Т.К. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Букин Тимофей Константинович | ИСПБ-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x, y, z;

        Console.WriteLine("Введите длинну стороны параллелепипеда:");
        x = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Введите ширину стороны параллелепипеда:");
        y = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Введите высоту стороны параллелепипеда:");
        z = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.CalculateSideSquareParallelepiped(x, y, z));

        Console.ReadLine();
    }
}