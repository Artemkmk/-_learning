using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treugolnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите высоту треугольника");
            int height=int.Parse(Console.ReadLine());
             for (int i = 0; i < height; i++) 
             { 
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("#");
                 }
                 Console.WriteLine();
             }
 
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i ; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }  


            for (int i = 11; i > 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                    
                }

                for (int k = 12; k > i; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 11; i > 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                for (int j = 12; j > i; j--)
                {
                    Console.Write(" ");

                }

                
            }
            Console.ReadLine();

        }


    }
}
