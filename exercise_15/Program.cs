using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_15
{

    /*
    Задание №15:
    Найти сумму четных элементов массива целых чисел. Размерность массива – 20. Заполнение массива осуществить случайными числами от 100 до 200. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[20];

            UInt32 counter = 0;
            Int32 sum = 0;

            FillArray(ref array);

            Console.WriteLine("Your array: ");
            DisplayArray(in array, ref counter);

            FindSum(in array, ref sum);
            Console.WriteLine($"Sum of elements: {sum}");
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(100, 200);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.WriteLine($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindSum(in Int32[] array, ref Int32 sum)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
        }
    }
}
