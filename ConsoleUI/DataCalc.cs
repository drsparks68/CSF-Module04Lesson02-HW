using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class DataCalc
    {
        public static void DoTheMath(string type, double y, double x)
        {
            if (type == "a")
            {
                double result = CalculateType.Add(x, y);
                UserMessages.PrintMessage($"{ x } plus { y } equals { result }.");
            }
            else if (type == "s")
            {
                double result = CalculateType.Subtract(x, y);
                UserMessages.PrintMessage($"{ x } minus { y } equals { result }.");
            }
            else if (type == "m")
            {
                double result = CalculateType.Multiply(x, y);
                UserMessages.PrintMessage($"{ x } multiplied by { y } equals { result }.");
            }
            else if (type == "d")
            {
                double result = CalculateType.Divide(x, y);
                UserMessages.PrintMessage($"{ x } divided by { y } equals { result }.");
            }
        }
    }
}
