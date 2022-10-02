using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_7
{

    /*
    Задание №7:
    Создайте целочисленный массив А[1..15] с помощью генератора случайных чисел с элементами от –15 до 30 и выведите его на экран. Определите самый большой элемент массива и его индекс.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[15];
            UInt32 firstCounter = 0;

            FillArray(ref array);
            DisplayArray(in array, ref firstCounter);

            Int32 maxElement = array.Max();
            Console.WriteLine("\n The biggest element of array: " + maxElement);

            Console.ReadLine();
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-15, 30);
            }
        }

        static void DisplayArray(in Int32[] array, ref UInt32 firstCounter)
        {
            if (firstCounter >= array.Length)
                return;

            Console.Write($" {array[firstCounter]} ");

            firstCounter++;
            DisplayArray(in array, ref firstCounter);
        }
    }
}
