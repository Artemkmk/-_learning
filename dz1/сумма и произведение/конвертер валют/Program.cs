using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace конвертер_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 96.63;
            double USD;
            Console.WriteLine("введите кол-во USD");
            USD=double.Parse(Console.ReadLine());
            double RUB=USD*UsdToRub;
            Console.WriteLine("кол-во RUB "+RUB);

        }
    }
}
