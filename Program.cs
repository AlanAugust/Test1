using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10; 
            int[] array = new int[size];

            var currArray = CreateRandomaArray(array);
            DisplayArray(currArray);
            currArray = BubbleSort(currArray);
            DisplayArray(currArray);
        }

        static int[] CreateRandomaArray(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
            }
            return array;
        }


        static int[] BubbleSort(int[] array)
        {
            int current;
            for (int i = 0; i < array.Length - 1; i++)
            {
               
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        current = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = current;
                    }
                }
            }
            return array;
        }

        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
