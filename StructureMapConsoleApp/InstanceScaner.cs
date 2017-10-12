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

            //For<WriterX>().Use<Writer>().Ctor<string>().Is("This is From Constructor");
            //For<WriterX>().Add<Writer2>();
            //For<WriterX>().Use(() => new Writer("By Lamda"));
            //For<WriterX>().Use(new Writer("Pre-Exitisting Object"));

            For<WriterX>().Add<Writer>().Ctor<string>().Is("This is From Constructor").Named("A");
            For<WriterX>().Add<Writer2>().Named("B");
            For<WriterX>().Use("A"); // makes Writer the default
            //For<WriterX>().Use("B"); // makes Writer2 the default

            For(typeof(WriterX)).Use(typeof(Writer2));
        }
    }
}
