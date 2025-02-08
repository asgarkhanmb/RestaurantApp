﻿using System.ComponentModel.DataAnnotations;

namespace Restaurant_App.ViewModels.Informations
{
    public class InformationCreateVM
    {
        [Required]
        public IFormFile Icon { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
