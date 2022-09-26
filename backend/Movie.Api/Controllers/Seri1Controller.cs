using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Seri1Controller : ControllerBase
    {
        private readonly DataContext _dbContext;

        public Seri1Controller(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Seris1.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Seris1.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddSeriRequest1 addSeriRequest)
        {
            var post = new Seri1()
            {
                Name = addSeriRequest.Name,
                Minute = addSeriRequest.Minute,
                Url = addSeriRequest.Url,
                Category = addSeriRequest.Category,
                Year = addSeriRequest.Year,
                Country = addSeriRequest.Country,
                Trailer = addSeriRequest.Trailer,
                Age = addSeriRequest.Age,
                Starring = addSeriRequest.Starring,
                Creators = addSeriRequest.Creators,
                Explane = addSeriRequest.Explane,
                Imdb = addSeriRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Seris1.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateSeriRequest1 updateSeriRequest)
        {

            var existingPost = await _dbContext.Seris1.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateSeriRequest.Name;
                existingPost.Minute = updateSeriRequest.Minute;
                existingPost.Url = updateSeriRequest.Url;
                existingPost.Category = updateSeriRequest.Category;
                existingPost.Year = updateSeriRequest.Year;
                existingPost.Country = updateSeriRequest.Country;
                existingPost.Trailer = updateSeriRequest.Trailer;
                existingPost.Age = updateSeriRequest.Age;
                existingPost.Starring = updateSeriRequest.Starring;
                existingPost.Creators = updateSeriRequest.Creators;
                existingPost.Explane = updateSeriRequest.Explane;
                existingPost.Imdb = updateSeriRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Seris1.FindAsync(id);
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
