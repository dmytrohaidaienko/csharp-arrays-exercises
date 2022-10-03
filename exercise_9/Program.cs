using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_9
{

    /*
    Задание №9:
    Данные о температуре воздуха за декаду ноября хранятся в массиве. Определить, сколько раз температура опускалась ниже –10 градусов.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[10];
            UInt32 firstCounter = 0;
            UInt32 secondCounter = 0;

            FillArray(ref array);

            Console.WriteLine(" Your array decade of November: ");
            DisplayArray(in array, ref firstCounter);

            CheckDay(in array, ref secondCounter);
            Console.WriteLine("\n How many times tempereture falls below -10? It was {0} times.", secondCounter);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);
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

        static void CheckDay(in Int32[] array, ref UInt32 secondCounter)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] < -10)
                    secondCounter++;
            }
        }
    }
}
