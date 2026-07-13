using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_CommerceWebsiteSystem1.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; } // system generated

        [Required]
        [MaxLength(150)]
        public string ProductName { get; set; } = string.Empty; // user input

        [MaxLength(1000)]
        public string? Description { get; set; } // user input, optional

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(typeof(decimal), "0.01", "99999.99")]
        public decimal Price { get; set; } // user input

        [Required]
        //stockQuantity int Required, must be greater than or equal to 0
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; } = 0; // default value

        [MaxLength(300)]
        public string? ImageUrl { get; set; } // user input, optional

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; } // foreign key

        [Required]
        public DateTime CreatedAt { get; set; } // system generated

        public bool IsAvailable { get; set; } = true; // default value

        public virtual Category? Category { get; set; } // relationship ==> many products belong to one category

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>(); // relationship ==> one product has many reviews
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
