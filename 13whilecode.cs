using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter target");
            int UserName = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= UserName)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
