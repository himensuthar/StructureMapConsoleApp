using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapConsoleApp
{
    public interface WriterX
    {
        void WriteOnMyWall(string text);
    }
    public class Writer : WriterX
    {
        public Writer(string str)
        {
            Console.WriteLine(str);
        }
        public void WriteOnMyWall(string text)
        {
            Console.WriteLine("Writer "  + text);
           
        }
    }

    public class Writer2 : WriterX
    {
        public void WriteOnMyWall(string text)
        {
            Console.WriteLine("Writer2 " + text);

        }
    }
    
}
