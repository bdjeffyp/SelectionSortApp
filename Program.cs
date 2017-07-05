using System;

namespace SelectionSortApp
{
    class Program
    {
        /*****************************
         * SelectionSortApp
         * Developer: Jeff Peterson
         * Version 0.2, 7/5/2017
         * Purpose: Take an array of random numbers and sort in ascending order
         * 
         * Fixed a bug with the algorithm by simplifying the process. Shows time it takes to sort.
         *****************************/
        static void Main(string[] args)
        {
            // Variables
            const int MAX_ARRAY_SIZE = 10000;
            int maxNumber = 10000;
            int[] numbers = new int[MAX_ARRAY_SIZE];
            Random randomizer = new Random();

            // TODO: Make the user enter the size of the array (with a limit)
            // TODO: Make user decide to ascend or descend sort

            // Title and purpose
            Console.WriteLine("Selection Sort Algorithm Demonstration");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nDisplay an array of 100 random numbers, sort the");
            Console.WriteLine("numbers, then display it sorted.\n");

            // Create the array of numbers.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomizer.Next(maxNumber);
            }

            // Display the array.
            Console.WriteLine("Unsorted:");
            DisplayArray(numbers);

            // Perform the selection sort.
            SelectionSort(numbers);

            // Display it again!
            //Console.WriteLine("Sorted:");
            //DisplayArray(numbers);
        }

        public static void DisplayArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (i == Array.Length - 1)
                {
                    Console.WriteLine("{0}", Array[i]);
                }
                else
                {
                    Console.Write("{0}, ", Array[i]);
                }
            }
            Console.WriteLine("\n");
        }

        public static void SelectionSort(int[] unsortedArray)
        {
            // Track how long it takes
            int begin = DateTime.Now.Millisecond;

            // Sort the values in the array by starting at the first index and comparing
            // to every other number. If a smaller number is found, swap!
            for (int i = 0; i < unsortedArray.Length - 1; i++)
            {
                for (int j = i + 1; j < unsortedArray.Length; j++)
                {
                    if (unsortedArray[j] < unsortedArray[i])
                    {
                        // Swap 'em! We found a smaller number!
                        int temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[j];
                        unsortedArray[j] = temp;
                    }
                }
            }

            // Now calculate how long it took and display it with the array.
            int end = DateTime.Now.Millisecond - begin;
            DisplayArray(unsortedArray);
            Console.WriteLine("Time to complete the sort: {0}ms\n", end);
        }
    }
}
