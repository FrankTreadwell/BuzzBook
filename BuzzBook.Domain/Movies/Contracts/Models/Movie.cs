using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzBook.Domain.Movies.Contracts.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
    }
}
