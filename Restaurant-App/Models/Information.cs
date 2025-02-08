﻿using System.ComponentModel.DataAnnotations;

namespace Restaurant_App.Models
{
    public class Information :BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
