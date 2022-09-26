using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OlmedenController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public OlmedenController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Olmedens.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Olmedens.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddOlmedenRequest addOlmedenRequest)
        {
            var post = new Olmeden()
            {
                Name = addOlmedenRequest.Name,
                Minute = addOlmedenRequest.Minute,
                Url = addOlmedenRequest.Url,
                Category = addOlmedenRequest.Category,
                Year = addOlmedenRequest.Year,
                Country = addOlmedenRequest.Country,
                Trailer = addOlmedenRequest.Trailer,
                Age = addOlmedenRequest.Age,
                Starring = addOlmedenRequest.Starring,
                Creators = addOlmedenRequest.Creators,
                Explane = addOlmedenRequest.Explane,
                Imdb = addOlmedenRequest.Imdb,

            };
            post.Id = Guid.NewGuid();
            await _dbContext.Olmedens.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateOlmedenRequest updateOlmedenRequest)
        {

            var existingPost = await _dbContext.Olmedens.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateOlmedenRequest.Name;
                existingPost.Minute = updateOlmedenRequest.Minute;
                existingPost.Url = updateOlmedenRequest.Url;
                existingPost.Category = updateOlmedenRequest.Category;
                existingPost.Year = updateOlmedenRequest.Year;
                existingPost.Country = updateOlmedenRequest.Country;
                existingPost.Trailer = updateOlmedenRequest.Trailer;
                existingPost.Age = updateOlmedenRequest.Age;
                existingPost.Starring = updateOlmedenRequest.Starring;
                existingPost.Creators = updateOlmedenRequest.Creators;
                existingPost.Explane = updateOlmedenRequest.Explane;
                existingPost.Imdb = updateOlmedenRequest.Imdb;

                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Olmedens.FindAsync(id);
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
