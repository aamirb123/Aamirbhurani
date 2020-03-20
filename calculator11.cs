using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;

namespace Switchcase_Calculator
{
    class Program
    {
       static void Main(string[] args)
    {
        float result = 0;
        //Getting Input of First number
        Console.WriteLine("Enter first number");
        float num1 = float.Parse(Console.ReadLine());

        //Getting Input of second number
        Console.WriteLine("Enter second number");
        float num2 = float.Parse(Console.ReadLine());

        //Getting the math operator
        Console.WriteLine("Enter operator");
        string operation = Console.ReadLine();

        switch (operation) {

            case "+" : result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            case "%":
                result = num1 % num2;
                break;



        }
        Console.WriteLine("Result = " + result);


    }
  }
}
