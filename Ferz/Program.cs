using System;

namespace Ferz
{
    class Program
    {
        static void Main(string[] args)
        {
            // задача №1            
            Console.WriteLine("Введите координаты  Ферзя от 1 до 8 , первая координата стоблец: ");
            int columnQueen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая координата Ферзя строка: ");
            int stringQueen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты соперника от 1 до 8 , первая координата стоблец: ");
            int columnOpponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая координата соперника строка: ");
            int stringOpponent = Convert.ToInt32(Console.ReadLine());

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
            }
            else if (columnQueen == columnOpponent && stringQueen == stringOpponent)
            {
                Console.WriteLine("фигуры стоят на одинаковых координатах");
            }
            else if (columnQueen == columnOpponent | stringQueen == stringOpponent)
            {
                Console.WriteLine("YES");
            }
            else if (Math.Abs(columnQueen - columnOpponent) == Math.Abs(stringOpponent - stringQueen))
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
