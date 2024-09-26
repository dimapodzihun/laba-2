using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class Program
    {
        static void Main(string[] args)

        { //task 1
            Console.WriteLine("Завдання 1");
            {Console.WriteLine("значення х:");
            int x = Convert.ToInt32(Console.ReadLine());
            double a = 0.7;
            double y;
            Console.WriteLine("Значення y:");

                if (x > 0)
                {

                    y = (Math.Sqrt(Math.Pow(x, 3)) / (x + a)) - (Math.Log(x));
                    Console.WriteLine(y);
                }
                else if (x < 0)
                {
                    y = 2 * a * (Math.Log(-x));
                    Console.WriteLine(y);
                }
                else if (x == 0)
                {
                    y = 0;
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //task 2
            Console.WriteLine("Завдання 2");
            Console.Write("Введіть чотиризначне число: ");
            string input = Console.ReadLine();
            if (input.Length == 4 && int.TryParse(input, out int number))
            {
                int sum = 0;
                sum += (number / 1000) % 10;
                sum += (number / 100) % 10;
                sum += (number / 10) % 10;
                sum += number % 10;


                Console.WriteLine($"Сума цифр: {sum}");
            }
            else
            {
                Console.WriteLine("Помилка: введіть чотиризначне число.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //task 3
            Console.WriteLine("Завдання 3");
           {     Console.WriteLine("Ввести число a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввести число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести число c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        p = 1;
                        double P;
                        P = a + b + c;
                        Console.WriteLine(P);
                        break;

                    case 2:
                        p = 2;
                        double s = (a + b + c) / 2;
                        double S = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                        Console.WriteLine(S);
                        break;
                    case 3:
                        p = 3;
                        if (a == b && b == c)
                        {
                            Console.WriteLine("Трикутник рівносторонній.");
                        }
                        else if (a == b || b == c || a == c)
                        {
                            Console.WriteLine("Трикутник рівнобедрений.");
                        }
                        else
                        {
                            Console.WriteLine("Трикутник довільний.");
                        }
                        break;
                    default:
                        Console.WriteLine("Невірне значення p.");
                        break;

                }
            }
        }
    }
}
