using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Strings
{
    public   class String
    {
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);

         
        }
    }


}
