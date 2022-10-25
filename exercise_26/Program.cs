using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_26
{

    /*
    Задание №26:
    Подсчитайте количество элементов одномерного массива, которые совпадают со своим номером (индексом).
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[] { 0, 3, 2, 1, 6, 5, 7, 9 };
            UInt32 displayCounter = 0;
            UInt32 counter = 0;

            Console.WriteLine(" Your array: ");
            DisplayArray(in array, ref displayCounter);

            FindAccordance(in array, ref counter);
            Console.WriteLine("\n Amount of elements which equal to their indexes: {0}", counter);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 displayCounter)
        {
            if (displayCounter >= array.Length)
                return;

            Console.Write($" {array[displayCounter]} ");
            displayCounter++;

            DisplayArray(in array, ref displayCounter);
        }

        static void FindAccordance(in Int32[] array, ref UInt32 counter)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                    counter++;
            }
        }
    }
}
