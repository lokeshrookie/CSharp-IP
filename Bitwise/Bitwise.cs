using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Turorial.Bitwise
{
    public class Bitwise
    {

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
