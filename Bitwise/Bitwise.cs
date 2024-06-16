using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Bitwise
{
    public class Bitwise
    {

        // Reset Ith Bit.
        /**
         * Reset means making a bit 0.
         * we can acchieve this by AND-ing Ith bit with 0;
         */
        public static int ResetIthBit(int num, int i)
        {
            Console.WriteLine("Before Reset " + num);
            Console.WriteLine("Mask Before Complement: " + (1 << (i - 1)));

            int mask = ~(1 << (i - 1));

            Console.WriteLine("Mask After Complement: " + mask);

            int afterReset = num & mask;

            return afterReset;
            //return (num & ((1 << (num - 1))));

        }

        public static string DecToBinary(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            string binary = "";
            while (number > 0)
            {
                binary = (number % 2).ToString() + binary;
                number /= 2;
            }

            return binary;
        }


        // Set Ith Bit
        /**
         *  Or with 1 = 1. so we can set a bit. 
         */
        public static int SetIthBit(int num, int i)
        {
            return (num | (i << i - 1));
        }



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
