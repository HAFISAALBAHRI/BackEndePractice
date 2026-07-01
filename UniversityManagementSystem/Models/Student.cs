using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UniversityManagementSystem.Models
{
    
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; } // System Generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } // User Input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // User Input

        [MaxLength(20)]
        public string? phoneNumber { get; set; } // User Input

        [Required]
        public DateTime dateOfBirth { get; set; } // User Input

        [Required]
        [Range(2000, 2030)]
        public int enrollmentYear { get; set; } // User Input

        [Column(TypeName = "decimal(3,2)")]
        [Range(0.0, 4.0)]
        public decimal gpa { get; set; } = 0.0m; // Default Value

        // Navigation Property
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}

