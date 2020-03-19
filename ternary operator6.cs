using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ternary_operator
{
    class Program
    {
        static void Main()
        {
            int Num = 13;
            bool IsNum;

            bool IsNum1 = Num == 10 ? true : false;  // ternary operator replace by ifelse statements so itvreduces a block of code.
            Console.WriteLine(" Num==10 is{0}", IsNum1);
        }
    }
}
