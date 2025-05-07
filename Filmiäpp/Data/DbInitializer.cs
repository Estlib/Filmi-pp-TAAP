using Filmiäpp.Models;

namespace Filmiäpp.Data
{
    public class DbInitializer
    {
        public static void Initialize(FilmContext context)
        {
            if (context.Films.Any())
            {
                return;
            }
            var films = new Film[]
            {
                new Film
                {
                    FilmID = 1,
                    FilmTitle = "TestFilm",
                    FilmDescription = "Description",
                    FilmImage = "no image",
                    FilmSecondImage = "no image",
                    FilmRating = 1,
                    FilmLanguage = "en",
                    Categories = new List<string> {"Test1", "Test2"},
                    PublicationDate = new DateOnly(),
                    Duration = new TimeOnly(),
                }
            };
        }
    }
}
