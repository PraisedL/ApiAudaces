using ApiAudaces.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAudaces.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ApiModel> Calls { get; set; }
    }
}
