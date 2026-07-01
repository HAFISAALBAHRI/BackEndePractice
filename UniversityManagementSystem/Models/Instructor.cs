using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UniversityManagementSystem.Models
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; } // System Generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } // User Input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // User Input

        [MaxLength(20)]
        public string? officeNumber { get; set; } // User Input

        [Required]
        public DateTime hireDate { get; set; } // User Input

        [Required]
        [Range(0.01, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal salary { get; set; } // User Input

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } // User Input

        // Navigation Property (One Instructor teaches Many Courses)
        public ICollection<Course> Courses { get; set; } = new List<Course>();

        // Navigation Property (One Instructor may head One Department)
        public Department? HeadDepartment { get; set; }
    }
}
