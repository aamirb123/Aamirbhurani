using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forloop14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[3];
            Number[0] = 101;
            Number[1] = 102;
            Number[2] = 103;
            for (int i = 0; i <= Number.Length; i++)
            {
                Console.WriteLine(Number[i]);
            }
        }
    }
}
