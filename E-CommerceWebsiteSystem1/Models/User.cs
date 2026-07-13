using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_CommerceWebsiteSystem1.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; } // system generated

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty; // user input, unique

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty; // user input, unique

        [Required]
        [MaxLength(256)]
        public string PasswordHash { get; set; } = string.Empty; // user input

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty; // user input

        [MaxLength(20)]
        public string? PhoneNumber { get; set; } // user input, optional

        [MaxLength(300)]
        public string? Address { get; set; } // user input, optional

        [Required]
        public DateTime RegistrationDate { get; set; } // system generated

        public bool IsActive { get; set; } = true; // default value

        //relations
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // relationship ==> one user places many orders

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>(); // relationship ==> one user writes many reviews
    }
}
