using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Server.Services;
using MovieApp.Shared.DTOs;
using System.Threading.Tasks;


namespace MovieApp.Server.Controllers
{
    [Authorize]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesDbService _dbService;

        public MoviesController(ILogger<MoviesController> logger, IMoviesDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(await _dbService.GetMovies());
        }
        [HttpGet("details/{id}")]
        public async Task<IActionResult> GetMovie([FromRoute] int id)
        {
            return Ok(await _dbService.GetMovie(id));
        }
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> PutMovie([FromBody] EditMovieDTO movie, [FromRoute] int id)
        {
            var c = await _dbService.PutMovieAsync(movie, id);
            if (c == true)
                return Ok();
            else return BadRequest("Such person doesn't exist");

        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteDoctor([FromRoute] int id)
        {

            var c = await _dbService.DeleteMovieAsync(id);
            if (c == true)
                return Ok();
            else return BadRequest("Such person doesn't exist");
        }
        [HttpPost("add")]
        public async Task<IActionResult> PostMovie([FromBody] EditMovieDTO movie)
        {
           var c = await _dbService.PostMovieAsync(movie);
            if (c == true)
                return Ok();
            else return BadRequest("Such person already exists");
        }
    }
}
