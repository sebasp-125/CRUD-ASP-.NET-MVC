using Microsoft.EntityFrameworkCore;
using Repository_Modelo.Complements;
using Repository_Modelo.Repository.Interfaces;

namespace Repository_Modelo.Repository.Models
{
    public class GenericRepository<T> : IRepositoy<T> where T : class
    {
        private readonly DbContext_Users _dbContext;

        public GenericRepository(DbContext_Users dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Create(T entidad)
        {
            try
            {
                await _dbContext.AddAsync(entidad);
                var changes = await _dbContext.SaveChangesAsync();
                return changes > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<T>> Get()
        {
            try
            {
                return await _dbContext.Set<T>().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Actualizar(T entidad)
        {
            try
            {
                Console.WriteLine("Enterting to Update!: ", entidad);
                _dbContext.Set<T>().Update(entidad);
                var AffectRows = await _dbContext.SaveChangesAsync();
                if (AffectRows > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteById(int id)
        {
            try
            {
                var entidad = await _dbContext.Set<T>().FindAsync(id);
                if (entidad == null) return false;

                _dbContext.Set<T>().Remove(entidad);
                var AffectedRows = await _dbContext.SaveChangesAsync();

                if (AffectedRows > 0) { return true; }

                return false;
            }
            catch
            {
                throw;
            }
        }
    }
}

