using System.ComponentModel.DataAnnotations;

namespace BookTrackingAPI.DataObjects
{

    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ApiKey { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string? BirthDate { get; set; }

        [StringLength(50)]
        public string? DeathDate { get; set; }

    }
}
