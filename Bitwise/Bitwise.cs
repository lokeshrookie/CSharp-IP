using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Bitwise
{
    public class Bitwise
    {
        // Find ith bit of a number
        /*
         *  let number is 10 => (1010).
         *  
         *  if i = 1, as 1st number from the rigt(lsb) is 1, we wil get the place value of i. here it is 2.
         *  if i = 3, as 3rd number from the right(lsb) is 3, we wil get the place value of i. here it is 8.
         *  
         */
        public static int FindIthBit(int num, int n)
        {
            //  num is the given number.
            // n is no.of times we need to left shift.
            return (num & (1 << (n-1))); 
        }


        // Find Unique (non repeating number) in an arary
        public static int Unique(int[] arr)
        {
            int unique = 0;

            for(int i = 0; i<arr.Length; i++)
            {
                unique ^= arr[i];
            }

            return unique;
        }


        // returns true if n is odd. Else, false will be returned.
        public static bool IsOdd(int n)
        {
            if((n&1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
