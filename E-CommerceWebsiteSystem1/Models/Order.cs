using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_CommerceWebsiteSystem1.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; } // system generated

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; } // foreign key
        public User? User { get; set; }
        [Required]
        public DateTime OrderDate { get; set; } // system generated

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(typeof(decimal), "0.00", "999999.99")]
        public decimal TotalAmount { get; set; } // calculated

        [Required]
        [MaxLength(30)]
        public string status { get; set; } = "Pending"; // default value

        [Required]
        [MaxLength(300)]
        public string ShippingAddress { get; set; } = string.Empty; // user input

        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; } = string.Empty; // from list

        // relationship ==> many orders belong to one user
        
    }
}
