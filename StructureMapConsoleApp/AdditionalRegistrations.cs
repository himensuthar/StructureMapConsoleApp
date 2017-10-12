using StructureMap;

namespace StructureMapConsoleApp
{
    class AdditionalRegistrations:Registry
    {
        public AdditionalRegistrations()
        {
            For<WriterX>().Add<Writer2>();
            For<WriterX>().Add(() => new Writer(""));

            Writer wrObject = new StructureMapConsoleApp.Writer("Hi,I am Pre exisitng object");
            For<WriterX>().Add(wrObject);

           //What is AddInstance
            //For<WriterX>().AddInstances();

        }
    }
}
