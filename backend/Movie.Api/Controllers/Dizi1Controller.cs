using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dizi1Controller : ControllerBase
    {
        private readonly DataContext _dbContext;

        public Dizi1Controller(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Dizis1.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Dizis1.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddDiziRequest1 addDiziRequest)
        {
            var post = new Dizi1()
            {
                Name = addDiziRequest.Name,
                Minute = addDiziRequest.Minute,
                Url = addDiziRequest.Url,
                Category = addDiziRequest.Category,
                Year = addDiziRequest.Year,
                Country = addDiziRequest.Country,
                Trailer = addDiziRequest.Trailer,
                Age = addDiziRequest.Age,
                Starring = addDiziRequest.Starring,
                Creators = addDiziRequest.Creators,
                Explane = addDiziRequest.Explane,
                Imdb = addDiziRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Dizis1.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateDiziRequest1 updateDiziRequest)
        {

            var existingPost = await _dbContext.Dizis1.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateDiziRequest.Name;
                existingPost.Minute = updateDiziRequest.Minute;
                existingPost.Url = updateDiziRequest.Url;
                existingPost.Category = updateDiziRequest.Category;
                existingPost.Year = updateDiziRequest.Year;
                existingPost.Country = updateDiziRequest.Country;
                existingPost.Trailer = updateDiziRequest.Trailer;
                existingPost.Age = updateDiziRequest.Age;
                existingPost.Starring = updateDiziRequest.Starring;
                existingPost.Creators = updateDiziRequest.Creators;
                existingPost.Explane = updateDiziRequest.Explane;
                existingPost.Imdb = updateDiziRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Dizis1.FindAsync(id);
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
