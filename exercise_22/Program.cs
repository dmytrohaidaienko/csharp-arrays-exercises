using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_22
{

    /*
    Задание №22:
    Вычислить среднее арифметическое значение тех элементов одномерного массива, которые попадают в интервал от –2 до 10.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[10] { 1, -4, 6, 10, 7, -2, 5, 11, 93, 10 };
            Int32 sum = 0;
            Int32 amount = 0;
            UInt32 counter = 0;

            Console.WriteLine(" Your array: ");
            DisplayArray(in array, ref counter);

            FindSum(in array, ref sum, ref amount);
            Console.WriteLine("\n Sum of elements between -2 and 10: {0}", sum);
            Console.WriteLine(" Amount of elements: {0}", amount);

            Double average = (double)sum / amount;
            Console.WriteLine("Average of elements between -2 and 10: {0}", average);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindSum(in Int32[] array, ref Int32 sum, ref Int32 amount)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] > -2 && array[i] < 10)
                {
                    sum += array[i];
                    amount++;
                }
            }
        }
    }
}
