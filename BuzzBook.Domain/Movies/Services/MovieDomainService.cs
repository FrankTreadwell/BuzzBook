using BuzzBook.Domain.Movies.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuzzBook.Domain.Movies.Contracts.Models;

namespace BuzzBook.Domain.Movies.Services
{
    class MovieDomainService : IMovieDomainService
    {
        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}
