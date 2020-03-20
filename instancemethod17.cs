using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace instancemethod17
{
    class Program
    {
        static void Main()
        {
            Program.EvenNumber(30);

            Program p = new Program();
            int sum = p.Add(10, 20);
            Console.WriteLine("sum = {0}", sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public static void EvenNumber(int Target)
        {
            int start = 0;
            while (start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }

        }
    }
}

