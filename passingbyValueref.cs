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
            simpleMethod(ref i);

            Console.WriteLine(i);
        }
        public static void simpleMethod( ref int j)
        {
            j = 101;
        }

    }
}
