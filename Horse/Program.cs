using System;

namespace Horse
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача №2           
            int columnHorse, stringHorse, columnOpponent, stringOpponent;
            // a столбец коня, c столбец противника; b строка коня, d строка соперника.
            Console.WriteLine("Введите координаты Коня от 1 до 8 , первая координата стоблец: ");
            columnHorse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая координата Коня строка: ");
            stringHorse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты соперника от 1 до 8 , первая координата стоблец: ");
            columnOpponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая координата соперника строка: ");
            stringOpponent = Convert.ToInt32(Console.ReadLine());

            int[] Check = new[] { columnHorse, stringHorse, columnOpponent, stringOpponent };
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
            if (columnHorse == columnOpponent && stringHorse == stringOpponent)
            {
                Console.WriteLine("фигуры стоят на одинаковых координатах");
                return;
            }
            //по модулю
            if ((columnOpponent == columnHorse + 1 && stringOpponent == stringHorse + 2 | stringOpponent == stringHorse - 2) ||
                (columnOpponent == columnHorse - 1 && stringOpponent == stringHorse + 2 | stringOpponent == stringHorse - 2) ||
                (columnOpponent == columnHorse - 2 && stringOpponent == stringHorse + 1 | stringOpponent == stringHorse - 1) ||
                (columnOpponent == columnHorse + 2 && stringOpponent == stringHorse + 1 | stringOpponent == stringHorse - 1))
            {
                Console.WriteLine("yes");
                return;
            }
            else
                Console.WriteLine("No");


        }
    }
}
