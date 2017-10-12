using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapConsoleApp
{
    public class Manager
    {
        private ILogger _logger;
        private WriterX _writer;
        public Manager(ILogger logger,WriterX writer)
        {
            _logger = logger;
            _writer = writer;            
        }

        public void ManagerWriter()
        {
            _logger.WriteHerePlease("Hi, How are you ?");
            Console.ReadKey();
        }

        public void WriteOnMyWallFromManager()
        {
            _writer.WriteOnMyWall("That's fine my friend");
            Console.ReadKey();
        }
    }
}
