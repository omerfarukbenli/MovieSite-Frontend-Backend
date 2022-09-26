using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Api.Models.DTO;
using Movie.Api.Models.Entities;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnasayfaController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public AnasayfaController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPosts()
        {
            var posts = await _dbContext.Anasayfas.ToListAsync();
            return Ok(posts);
        }
        [HttpGet]
        [ActionName("GetPostById")]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var post = await _dbContext.Anasayfas.FirstOrDefaultAsync(p => p.Id == id);
            if (post != null)
            {
                return Ok(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(AddAnasayfaRequest addAnasayfaRequest)
        {
            var post = new Anasayfa()
            {
                Name = addAnasayfaRequest.Name,
                Minute = addAnasayfaRequest.Minute,
                Url = addAnasayfaRequest.Url,
                Category = addAnasayfaRequest.Category,
                Year = addAnasayfaRequest.Year,
                Country = addAnasayfaRequest.Country,
                Trailer = addAnasayfaRequest.Trailer,
                Age = addAnasayfaRequest.Age,
                Starring = addAnasayfaRequest.Starring,
                Creators = addAnasayfaRequest.Creators,
                Explane = addAnasayfaRequest.Explane,
                Imdb = addAnasayfaRequest.Imdb,
                
            };
            post.Id = Guid.NewGuid();
            await _dbContext.Anasayfas.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, UpdateAnasayfaRequest updateAnasayfaRequest)
        {

            var existingPost = await _dbContext.Anasayfas.FindAsync(id);
            if (existingPost != null)
            {
                existingPost.Name = updateAnasayfaRequest.Name;
                existingPost.Minute = updateAnasayfaRequest.Minute;
                existingPost.Url = updateAnasayfaRequest.Url;
                existingPost.Category = updateAnasayfaRequest.Category;
                existingPost.Year = updateAnasayfaRequest.Year;
                existingPost.Country = updateAnasayfaRequest.Country;
                existingPost.Trailer = updateAnasayfaRequest.Trailer;
                existingPost.Age = updateAnasayfaRequest.Age;
                existingPost.Starring = updateAnasayfaRequest.Starring;
                existingPost.Creators = updateAnasayfaRequest.Creators;
                existingPost.Explane = updateAnasayfaRequest.Explane;
                existingPost.Imdb = updateAnasayfaRequest.Imdb;






                await _dbContext.SaveChangesAsync();
                return Ok(existingPost);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var existingPost = await _dbContext.Anasayfas.FindAsync(id);
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
