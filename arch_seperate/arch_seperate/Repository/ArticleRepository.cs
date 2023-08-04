using arch_seperate.Models;
using Microsoft.EntityFrameworkCore;

namespace arch_seperate.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly BlogContext _context;

        public ArticleRepository(BlogContext context)
        {
            _context = context;
        }

        public async void Create(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
        }

        public async void DeleteAsync(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException("article is null, not found");
            }
            else
            {
                _context.Entry(article).State = EntityState.Deleted;
                await SaveChangesAsync();
            }
        }

        public async Task<Article> GetAsync(long id) {
            return await _context.Articles.FindAsync(id);
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async void UpdateAsync(Article article)
        {
            _context.Entry(article).State = EntityState.Modified;
            await SaveChangesAsync();
        }
        public bool ArticlesExists(long id)
        {
            return _context.Articles.Any(e => e.id == id);
        }


    }
}
