using System;
using Topshelf;

namespace StructureMapConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x=> 
            {
                x.Service<MyTopShelfService>(s => 
                {
                    s.ConstructUsing(name => new MyTopShelfService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.SetDescription("Demo Using TopShelf and StructureMap");
                x.SetDescription("TopShelf and StructureMap Demo");
                x.SetServiceName("TopShelfandStructureMapDemo");
            });
        }
    }
}
