using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Arrays
{
    internal class Arrays
    {
        public static void Main(string[] args)
        {
           int[] arr = { 5, 4, 3, 2, 1 };

           // arr = arr.OrderBy(x=> x);
            // this won't work becuase IEnumerable cant cast to Array type.
            
           Console.WriteLine(string.Join(",", arr.OrderBy(x => x)) );
           IEnumerable<int> arr2 = arr.OrderBy(s => s);

           Console.WriteLine(string.Join(",", arr2));

        //    // GET - based on Index.
        //    Console.WriteLine(arr[0]);
        //    Console.WriteLine(arr.GetValue(0));

        //    // GET - All Array elements
        //    Console.WriteLine(string.Join(" ", arr)); // space(" ") is delimiter between array elements.

        //    // GET All - by using LINQ
        //    Console.WriteLine(string.Join(" ", arr.Select(x => x)));

        }
    }
}
