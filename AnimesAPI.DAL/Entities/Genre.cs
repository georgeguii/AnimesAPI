using Azure;

namespace AnimesAPI.DAL.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public ICollection<AnimeGenre> AnimeGenres { get; set; }
    }
}