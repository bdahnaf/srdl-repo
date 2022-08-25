﻿using System.ComponentModel.DataAnnotations;

namespace srdl_repo.Models
{
    public class Upazila
    {
        [Key]
        public string UpzailaId { get; set; }
        [Required]
        public string Name { get; set; }

        //Relationships
        public District District { get; set; }
        public Division Division { get; set; }
    }
}
