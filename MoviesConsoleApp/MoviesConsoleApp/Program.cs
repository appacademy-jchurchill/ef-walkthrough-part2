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
                var movies = context.Movies
                    .OrderBy(m => m.Title)
                    .ToList();

                movies.ForEach(m => Console.WriteLine(m));
            }

            Console.ReadKey();
        }
    }
}
