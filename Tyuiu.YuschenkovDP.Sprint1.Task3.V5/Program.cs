using Tyuiu.YuschenkovDP.Sprint1.Task3.V5.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчеты и печатает результат на экране.
//Рассчеты: Обьявите необходимые переменные и напишите программу расчета хода фигуры "Слон".

namespace Tyuiu.YuschenkovDP.Sprint1.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ющенков Д.П. | ПКТБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивателя                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Ющенков Данил Петрович | ПКТБ-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,    *");
            Console.WriteLine("* изображенными на карте. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double mapScale;
            Console.WriteLine("Введите масштаб карты (км в 1 см):");
            mapScale = Convert.ToDouble(Console.ReadLine());

            double distanceBetweenPoints;
            Console.WriteLine("Введите расстояние между точками на карте (см):");
            distanceBetweenPoints = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между населенными пунктами - " + ds.DistanceLength(mapScale, distanceBetweenPoints) + " км");

            Console.ReadLine();
        }
    }
}
        