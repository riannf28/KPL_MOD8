using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modul8_1302200040.Models;

namespace modul8_1302200040.Repo
{
    public class MovieRepository : IMovieRepository
    {

        public readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
        }
        public Task<Movie> Create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
