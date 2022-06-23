using System;

namespace Ferz
{
    class Program
    {
        static void Main(string[] args)
        {
            // задача №1
            int columnQueen, stringQueen, columnOpponent, stringOpponent;
            Console.WriteLine("Введите координаты  Ферзя от 1 до 8 , первая координата стоблец: ");
            columnQueen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая координата Ферзя строка: ");
            stringQueen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты соперника от 1 до 8 , первая координата стоблец: ");
            columnOpponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая координата соперника строка: ");
            stringOpponent = Convert.ToInt32(Console.ReadLine());

            int[] Check = new[] { columnQueen, stringQueen, columnOpponent, stringOpponent };
            bool CheckCoordinates(params int[] coordinates)
            {
                bool result = true;
                foreach (var n in coordinates)
                {
                    if (n < 1 | n > 8)
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }
            if (CheckCoordinates(Check) == false)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            if (columnQueen == columnOpponent && stringQueen == stringOpponent)
            {
                Console.WriteLine("фигуры стоят на одинаковых координатах");
                return;
            }
            if (columnQueen == columnOpponent | stringQueen == stringOpponent)
            {
                Console.WriteLine("YES");
                return;
            }
            if (Math.Abs(columnQueen - columnOpponent) == Math.Abs(stringOpponent - stringQueen))
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
