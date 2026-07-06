using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceWebsiteSystem1.Models
{
    internal class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; } // system generated

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; } // foreign key

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; } // foreign key

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; } // user input

        [MaxLength(500)]
        public string? Comment { get; set; } // user input, optional

        [Required]
        public DateTime ReviewDate { get; set; } // system generated
        public User? User { get; set; } // relationship ==> many reviews are written by one user

        public Product? Product { get; set; } // relationship ==> many reviews belong to one product
    }
}
