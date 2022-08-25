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
        public ICollection<District> Districts { get; set; }
        public ICollection<Upazila> Upazilas { get; set; }
    }
}
