namespace arch_seperate.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public bool ArticlesExists(object id)
        {
            throw new NotImplementedException();
        }

        public void Create(T obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
