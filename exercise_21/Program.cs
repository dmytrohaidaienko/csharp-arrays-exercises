using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_21
{

    /*
    Задание №21:
    Рассортируйте заданный линейный массив по возрастанию.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[] { 3, 0, -2, 44, 1, 19 };
            Int32 temp = 0;

            Console.WriteLine(" Your array: ");
            DisplayArray(in array);

            SortArray(ref array, ref temp);

            Console.WriteLine("\n Your sorted array: ");
            DisplayArray(in array);
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void SortArray(ref Int32[] array, ref Int32 temp)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                for (Int32 j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
