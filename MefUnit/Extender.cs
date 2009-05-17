using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace MefUnit
{
    public class Extender
    {
        private DirectoryCatalog directoryCatalog;
        private DirectoryCatalog directoryCatalogExe;
        public void Compose()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            AssemblyCatalog assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());

            directoryCatalog = new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.dll");
            catalog.Catalogs.Add(directoryCatalog);

            directoryCatalogExe = new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.exe");
            catalog.Catalogs.Add(directoryCatalogExe);

            catalog.Catalogs.Add(assemblyCatalog);

            CompositionContainer container = new CompositionContainer(catalog);
            

            var batch = new CompositionBatch();
            batch.AddPart(this);
            container.Compose(batch);
        }

        public void Refresh()
        {
            directoryCatalog.Refresh();
            directoryCatalogExe.Refresh();
        }
    }
}