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
            try
            {
                string first = num1[0].ToString();
                int num2 = 1;
                int num4 = 0;
                if (num1.Length > 6 | first == "0" | !UInt32.TryParse(num1, out _))
                {
                    Console.WriteLine("Введено некорректное значение");
                    return;
                }
                for (int i = 0; i < Int32.Parse(num1); i++)
                {
                    string num3 = num2.ToString();
                    string last = num3[num3.Length - 1].ToString();
                    num2++;
                    if (last == "0")
                    {
                        num4++;
                    }
                    if (num2 > 2 * (Math.Pow(10, 6)))
                    {
                        break;
                    }
                }
                Console.WriteLine($"Количество нулей во всех числах: {num4}");
            }
            catch
            {
                Console.WriteLine("Введено некорректное значение");
            }
            // for(int i = 1; i < Math.Pow(10, num1.Length); i++)

        }
    }
}
