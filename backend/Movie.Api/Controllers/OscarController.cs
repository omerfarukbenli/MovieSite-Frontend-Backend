using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OscarController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public OscarController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Oscars.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Oscars.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddOscarRequest addOscarRequest)
        {
            var post = new Oscar()
            {
                Name = addOscarRequest.Name,
                Minute = addOscarRequest.Minute,
                Url = addOscarRequest.Url,
                Category = addOscarRequest.Category,
                Year = addOscarRequest.Year,
                Country = addOscarRequest.Country,
                Trailer = addOscarRequest.Trailer,
                Age = addOscarRequest.Age,
                Starring = addOscarRequest.Starring,
                Creators = addOscarRequest.Creators,
                Explane = addOscarRequest.Explane,
                Imdb = addOscarRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Oscars.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateOscarRequest updateOscarRequest)
        {

            var existingPost = await _dbContext.Oscars.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateOscarRequest.Name;
                existingPost.Minute = updateOscarRequest.Minute;
                existingPost.Url = updateOscarRequest.Url;
                existingPost.Category = updateOscarRequest.Category;
                existingPost.Year = updateOscarRequest.Year;
                existingPost.Country = updateOscarRequest.Country;
                existingPost.Trailer = updateOscarRequest.Trailer;
                existingPost.Age = updateOscarRequest.Age;
                existingPost.Starring = updateOscarRequest.Starring;
                existingPost.Creators = updateOscarRequest.Creators;
                existingPost.Explane = updateOscarRequest.Explane;
                existingPost.Imdb = updateOscarRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Oscars.FindAsync(id);
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
