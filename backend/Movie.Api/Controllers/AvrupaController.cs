using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvrupaController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public AvrupaController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Avrupas.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Avrupas.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddAvrupaRequest addAvrupaRequest)
        {
            var post = new Avrupa()
            {
                Name = addAvrupaRequest.Name,
                Minute = addAvrupaRequest.Minute,
                Url = addAvrupaRequest.Url,
                Category = addAvrupaRequest.Category,
                Year = addAvrupaRequest.Year,
                Country = addAvrupaRequest.Country,
                Trailer = addAvrupaRequest.Trailer,
                Age = addAvrupaRequest.Age,
                Starring = addAvrupaRequest.Starring,
                Creators = addAvrupaRequest.Creators,
                Explane = addAvrupaRequest.Explane,
                Imdb = addAvrupaRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Avrupas.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateAvrupaRequest updateAvrupaRequest)
        {

            var existingPost = await _dbContext.Avrupas.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateAvrupaRequest.Name;
                existingPost.Minute = updateAvrupaRequest.Minute;
                existingPost.Url = updateAvrupaRequest.Url;
                existingPost.Category = updateAvrupaRequest.Category;
                existingPost.Year = updateAvrupaRequest.Year;
                existingPost.Country = updateAvrupaRequest.Country;
                existingPost.Trailer = updateAvrupaRequest.Trailer;
                existingPost.Age = updateAvrupaRequest.Age;
                existingPost.Starring = updateAvrupaRequest.Starring;
                existingPost.Creators = updateAvrupaRequest.Creators;
                existingPost.Explane = updateAvrupaRequest.Explane;
                existingPost.Imdb = updateAvrupaRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Avrupas.FindAsync(id);
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
