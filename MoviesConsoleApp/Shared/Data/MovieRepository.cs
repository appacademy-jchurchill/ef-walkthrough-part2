using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Shared.Data
{
    public class MovieRepository
    {
        private Context context;

        public MovieRepository(Context context)
        {
            if (context == null)
            {
                throw new ArgumentException("Please provide an instance of the Context class.");
            }

            this.context = context;
        }

        public List<Movie> GetList()
        {
            return context.Movies
                .Include(m => m.Director)
                .Include(m => m.Actors)
                .OrderBy(m => m.Title)
                .ToList();
        }

        public Movie Get(int id)
        {
            return context.Movies
                .Where(m => m.Id == id)
                .SingleOrDefault();
        }

        //public List<Movie> GetList(Expression<Func<Movie, object>> orderBy)
        //{
        //    return context.Movies
        //        .OrderBy(orderBy)
        //        .ToList();
        //}

        //public Movie Get(Expression<Func<Movie, bool>> whereBy)
        //{
        //    return context.Movies
        //        .Where(whereBy)
        //        .SingleOrDefault();
        //}
    }
}
