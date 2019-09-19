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
        public Movie()
        {
            Actors = new List<Actor>();
        }

        public Movie(string title, Director director)
            : this()
        {
            Title = title;
            Director = director;
        }

        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public int ReleaseYear { get; set; }

        // Foreign key property
        public int DirectorId { get; set; }
        // Navigation property
        public Director Director { get; set; }

        public List<Actor> Actors { get; set; }

        public string Information
        {
            get
            {
                return $"{Title} ({Genre}/{Language}/{ReleaseYear})";
            }
        }

        public string ActorNames
        {
            get
            {
                if (Actors != null)
                {
                    var actorNames = Actors.Select(a => a.Name).ToList();
                    return string.Join(", ", actorNames);
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public override string ToString()
        {
            return $"{Title} directed by {Director.Name} starring {ActorNames}";
        }
    }
}
