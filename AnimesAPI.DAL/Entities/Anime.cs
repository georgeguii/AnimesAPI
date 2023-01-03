using AnimesAPI.DAL.Enums;

namespace AnimesAPI.DAL.Entities
{
    public class Anime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Resume { get; set; }

        public StatusEnum Status { get; set; }

        public string Studio { get; set; }

        public SourceEnum Source { get; set; }

        //Foi transformada em uma tabela separada devido ao relacionamento N pra N ser necessário
        //public GenresEnum Genres { get; set; }
        public ICollection<Genre> Genres { get; set; }

        public string Director { get; set; }

        public bool IsDeleted { get; set; }
    }
}
