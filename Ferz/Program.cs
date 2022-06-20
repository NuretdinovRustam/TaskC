using System;

namespace Ferz
{
    class Program
    {
        static void Main(string[] args)
        {
            // задача №1
            int a, b, c, d;
            // a столбец ферзя, c столбец противника; b строка ферзя, d строка соперника.
            Console.WriteLine("Введите координаты Ферзя от 1 до 8 , первая координата стоблец: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 1 | a > 8)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            Console.WriteLine("Вторая координата Ферзя строка: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 1 | b > 8)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            Console.WriteLine("Введите координаты соперника от 1 до 8 , первая координата стоблец: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < 1 | c > 8)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            Console.WriteLine("Вторая координата соперника строка: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (d < 1 | d > 8)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            if (a == c && b == d)
            {
                Console.WriteLine("фигуры стоят на одинаковых координатах");
                return;
            }
            if (a == c | b == d)
            {
                Console.WriteLine("YES");
                return;
            }
            if (Math.Abs(a - c) == Math.Abs(d - b))
            {
                Console.WriteLine("YES");
                return;
            }
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
