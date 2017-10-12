using StructureMap;


namespace StructureMapConsoleApp
{
    class MyTopShelfService
    {
        public void Start()
        {
            #region Create an Container

            #region Create an container instance and directly pass in the configuration
            //var application = new Container(_ =>
            //{
            //    _.For<StructureMapConsoleApp.ILogger>().Use<StructureMapConsoleApp.Logger>();
            //    _.For<StructureMapConsoleApp.WriterX>().Use<StructureMapConsoleApp.Writer>();
            //});
            #endregion

            #region Create an container instance but add configuration later.
            //var application = new Container();
            //application.Configure(_=> 
            //{
            //    _.For<StructureMapConsoleApp.ILogger>().Use<StructureMapConsoleApp.Logger>();
            //    _.For<StructureMapConsoleApp.WriterX>().Use<StructureMapConsoleApp.Writer>();
            //});
            #endregion

            #region Create an container with Registry DSL
            //var application = new Container(new InstanceScaner());
            //var application = new Container(_=> { _.AddRegistry<InstanceScaner>(); });
            //var application = Container.For<InstanceScaner>();
            #endregion

            #region Create an container with scan

            #region Example1
            //var application = new Container(_=> _.Scan(scanner=> {
            //    scanner.TheCallingAssembly();
            //    scanner.WithDefaultConventions();
            //}));

            //application.Configure(_=> {
            //    _.For<WriterX>().Use<Writer>();
            //});
            #endregion

            #region Example2

            var application = new Container();
            application.Configure(_ => {
                _.Scan(scanner =>
                {
                    scanner.TheCallingAssembly();
                    scanner.WithDefaultConventions();
                });

                //Supply value in constructor
                _.For<WriterX>().Use<Writer>().Ctor<string>().Is("This is From Constructor");
            });

            
            #endregion Example2

            #endregion

            #endregion Create an Container

            #region Create a Instance using container
            var managerInstance = application.GetInstance<Manager>();
            managerInstance.ManagerWriter();
            managerInstance.WriteOnMyWallFromManager();
            #endregion Create a Instance using container

        }

        public void Stop()
        {

        }
    }
}
