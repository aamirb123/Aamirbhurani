using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)

        {
            int i = 0;
            simpleMethod(i);

            Console.WriteLine(i);
        }
        public static void simpleMethod(int j)
        {
            j = 101;
        }

    }
}
