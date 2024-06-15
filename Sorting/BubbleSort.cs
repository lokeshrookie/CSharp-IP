using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Sorting
{

    /**
     * 1. Outer loop iterates n times. 
     * 2. Inner loop starts from second(1st index) element. 
     * 3. For every index, it compares its previous element. If prev > current, swap both.
     */
    internal class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            Console.WriteLine( string.Join(" ", arr));
            //Bubble(arr);
            ShortBubble(arr);
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

        /** Short Bubble Optimization:
         * This optimization leverages the fact that with each pass, the largest element bubbles to the end.
         * So, we can progressively reduce the inner loop's upper bound in subsequent passes. Here's the modified code:
         */
        public static void ShortBubble(int[] arr)
        {
            for(int i = 0; i<arr.Length-1; i++)
            {
                for(int j = 0; j<arr.Length-1-i; j++) // Upper bound reduced by i+1 in each pass
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
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
