using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; } // System Generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } // User Input

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } // User Input

        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; } // User Input

        [ForeignKey("Department")]
        public int departmentId { get; set; } // Foreign Key

        [ForeignKey("Instructor")]
        public int? instructorId { get; set; } // Foreign Key

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } // User Input

        // Navigation Property (Many Courses -> One Department)
        public Department Department { get; set; }

        // Navigation Property (Many Courses -> One Instructor)
        public Instructor? Instructor { get; set; }

        // Navigation Property (One Course -> Many Enrollments)
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
