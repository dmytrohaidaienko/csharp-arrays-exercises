using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_13
{

    /*
    Задание №13:
    Дан линейный массив целых чисел. Проверьте, является ли он упорядоченным по убыванию. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] firstArray = { 5, 4, 3, 2, 1 };
            Int32[] secondArray = { 1, 3, 2, 4, 5 };

            UInt32 firstCounter = 0;
            UInt32 secondCounter = 0;

            String firstAnswer = "NuN";
            String secondAnswer = "NuN";

            Console.WriteLine(" First array: ");
            DisplayArray(in firstArray, ref firstCounter);

            Console.WriteLine("\n Second array");
            DisplayArray(in secondArray, ref secondCounter);

            CheckArray(in firstArray, ref firstAnswer);
            Console.WriteLine("\n Is first array sorted in descending order: {0}", firstAnswer);

            CheckArray(in secondArray, ref secondAnswer);
            Console.WriteLine(" Is second array sorted in descending order: {0}", secondAnswer);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void CheckArray(in Int32[] array, ref String answer)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    return;

                if (array[i] <= array[i + 1])
                {
                    answer = "No";
                    return;
                }
                else
                    answer = "Yes";
            }
        }
    }
}
