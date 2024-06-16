using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Bitwise
{
    public class Bitwise
    {
        // Find Unique (non repeating number) in an arary
        public static int Unique(int[] arr)
        {
            int unique = 0;

            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine("Before " + i + " " + unique);
                unique ^= arr[i];
                Console.WriteLine("After " + i + " " + unique);

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
