using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funk_and_methods2
{
    internal class Program
    {

        static int IndexOf(int value, int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();

            for (int i = 0;i < length; i++)
            {
                myArray[i]= random.Next(minValue, maxValue); 
            }
            return myArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);

            Console.Write("введите индекс который хотите найти:\t");
            int FoundIndex = int.Parse(Console.ReadLine());

            int result = IndexOf(FoundIndex, myArray);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
