using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сумма_и_произведение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, sum, mult;
            Console.WriteLine("введите первое число");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите третье число");
            c = double.Parse(Console.ReadLine());
            sum = a + b + c;
            mult = a * b * c;

            Console.WriteLine("сумма = " + sum);
            Console.WriteLine("произведение = " + mult);
        }
    }
}
