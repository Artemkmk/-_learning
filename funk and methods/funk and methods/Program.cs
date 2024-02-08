using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_and_methods
{
    internal class Program
    {

        static string[] stroka(int value_1, string value_2)
        {
            Console.WriteLine("функция запущена");

            string[] myArray = new string[value_1]; ;

            for (int i = 0; i < value_1; i++)
            {
                myArray[i] = value_2;
            }
            Console.WriteLine(string.Join(", ", myArray)); // Выводим содержимое массива
            return myArray;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("введите символ");
            string b = (Console.ReadLine());

            stroka(a, b);
            PrintLine("#",10);

            Console.ReadLine();
        }

        static void PrintLine(string value_1, int value_2) 
        { 
            for (int i = 0; i < value_2; i++)
            {
                Console.Write(value_1);
            }
        }
            
    }
}
