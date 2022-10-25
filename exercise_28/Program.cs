using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_28
{

    /*
    Задание №28:
    Если в одномерном массиве имеются три подряд идущих одинаковых элемента, то переменной r присвоить значение истина.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] firstArray = new Int32[] { 8, 6, 2, 2, 2, 5, 1 };
            Int32[] secondArray = new Int32[] { 9, 6, 4, 3, 2, 5, 0 };

            Boolean firstR = false;
            Boolean secondR = false;

            Console.WriteLine(" First array: ");
            DisplayArray(in firstArray);
            CheckArray(in firstArray, ref firstR);
            Console.WriteLine("\n Check: {0}", firstR);

            Console.WriteLine("\n Second array: ");
            DisplayArray(in secondArray);
            CheckArray(in secondArray, ref secondR);
            Console.WriteLine("\n Check: {0}", secondR);

        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void CheckArray(in Int32[] array, ref Boolean r)
        {
            for (Int32 i = 1; i < array.Length - 2; i++)
            {
                if (array[i - 1] == array[i] && array[i] == array[i + 1])
                    r = true;
            }
        }
    }
}
