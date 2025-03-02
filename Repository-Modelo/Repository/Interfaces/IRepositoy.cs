namespace Repository_Modelo.Repository.Interfaces
{
    public interface IRepositoy<T> where T : class
    {
        Task<List<T>> Get();
        Task<bool> Create(T Entidad);
        Task<bool> Actualizar(T entidad);
        Task<bool> DeleteById(int id);
    }
}

