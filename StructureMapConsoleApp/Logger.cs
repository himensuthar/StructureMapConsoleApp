using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapConsoleApp
{
    public class Logger : ILogger
    {
        public void WriteHerePlease(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("I am fine");
            
        }
    }
}
