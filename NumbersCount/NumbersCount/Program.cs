using System;

namespace NumbersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №4
            Console.WriteLine("Введите натурально число не превышающее <= 10^5");
            string num1 = Console.ReadLine();
            //добавил try если начнут вводить некорректные символы
            try
            {
                string first = num1[0].ToString();
                int num4 = 0;
                if (num1.Length > 6 | first == "0" | !UInt32.TryParse(num1, out _))
                {
                    Console.WriteLine("Введено некорректное значение");
                    return;
                }
                for (int i = 0; i < Int32.Parse(num1); i++)
                {
                    Console.WriteLine("Теперь введите число: ");
                    string num5 = Console.ReadLine();
                    string last = num5[num5.Length - 1].ToString();
                    if (Int32.Parse(num5) > 2 * (Math.Pow(10, 6)))
                    {
                        Console.WriteLine("Введено некорректное значение");
                    }
                    else if (last == "0")
                    {
                        num4++;
                    }
                }
                Console.WriteLine($"Количество нулей во всех числах: {num4}");
            }
            catch
            {
                Console.WriteLine("Введено некорректное значение");
            }


        }
    }
}
