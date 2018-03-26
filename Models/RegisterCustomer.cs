using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Models
{
    public class RegisterCustomerModel : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Name { get; set; }
        
    }
}