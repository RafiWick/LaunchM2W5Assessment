using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment
{
    public class SeedData
    {
        public static void SeedConcertsAndPerformers(ConcertContext context)
        {
            var performer1 = new Performer { Name = "Big K.R.I.T.", Genre = "Rap" };
            var performer2 = new Performer { Name = "Paul Wall", Genre = "Rap" };
            var performer3 = new Performer { Name = "John the Martyr", Genre = "Soul" };
            var performer4 = new Performer { Name = "Belly", Genre = "Rap" };

            var concerts = new List<Concert>()
            {
                new Concert {Name = "The Filmore", ShowDate = new DateTime(2023, 9, 20).ToUniversalTime(), Performers = new List<Performer>(){performer1, performer2} },
                new Concert {Name = "Ball Arena", ShowDate = new DateTime(2023, 5, 28).ToUniversalTime(), Performers = new List<Performer>(){performer2, performer3} },
                new Concert {Name = "Red Rocks", ShowDate = new DateTime(2023, 11, 6).ToUniversalTime(), Performers = new List<Performer>(){performer1, performer3, performer4} },
            };
            context.Concerts.AddRange(concerts);
            context.SaveChanges();
        }
    }
}
