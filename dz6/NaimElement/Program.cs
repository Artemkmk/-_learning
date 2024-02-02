using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaimElement
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


            int a = massive[0];

            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i] < a) 
                {
                    a=massive[i];
                }
                
            }
            Console.Write("\nнаименьший элемент массива: ");
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
