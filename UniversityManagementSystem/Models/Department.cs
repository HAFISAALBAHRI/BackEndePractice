using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; } // System Generated

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } // User Input

        [MaxLength(50)]
        public string? building { get; set; } // User Input

        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal budget { get; set; } // User Input

        [ForeignKey("HeadInstructor")]
        public int? headInstructorId { get; set; } // Foreign Key

        // Navigation Property (Department Head)
        public Instructor? HeadInstructor { get; set; }

        // Navigation Property (One Department has Many Courses)
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
