using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods16
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();  //instance method format
            p.EvenNumber();

        }
        public void EvenNumber()     ///public method declaration
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
