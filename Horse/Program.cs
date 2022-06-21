using System;

namespace Horse
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача №2
            int a, b, c, d;
            // a столбец коня, c столбец противника; b строка коня, d строка соперника.
            Console.WriteLine("Введите координаты Коня от 1 до 8 , первая координата стоблец: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 1 | a > 8)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            Console.WriteLine("Вторая координата Коня строка: ");
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
            //if ((Math.Abs(a - c) <= 2 && Math.Abs(b - d) <= 2) && (Math.Abs(a - c) >= 1 && Math.Abs(b - d) >= 1))
            if ((c == a + 1 && d == b + 2 | d == b - 2) ||
                (c == a - 1 && d == b + 2 | d == b - 2) ||
                (c == a - 2 && d == b + 1 | d == b - 1) ||
                (c == a + 2 && d == b + 1 | d == b - 1))
            {
                Console.WriteLine("yes");
                return;
            }
            else
                Console.WriteLine("No");


        }
    }
}
