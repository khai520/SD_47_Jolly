using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace API.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DBAppContext>
    {
        public DBAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBAppContext>();

            optionsBuilder.UseSqlServer("Server=.;Database=Jolly;Trusted_Connection=True;TrustServerCertificate=True;");

            return new DBAppContext(optionsBuilder.Options);
        }
    }
}
