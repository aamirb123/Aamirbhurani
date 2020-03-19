using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("please enter yor name");
            String UserName = Console.ReadLine();
            Console.WriteLine("Hello" +UserName);           //concatination method.
            Console.WriteLine("Hello {0}", UserName);       //by using placeholder method.
        }
    }
}
