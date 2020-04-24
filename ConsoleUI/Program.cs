using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create console application that handles calculations

            UserMessages.PrintMessage("Hello, welcome to my calculator!");

            string type = PickFuncType.GetMathType();
            Console.WriteLine();

            double x = RequestData.GetADouble("Please enter the first number: ");
            double y = RequestData.GetADouble("Please enter the second number: ");

            DataCalc.DoTheMath(type, x, y);
            Console.ReadLine();
        }
    }
}
