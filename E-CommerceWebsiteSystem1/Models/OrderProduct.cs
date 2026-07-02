using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceWebsiteSystem1.Models
{
    internal class OrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderProductId { get; set; } // system generated

        [Required]
        [ForeignKey("Order")]
        public int orderId { get; set; } // foreign key

        [Required]
        [ForeignKey("Product")]
        public int productId { get; set; } // foreign key

        [Required]
        [Range(1, 999)]
        public int quantity { get; set; } // user input
    }
}
