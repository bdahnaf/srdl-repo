using System.ComponentModel.DataAnnotations;

namespace srdl_repo.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Extension { get; set; }
        public DateTime PostedDate { get; set; }

        //Relationships
        public School School { get; set; }
    }
}
