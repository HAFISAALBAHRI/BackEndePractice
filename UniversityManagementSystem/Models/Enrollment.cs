using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UniversityManagementSystem.Models
{
    internal class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; } // System Generated

        [ForeignKey("Student")]
        public int studentId { get; set; } // Foreign Key

        [ForeignKey("Course")]
        public int courseId { get; set; } // Foreign Key

        [Required]
        public DateTime enrollmentDate { get; set; } // User Input

        [MaxLength(2)]
        public string? finalGrade { get; set; } // User Input

        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress"; // Default Value

        // Navigation Property (Many Enrollments -> One Student)
        public Student Student { get; set; }

        // Navigation Property (Many Enrollments -> One Course)
        public Course Course { get; set; }
    }
}
