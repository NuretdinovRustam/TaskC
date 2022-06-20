using System;

namespace NumbersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №4
            Console.WriteLine("Введите число не превышающее <= 10^5");
            string num1 = Console.ReadLine();
            int num2 = 1;
            int num4 = 0;
            if (num1.Length > 6)
            {
                Console.WriteLine("Введено число больше <= 10^5");
                return;
            }
            // for(int i = 1; i < Math.Pow(10, num1.Length); i++)
            for (int i = 0; i < Int32.Parse(num1); i++)
            {
                string num3 = num2.ToString();
                string last = num3[num3.Length - 1].ToString();
                num2++;
                if (last == "0")
                {
                    num4++;
                }
            }
            Console.WriteLine($"Количество нулей во всех числах: {num4}");
        }
    }
}
