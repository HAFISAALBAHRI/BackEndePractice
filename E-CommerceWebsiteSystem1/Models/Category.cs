using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceWebsiteSystem1.Models
{
    internal class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; } // system generated

        [Required]
        [MaxLength(100)]
        public string categoryName { get; set; } = string.Empty; // user input, unique

        [MaxLength(500)]
        public string? description { get; set; } // user input, optional

        [MaxLength(300)]
        public string? imageUrl { get; set; } // user input, optional
    }
}
