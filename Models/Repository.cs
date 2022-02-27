using System.Collections.Generic;

namespace mvc_deneme_2.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
new Movie(){Id= 1,Name= "Neighboor",Description="A story of a",ImageUrl= "https://mediacms01.digiturkplay.com/sa_bc/PT0000346717/neighbor-the-2017_220x286.jpg",},
new Movie(){Id=2,Name="Avatar",Description="The Avatar",ImageUrl="https://img-s1.onedio.com/id-52d7c61f43516df04300005f/rev-0/w-600/h-897/f-jpg/s-fcf82db0d47f693fce19cdd4106a76aebf32225c.jpg"},
new Movie(){Id=3,Name="Cin2",Description="The Cin 2",ImageUrl="https://mediacms01.digiturkplay.com/sa_bc/PT0000345053/cin-bebek2-2020_220x286.jpg"},
new Movie(){Id=4,Name="We Need To Talk",Description="The We Need To Talk",ImageUrl="https://mediacms01.digiturkplay.com/sa_bc/PT0000339332/we-need-to-talk-about-al-2020_220x286.jpg"},
new Movie(){Id=5,Name="Croods",Description="The Croods",ImageUrl="https://mediacms01.digiturkplay.com/sa_bc/PT0000340899/croods-a-new-age-the_220x286.jpg"},
new Movie(){Id=6,Name="Minari",Description="The Minari",ImageUrl="https://mediacms01.digiturkplay.com/sa_bc/PT0000325694/minari-turkce_220x286.jpg"},
            };
        }
        public static List<Movie> Movies
        {

            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie Entity)
        {
            _movies.Add(Entity);
        }

        public static Movie GetById(int Id)
        {
            return _movies.FirstOrDefault(x => x.Id == Id);
        }

    }
}