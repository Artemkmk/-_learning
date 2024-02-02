using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVodVobrPoradke
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
            for (int i = ElementsCount; i > 0; i--)
            {
                Console.WriteLine(massive[i-1]);
            }

            Console.ReadLine();
        }
    }
}
