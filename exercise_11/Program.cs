using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{

    /*
    Задание №11:
    Данные о температуре воздуха за декаду декабря хранятся в массиве. Определить, сколько раз температура была выше средней за эту декаду.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[10];
            UInt32 counter = 0;
            UInt32 temperatureCounter = 0;

            FillArray(ref array);

            Console.WriteLine(" Array of temperature: ");
            DisplayArray(in array, ref counter);

            CountTemperature(in array, ref temperatureCounter);
            Console.WriteLine(" How many times the temperature was above the average for this decade: {0}", temperatureCounter);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(-15, 5);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void CountTemperature(in Int32[] array, ref UInt32 temperatureCounter)
        {
            Int32 sum = 0;

            for (Int32 i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Int32 meanArray = sum / array.Length;

            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] > meanArray)
                    temperatureCounter++;
            }

            Console.WriteLine("\n Mean of array: {0}", meanArray);
        }
    }
}
