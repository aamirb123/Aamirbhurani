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
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
             parasMethod(Numbers);
//parasMethod();
 
           
        }
        public static void parasMethod( params int[] Numbers )
        {
            Console.WriteLine(" there are {0}   elements", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}
