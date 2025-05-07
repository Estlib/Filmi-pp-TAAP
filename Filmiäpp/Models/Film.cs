namespace Filmiäpp.Models
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmTitle { get; set; }
        public string FilmDescription { get; set; }
        public string FilmImage { get; set; }
        public string FilmSecondImage { get; set; }
        public int FilmRating { get; set; }
        public List<string> Categories { get; set; }
        public DateOnly PublicationDate { get; set; }
        public string FilmLanguage { get; set; }
        public TimeOnly Duration { get; set; }
        //public List<Account> UsersWhoOwnMovie { get; set; }
        //public List<Comments> CommentsOnMovie { get; set; }

    }
}
