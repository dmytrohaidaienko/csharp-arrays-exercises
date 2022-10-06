using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_16
{

    /*
    Задание №16:
    Найти произведение элементов массива целых чисел, которые кратны 7. Размерность массива – 15. Заполнение массива осуществить случайными числами от 10 до 50. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[15];

            UInt32 counter = 0;

            Int32 multiply = 1;

            FillArray(ref array);

            Console.WriteLine(" Your array: ");
            DisplayArray(in array, ref counter);

            Console.WriteLine("\n\n Checking elements: ");
            FindMultiply(in array, ref multiply);
            Console.WriteLine("\n Multiply of elements: {0}", multiply);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 50);
            }
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindMultiply(in Int32[] array, ref Int32 multiply)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.Write($" Element {array[i]} is ");
                Console.WriteLine((array[i] % 7 == 0) ? "Multiply" : "Not multiply");

                if ((array[i] % 7 == 0))
                    multiply *= array[i];
            }
        }
    }
}
