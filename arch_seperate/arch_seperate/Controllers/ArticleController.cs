using arch_seperate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using arch_seperate.Repository;

namespace arch_seperate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticles(){
            return new ActionResult<IEnumerable<Article>>(await _articleRepository.GetAllAsync());
         }

        // get data with specific id
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticles(long id) {
            var articles = await _articleRepository.GetAsync(id);
            if (articles == null) {
                return NotFound();
            }
            return articles;
        }

        // update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticles(long id, Article articles)
        {
            if (id != articles.id) 
            {
                return BadRequest();
            }

            _articleRepository.UpdateAsync(articles);

            try
            {
                await _articleRepository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_articleRepository.ArticlesExists(id))
                {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return StatusCode(200);
        }

        // add
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Article>> PostArticles(Article articles) {
            _articleRepository.Create(articles);
            await _articleRepository.SaveChangesAsync();
            return CreatedAtAction("GetArticles", new { id = articles.id }, articles);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticles(int id)
        {
            var articles = await _articleRepository.GetAsync(id);
            if (articles == null)
            {
                return NotFound();
            }

            _articleRepository.DeleteAsync(articles);

            await _articleRepository.SaveChangesAsync();
            return NoContent();
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
