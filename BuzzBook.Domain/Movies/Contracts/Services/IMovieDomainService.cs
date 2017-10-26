using BuzzBook.Domain.Movies.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzBook.Domain.Movies.Contracts.Services
{
    public interface IMovieDomainService
    {
        IList<Movie> GetMovies();
        Movie GetMovieById(int id);
    }
}
