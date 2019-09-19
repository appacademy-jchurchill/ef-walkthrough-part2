using Shared.Data;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DatabaseInitializer());

            using (var context = new Context())
            {
                context.Database.Log = (message) => Console.WriteLine(message);

                var movieRepository = new MovieRepository(context);

                List<Movie> movies = movieRepository.GetList();
                movies.ForEach(m => Console.WriteLine(m));




                //var directors = context.Directors
                //    .Include(d => d.Movies)
                //    .ToList();

                //directors.ForEach(d =>
                //{
                //    // option #1
                //    var movieTitles = d.Movies.Select(m => m.Title).ToList();
                //    string movieTitlesDisplay = string.Join(", ", movieTitles);

                //    // option #2
                //    //StringBuilder sb = new StringBuilder();
                //    //d.Movies.ForEach(m =>
                //    //{
                //    //    sb.Append(m.Title);
                //    //    sb.Append(", ");
                //    //});
                //    //sb.Remove(sb.Length - 2, 2);
                //    //string movieTitles = sb.ToString();

                //    // {director name} (list of movie titles)
                //    Console.WriteLine($"{d.Name} ({movieTitlesDisplay})");
                //});


                //var movieRepository = new MovieRepository(context);

                //List<Movie> movies = movieRepository.GetList();
                //movies.ForEach(m => Console.WriteLine(m));

                //Movie movie = movieRepository.Get(1);
                //Console.WriteLine(movie);
            }

            Console.ReadKey();
        }
    }
}
