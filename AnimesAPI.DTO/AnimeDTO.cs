using System.ComponentModel.DataAnnotations;

namespace AnimesAPI.DTO
{
    public class AnimeDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string Studio { get; set; }

        [Required]
        public int Source { get; set; }

        [Required]
        public List<int> Genres { get; set; }

        [Required]
        public string Director { get; set; }
    }
}
