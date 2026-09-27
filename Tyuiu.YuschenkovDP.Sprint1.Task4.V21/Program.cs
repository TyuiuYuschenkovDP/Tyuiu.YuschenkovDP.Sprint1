using Tyuiu.YuschenkovDP.Sprint1.Task4.V21.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ющенков Д.П. | ПКТБ-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Ющенков Данил Петрович  | ПКТБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет резудьтат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("| ( 1 + x ) ^ 2 - y | / x + y = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
