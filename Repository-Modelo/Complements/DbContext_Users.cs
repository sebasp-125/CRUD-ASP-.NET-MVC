using Microsoft.EntityFrameworkCore;
using Repository_Modelo.Models;
namespace Repository_Modelo.Complements
{
    public class DbContext_Users : DbContext
    {
        public DbContext_Users(DbContextOptions<DbContext_Users> options) : base(options) { }

        public DbSet<Users> Usuarios { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Shooping> Shoopings { get; set; }



    }
}
