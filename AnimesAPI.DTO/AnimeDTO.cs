using System.ComponentModel.DataAnnotations;

namespace AnimesAPI.DTO
{
    public class AnimeDTO
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Resume { get; set; }

        [Required]
        [Range(0, 2)]
        public int Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Studio { get; set; }

        [Required]
        [Range(0, 3)]
        public int Source { get; set; }

        [Required]
        public ICollection<ReferenceGenre> Genres { get; set; }

        [Required]
        [MaxLength(40)]
        public string Director { get; set; }
    }
}
