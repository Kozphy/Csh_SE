using arch_seperate.Models;
using Microsoft.AspNetCore.Mvc;

namespace arch_seperate.Repository
{
    public interface IArticleRepository
    {
        void Create(Article article);
        void UpdateAsync(Article article);
        void DeleteAsync(Article article);
        bool ArticlesExists(long id);
        Task<Article> GetAsync(long id);
        Task<IEnumerable<Article>> GetAllAsync();
        Task SaveChangesAsync();

    }
}
