using System.ComponentModel.DataAnnotations;

namespace srdl_repo.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        [Required]
        public string Name { get; set; }
        public string NameInBangla { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Relationships
        public ICollection<Image> Images { get; set; }
    }
}
