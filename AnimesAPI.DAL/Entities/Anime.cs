using AnimesAPI.DAL.Enums;

namespace AnimesAPI.DAL.Entities
{
    public class Anime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //AdcResumo

        public StatusEnum Status { get; set; }

        public string Studio { get; set; }

        public SourceEnum Source { get; set; }

        //Dps transformar em uma tabela separada N ... N; fix nos DTO's
        public GenresEnum Genres { get; set; }

        public string Director { get; set; }

        public bool IsDeleted { get; set; }
    }
}
