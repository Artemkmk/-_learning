using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumChetChisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество элементов массива:\t");

            int ElementsCount = int.Parse(Console.ReadLine());
            int[] massive = new int[ElementsCount];

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"\nвведите элемент массива под индексом {i}:\t ");
                massive[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\nвывод массива:");
            int sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 == 0)
                {
                    sum = sum + massive[i];
                }
                    
                Console.WriteLine(massive[i]);
            }
            Console.Write("\nсумма чётных чисел: ");
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
