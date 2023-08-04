using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_api.Models;
using Serilog;

namespace mvc_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {

        private readonly BlogContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public ArticleController(BlogContext context)
        { 
            _context= context;
        }

        // GET: api/Article
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticles()
        {
            return await _context.Articles.ToListAsync();
        }

        // Get: api/Article/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticles(long id)
        {
            var articles = await _context.Articles.FindAsync(id);

            if (articles == null) {
                return NotFound(); 
            }
            return articles; 
        }

        private bool ArticlesExists(long id) {
            return _context.Articles.Any(e => e.id == id);
        }

        // put: api/Article/{id}
        /// <summary>
        /// update specific article
        /// </summary>
        /// <param name="id"></param>
        /// <param name="articles"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticles(long id, Article articles) {
            if (id != articles.id) {
                return BadRequest();
            }

            //_context.Articles.Add(articles);

            _context.Entry(articles).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
                _context.ChangeTracker.DetectChanges();
                Log.Information(_context.ChangeTracker.DebugView.LongView);
            }catch (DbUpdateConcurrencyException) {
                if (!ArticlesExists(id))
                {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return new EmptyResult();
        }

        // post: api/article
        /// <summary>
        /// create article
        /// </summary>
        /// <param name="articles"></param>
        /// <returns></returns>
        /// <remarks>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Article>> PostArticles(Article articles) {
            _context.Articles.Add(articles);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetArticles", new { id = articles.id }, articles);
        }


        // Delete: api/Article/5
        /// <summary>
        /// delete article
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticles(long id)
        {
            var articles = await _context.Articles.FindAsync(id);
            if (articles == null) {
                return NotFound();
            }

            _context.Articles.Remove(articles);
            await _context.SaveChangesAsync();
            return new EmptyResult(); 
        }

    }
}
