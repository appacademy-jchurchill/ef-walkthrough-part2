using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shared.Models;

namespace Shared.Data
{
    public class DatabaseInitializer
        : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.Movies.Add(new Movie("A New Hope"));
            context.Movies.Add(new Movie("Empire Strikes Back"));

            context.SaveChanges();
        }
    }
}
