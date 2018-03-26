using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Models
{
    public class RegisterProductModel : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}