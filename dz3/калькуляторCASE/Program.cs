using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькуляторCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                double a, b;
                string action;

                try
                {
                    Console.WriteLine("введите число 1");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("введите число 2");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine("выберите операцию '*' '/' '+' '-'");
                action = Console.ReadLine();

                switch (action)
                {


                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("неизвестное действие");
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}
