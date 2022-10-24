using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_24
{

    /*
    Задание №24:
    Вычислить сумму четных элементов одномерного массива до первого встреченного нулевого элемента.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[] { 2, 1, 9, 6, 10, 0, 5, 1 };
            UInt32 counter = 0;
            Int32 sum = 0;

            Console.WriteLine(" Array: ");
            DisplayArray(in array, ref counter);

            FindSum(in array, ref sum);
            Console.WriteLine("\n Sum: {0}", sum);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindSum(in Int32[] array, ref Int32 sum)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    return;
                else if (array[i] % 2 == 0)
                    sum += array[i];
                else
                    continue;
            }
        }
    }
}
