﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }

    }
}
