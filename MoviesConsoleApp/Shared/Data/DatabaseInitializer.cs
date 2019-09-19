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
            var georgeLucas = new Director()
            {
                Name = "George Lucas"
            };
            context.Directors.Add(georgeLucas);

            var markHamill = new Actor()
            {
                Name = "Mark Hamill"
            };
            var carrieFisher = new Actor()
            {
                Name = "Carrie Fisher"
            };
            context.Actors.Add(markHamill);
            context.Actors.Add(carrieFisher);

            var aNewHope = new Movie("A New Hope", georgeLucas);
            aNewHope.Actors.Add(markHamill);
            aNewHope.Actors.Add(carrieFisher);

            var empireStrikesBack = new Movie("Empire Strikes Back", georgeLucas);
            empireStrikesBack.Actors.Add(markHamill);
            empireStrikesBack.Actors.Add(carrieFisher);

            context.Movies.Add(aNewHope);
            context.Movies.Add(empireStrikesBack);

            context.SaveChanges();
        }
    }
}
