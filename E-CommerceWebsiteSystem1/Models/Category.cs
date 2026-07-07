using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceWebsiteSystem1.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; } // system generated

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; } = string.Empty; // user input, unique

        [MaxLength(500)]
        public string? Description { get; set; } // user input, optional

        [MaxLength(300)]
        public string? ImageUrl { get; set; } // user input, optional
        public ICollection<Product> Products { get; set; } = new List<Product>(); // relationship ==> one category has many products
    }
}
