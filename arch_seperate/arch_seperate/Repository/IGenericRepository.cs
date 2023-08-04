using arch_seperate.Models;

namespace arch_seperate.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T obj);
        
        void UpdateAsync(T obj);
        void DeleteAsync(T obj);
        bool ArticlesExists(object id);
        Task<T> GetAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task SaveChangesAsync();
    }
}
