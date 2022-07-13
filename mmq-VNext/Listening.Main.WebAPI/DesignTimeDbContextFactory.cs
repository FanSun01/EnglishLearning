using CommonInitializer;
using Microsoft.EntityFrameworkCore.Design;

namespace Listening.Main.WebAPI
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ListeningDbContext>
    {
        public ListeningDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = DbContextOptionsBuilderFactory.Create<ListeningDbContext>();
            return new ListeningDbContext(optionsBuilder.Options, null);
        }
    }
}
