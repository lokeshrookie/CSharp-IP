using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
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
    internal class Bubble
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            Console.WriteLine( string.Join(" ", arr));
            //Bubble(arr);
            Insertion(arr);
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
               // Inside the outer loop, the inner loop
               // iterates through the array, comparing adjacent elements. The upper bound of the inner
               // loop is adjusted by i + 1 in each pass. This is because with each pass, the largest
               // element bubbles to the end, reducing the unsorted portion of the array.

                for (int j = 0; j<arr.Length-1-i; j++) // Upper bound reduced by i+1 in each pass
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                    }
                }
            }
        }


        // Swap Falg Bubble Sort

        public static void SwapFlagBubble(int[] arr)
        {
            for(int i = 0; i<arr.Length - 1; i++)
            {
                bool swapped = false;
                for(int j = 0; j<arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, i, j);
                        swapped = true;
                    }

                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }



        /*  SELECTION SORT
         *  
         *  1. For every iteration, find max element and put it in the last index.
         *  2. swap both.
         *  
         *  */

        public static void Selection(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                int last = arr.Length - i-1;
                int max = FindMax(arr, 0, last);
                Swap(arr, max, last);

            }
        } 

        public static int FindMax(int[] arr, int first, int last)
        {
            int max = first;
            for(int i = first; i<=last; i++)
            {
                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }
            return max;
        }


        /*  INSERTION SORT */
        /**
     * Insertion sort:
     *  Start with the second element as the key.
     * Compare the key with elements in the sorted portion (elements to the left of the key).
     * Shift elements to the right until finding the correct position for the key.
     * Insert the key at the correct position.
     * Repeat for all elements in the array
     * @param arr
     */
        public static void Insertion(int[] arr)
        {
            for(int i =0 ; i<arr.Length-1; i++)
            {
                for(int j = i+1; j>0; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        Swap(arr, j - 1, j);
                    }
                }
            }
        }
    }
}
