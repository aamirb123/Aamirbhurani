using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nullabletype
{
    class Program
    {
        static void Main()
        {
            bool? AreYouMajor = null;
            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (!AreYouMajor.Value)
            {
                Console.WriteLine("User is not Major");
            }

            else
            {
                Console.WriteLine("User is not answer your question");
            }
        }
    }
}
