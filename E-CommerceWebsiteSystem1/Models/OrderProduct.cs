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
        public int OrderProductId { get; set; } // system generated

        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; } // foreign key
        public Order? Order { get; set; } // relationship ==> many orderproduct belong to one order
        
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; } // foreign key
        public Product? Product { get; set; } // relationship ==> many orderproduct belong to one product
        [Required]
        [Range(1, 999)]
        public int Quantity { get; set; } // user input
                                          //relations
        

       
    }
}
