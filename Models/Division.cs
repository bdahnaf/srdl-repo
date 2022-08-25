using System.ComponentModel.DataAnnotations;

namespace srdl_repo.Models
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Relationships
        public TYPE Type { get; set; }
    }
}
