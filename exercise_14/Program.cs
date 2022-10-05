using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_14
{

    /*
    Задание №14:
    Найти сумму положительных элементов линейного массива целых чисел. Размерность массива – 10. Заполнение массива осуществить с клавиатуры. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[10];

            UInt32 firstCounter = 0;
            UInt32 secondCounter = 0;

            Int32 sum = 0;

            Console.WriteLine(" Lets fill ur array, enter {0} elemets in array: ", array.Length);
            FillArray(ref array, ref firstCounter);

            Console.WriteLine(" Your array with {0} element: ", array.Length);
            DisplayArray(in array, ref secondCounter);

            FindSum(in array, ref sum);
            Console.WriteLine($"\n Sum of all positive element in array: {sum}");
        }

        static void FillArray(ref Int32[] array, ref UInt32 firstCounter)
        {
            if (firstCounter >= array.Length)
                return;

            Console.WriteLine("Please, enter your {0} element of array", firstCounter + 1);
            array[firstCounter] = Int32.Parse(Console.ReadLine());
            firstCounter++;

            FillArray(ref array, ref firstCounter);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 secondCounter)
        {
            if (secondCounter >= array.Length)
                return;

            Console.Write($" {array[secondCounter]} ");
            secondCounter++;

            DisplayArray(in array, ref secondCounter);
        }

        static void FindSum(in Int32[] array, ref Int32 sum)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    sum += array[i];
            }
        }
    }
}
