using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operators_5
{
    class Program
    {
        static void Main()
        {
            int numerator = 10;
            int denominator = 5;
            int result = numerator / denominator;   // it divide the result and give them quietient
            int result1 = numerator % denominator;  // it gives us reminder

            Console.WriteLine("result {0}", result);
            Console.WriteLine("result1 {0}", result1);


        }
    }
}
