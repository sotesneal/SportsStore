﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Discription is required")]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
