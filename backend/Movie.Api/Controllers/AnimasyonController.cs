using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimasyonController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public AnimasyonController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Animasyons.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Animasyons.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddAnimasyonRequest addAnimasyonRequest)
        {
            var post = new Animasyon()
            {
                Name = addAnimasyonRequest.Name,
                Minute = addAnimasyonRequest.Minute,
                Url = addAnimasyonRequest.Url,
                Category = addAnimasyonRequest.Category,
                Year = addAnimasyonRequest.Year,
                Country = addAnimasyonRequest.Country,
                Trailer = addAnimasyonRequest.Trailer,
                Age = addAnimasyonRequest.Age,
                Starring = addAnimasyonRequest.Starring,
                Creators = addAnimasyonRequest.Creators,
                Explane = addAnimasyonRequest.Explane,
                Imdb = addAnimasyonRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Animasyons.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateAnimasyonRequest updateAnimasyonRequest)
        {

            var existingPost = await _dbContext.Animasyons.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateAnimasyonRequest.Name;
                existingPost.Minute = updateAnimasyonRequest.Minute;
                existingPost.Url = updateAnimasyonRequest.Url;
                existingPost.Category = updateAnimasyonRequest.Category;
                existingPost.Year = updateAnimasyonRequest.Year;
                existingPost.Country = updateAnimasyonRequest.Country;
                existingPost.Trailer = updateAnimasyonRequest.Trailer;
                existingPost.Age = updateAnimasyonRequest.Age;
                existingPost.Starring = updateAnimasyonRequest.Starring;
                existingPost.Creators = updateAnimasyonRequest.Creators;
                existingPost.Explane = updateAnimasyonRequest.Explane;
                existingPost.Imdb = updateAnimasyonRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Animasyons.FindAsync(id);
            if (existingPost != null)
            {
                _dbContext.Remove(existingPost);
                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
    }
}
