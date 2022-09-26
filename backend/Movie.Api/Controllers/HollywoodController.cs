using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HollywoodController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public HollywoodController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Hollywoods.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Hollywoods.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddHollywoodRequest addHollywoodRequest)
        {
            var post = new Hollywood()
            {
                Name = addHollywoodRequest.Name,
                Minute = addHollywoodRequest.Minute,
                Url = addHollywoodRequest.Url,
                Category = addHollywoodRequest.Category,
                Year = addHollywoodRequest.Year,
                Country = addHollywoodRequest.Country,
                Trailer = addHollywoodRequest.Trailer,
                Age = addHollywoodRequest.Age,
                Starring = addHollywoodRequest.Starring,
                Creators = addHollywoodRequest.Creators,
                Explane = addHollywoodRequest.Explane,
                Imdb = addHollywoodRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Hollywoods.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateHollywoodRequest updateHollywoodRequest)
        {

            var existingPost = await _dbContext.Hollywoods.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateHollywoodRequest.Name;
                existingPost.Minute = updateHollywoodRequest.Minute;
                existingPost.Url = updateHollywoodRequest.Url;
                existingPost.Category = updateHollywoodRequest.Category;
                existingPost.Year = updateHollywoodRequest.Year;
                existingPost.Country = updateHollywoodRequest.Country;
                existingPost.Trailer = updateHollywoodRequest.Trailer;
                existingPost.Age = updateHollywoodRequest.Age;
                existingPost.Starring = updateHollywoodRequest.Starring;
                existingPost.Creators = updateHollywoodRequest.Creators;
                existingPost.Explane = updateHollywoodRequest.Explane;
                existingPost.Imdb = updateHollywoodRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Hollywoods.FindAsync(id);
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
