using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PickFuncType
    {
        public static string GetMathType()
        {
            string output = RequestData.GetAString("Please press 'a' for addition, 's' for substitution, 'm' for multiplication, 'd' for division");
            return output;

        }
    }
}
