using System.ComponentModel.DataAnnotations;

namespace srdl_repo.Models
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        [Required]
        public string Name { get; set; }

        //Relationships
        public Division Division { get; set; }
        public ICollection<Upazila> Upazilas { get; set; }
    }
}
