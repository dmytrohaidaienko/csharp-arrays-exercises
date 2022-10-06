using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercise_17
{

    /*
    Задание 17:
    Найти сумму элементов массива вещественных чисел, имеющих нечетные номера. Размерность массива – 20. Заполнение массива осуществить случайными числами от 100 до 200. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[20];
            Int32 sum = 0;
            UInt32 counter = 1;

            FillArray(ref array);

            Console.WriteLine("Your array: ");
            DisplayArray(in array);

            FindSum(in array, ref sum, ref counter);
            Console.WriteLine("Sum of numbers having odd places: {0}", sum);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(100, 200);
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.WriteLine("Index: {0} | Element: {1}", i, array[i]);
        }

        static void FindSum(in Int32[] array, ref Int32 sum, ref UInt32 counter)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (counter % 2 != 0)
                    sum += array[i];
                counter++;
            }
        }
    }
}
