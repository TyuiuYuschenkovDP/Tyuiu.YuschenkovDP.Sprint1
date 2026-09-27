using Tyuiu.YuschenkovDP.Sprint1.Task6.V1.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ющенков Д.П. | ПКТБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класса String                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Ющенков Данил Петрович | ПКТБ-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем        *");
            Console.WriteLine("* символа. Программа должна завершать работу в результате ввода точки.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    continue;

                char symbol = input[0];

                if (symbol == '.')
                    break;

                Console.WriteLine(ds.SymbolCode(input));
            }

            Console.ReadLine();
        }
    }
}