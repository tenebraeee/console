using System;
using System.Text;
using System.Threading;

namespace Function
{
    public class FunctionHandler
    {
        public string Handle(string input) 
        {
            Thread.Sleep(1000 * 15);

            return $"Hi there - your input was: {input}\n";
        }
    }
}
