using System.ComponentModel.DataAnnotations;

namespace BookTrackingAPI.DataObjects
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ApiId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(200)]
        public string? Subtitle { get; set; }

        [StringLength(20)]
        public string? PublishedDate { get; set; }

        public string? Description { get; set; }

    }
}
