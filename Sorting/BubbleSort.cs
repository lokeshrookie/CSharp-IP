using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Sorting
{

    /**
     * 1. Outer loop iterates all elements 
     * 2. inner loop compares 
     */
    internal class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            Console.WriteLine( string.Join(" ", arr));
            Bubble(arr);
            Console.WriteLine(string.Join(" ", arr));


        }

        public static void Bubble(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
