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
            int total=0;
            int product=0;
            calculator(10, 20, out total, out product);

            Console.WriteLine("sum={0} && product {1}", total, product);
           
        }
        public static void calculator( int FN, int SN, out int sum,out int product)
        {
            sum= FN + SN;
            product = FN * SN;
        }

    }
}
