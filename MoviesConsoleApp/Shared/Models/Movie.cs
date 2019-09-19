using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Movie
    {
        public Movie() { }

        public Movie(string title)
        {
            Title = title;
        }

        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}";
        }
    }
}
