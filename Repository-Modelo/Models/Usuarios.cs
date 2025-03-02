using Repository_Modelo.Complements;
using Repository_Modelo.Repository.Models;

namespace Repository_Modelo.Models
{
    public class Usuarios : GenericRepository<Users>, IUsuarios
    {
        public Usuarios(DbContext_Users dbContext) : base(dbContext) { }
    }
}
