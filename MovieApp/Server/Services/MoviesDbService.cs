using Microsoft.EntityFrameworkCore;
using MovieApp.Server.Data;
using MovieApp.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.DTOs;
namespace MovieApp.Server.Services
{
    public interface IMoviesRepository
    {

    }

    public interface IMoviesDbService
    {
        Task<List<Movie>> GetMovies();
        Task AddMovie();
        Task<Movie> GetMovie(int movieId);
        public Task<bool> PutMovieAsync(EditMovieDTO movie, int id);
        public Task<bool> DeleteMovieAsync(int id);
        public Task<bool> PostMovieAsync(EditMovieDTO movie);
    }

    public class MoviesDbService : IMoviesDbService
    {
        private ApplicationDbContext _context;

        public MoviesDbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddMovie()
        {
            throw new System.NotImplementedException();
        }

        public Task<Movie> GetMovie(int movieId)
        {
            return _context.Movies.Where(e => e.Id == movieId).FirstAsync();
        }

        public Task<List<Movie>> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Title).ToListAsync();
        }
        public async Task<bool> PutMovieAsync(EditMovieDTO movie, int id)
        {
            var movieExists = await _context.Movies.AnyAsync(e => e.Id == id);
            if (!movieExists)
            {
                return false;
            }
            var newMovie = new Movie
            {
                Id = id,
                Title = movie.Title,
                Summary = movie.Summary,
                InTheaters = movie.InTheaters,
                Trailer = movie.Trailer,
                ReleaseDate = movie.ReleaseDate,
                Poster = movie.Poster

            };
            _context.Movies.Attach(newMovie);
            _context.Entry(newMovie).Property(nameof(Movie.Title)).IsModified = true;
            _context.Entry(newMovie).Property(nameof(Movie.Summary)).IsModified = true;
            _context.Entry(newMovie).Property(nameof(Movie.InTheaters)).IsModified = true;
            _context.Entry(newMovie).Property(nameof(Movie.Trailer)).IsModified = true;
            _context.Entry(newMovie).Property(nameof(Movie.ReleaseDate)).IsModified = true;
            _context.Entry(newMovie).Property(nameof(Movie.Poster)).IsModified = true;
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteMovieAsync(int id)
        {
            var MovieExists = await _context.Movies.AnyAsync(e => e.Id == id);
            if (!MovieExists)
                return false;

            var movie = new Movie
            {
                Id = id
            };
            _context.Movies.Attach(movie);
            _context.Entry(movie).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return true;

        }
        public async Task<bool> PostMovieAsync(EditMovieDTO movie)
        {
            var movieExists = await _context.Movies.AnyAsync(e => e.Title == movie.Title);
            if (movieExists)
            {
                return false;
            }
            var newMovie = new Movie
            {
                Title = movie.Title,
                Summary = movie.Summary,
                InTheaters = movie.InTheaters,
                Trailer = movie.Trailer,
                ReleaseDate = movie.ReleaseDate,
                Poster = movie.Poster
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
