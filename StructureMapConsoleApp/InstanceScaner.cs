using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructureMapConsoleApp
{
    public class InstanceScaner : Registry
    {
        public InstanceScaner()
        {
            Scan(_ => {
                _.TheCallingAssembly();
                _.WithDefaultConventions();
            });

            For<WriterX>().Use<Writer>();       
        }
    }
}
