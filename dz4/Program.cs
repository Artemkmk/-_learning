using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint chet = 0, nechet = 0;
            int a, b, ChetSum=0, Nechetsum=0;
            Console.WriteLine("введите первое число диапазона");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число диапазона");
            b = int.Parse(Console.ReadLine());

            while (a!=b+1)
            {
                if (a % 2 == 0)
                {
                    ChetSum += a;
                    chet++;
                }
                else
                {
                    Nechetsum += a;
                    nechet++;
                }
                a++;
            }
            
            Console.WriteLine("чётных чсел " + chet + " нечётных чисел " + nechet);
            Console.WriteLine("сумма чётных чисел = " + ChetSum);
            Console.WriteLine("сумма нечётных чисел = " + Nechetsum);
            
        }
    }
}
