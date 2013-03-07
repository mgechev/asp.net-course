using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an array: ");
            string nums = Console.ReadLine();
            int[] array = GetArray(nums);
            QuickSort(array, 0, array.Length - 1);
            Console.Write("The sorted array is: ");
            PrintArray(array);
            Console.WriteLine();
        }

        /// <summary>
        /// Basic implementation of Quick sort
        /// </summary>
        /// <param name="array">The array which should be sorted.</param>
        /// <param name="left">The left bound for the current call.</param>
        /// <param name="right">The right bound for the current call.</param>
        static void QuickSort(int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2],
                oldLeft = left,
                oldRight = right;

            while (left <= right)
            {
                while (pivot > array[left])
                    left += 1;
                while (pivot < array[right])
                    right -= 1;
                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left += 1;
                    right -= 1;
                }
            }

            if (oldLeft < left - 1)
                QuickSort(array, oldLeft, left - 1);
            if (oldRight > left)
                QuickSort(array, left, oldRight);
        }

        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="array">The array.</param>
        static void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
        }

        /// <summary>
        /// Gets int array from space separated string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns></returns>
        static int[] GetArray(string input)
        {
            string[] nums = input.Split(' ');
            int[] array = new int[nums.Length];
            for (var i = 0; i < nums.Length; i += 1)
            {
                int current;
                Int32.TryParse(nums[i], out current);
                array[i] = current;
            }
            return array;
        }
    }
}
