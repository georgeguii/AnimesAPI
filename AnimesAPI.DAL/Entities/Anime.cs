using AnimesAPI.DAL.Enums;

namespace AnimesAPI.DAL.Entities
{
    public class Anime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public StatusEnum Status { get; set; }

        public string Studio { get; set; }

        public SourceEnum Source { get; set; }

        public GenresEnum Genres { get; set; }

        public string Director { get; set; }

        public bool IsDeleted { get; set; }
    }
}
