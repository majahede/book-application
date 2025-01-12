using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookApi.Domain.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("id", TypeName = "UUID", Order = 1)]
        public Guid Id { get; set; }

        [Required]
        [Column("title", TypeName = "VARCHAR(50)")]
        public required string Title { get; set; }
    }
}
