using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_10
{

    /*
    Задание №10:
    Данные о температуре воды на Черноморском побережье за декаду сентября хранятся в массиве. Определить, сколько за это время было дней, пригодных для купания. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            String[] array = new String[10]
            {
                "Available",
                "Not Avaible",
                "Available",
                "Available",
                "Not Avaible",
                "Available",
                "Not Avaible",
                "Not Avaible",
                "Available",
                "Not Avaible"
            };

            UInt32 firstCounter = 0;
            UInt32 secondCounter = 0;
            UInt32 dayCounter = 1;

            Console.WriteLine("Array: ");
            DisplayArray(in array, ref firstCounter, ref dayCounter);

            CheckDay(in array, ref secondCounter);
            Console.WriteLine("\nDays with available temperature of water: {0}", secondCounter);
        }

        static void DisplayArray(in String[] array, ref UInt32 firstCounter, ref UInt32 dayCounter)
        {
            if (firstCounter >= array.Length)
                return;

            Console.WriteLine("Day {0}: {1}", dayCounter, array[firstCounter]);
            firstCounter++;
            dayCounter++;
            DisplayArray(in array, ref firstCounter, ref dayCounter);
        }

        static void CheckDay(in String[] array, ref UInt32 secondCounter)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] == "Available")
                    secondCounter++;
            }
        }
    }
}
