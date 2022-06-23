using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №3
            string num = Console.ReadLine();
            string last = num[num.Length - 1].ToString();
            string first = num[0].ToString();
            bool bol = true;
            //uint nature;

            if (UInt32.TryParse(num, out _))
            {

                if (num.Length > 11)
                {
                    Console.WriteLine("Введите натуральное число не превышающее 10^9");
                    return;
                }
                if (last == "0" && first == "0")
                {
                    Console.WriteLine("Число должно быть натуральным и последние число не должно быть равным нулю");
                    return;
                }
                if (!String.IsNullOrEmpty(num))
                {
                    for (int i = 0; i < num.Length / 2; i++)
                    {
                        if (num[i] != num[num.Length - 1 - i])
                        {
                            bol = false;
                            Console.WriteLine("Введенное число не является палиндромом");
                            break;
                        }
                    }
                    if (bol == true)
                        Console.WriteLine("палиндромом");
                }
                else
                {
                    Console.WriteLine("Введенное число не является палиндромом");
                }
            }
            else
            {
                Console.WriteLine("Введенное число не является палиндромом");
            }
        }
    }
}
