using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("введите первое число");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            b = double.Parse(Console.ReadLine());
            c = (a + b) / 2;
 
            Console.WriteLine("среднее арефметическое двух чисел = " + c);

        }
    }
}
