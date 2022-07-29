using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }
        
        [Required]
        public decimal Height { get; set; }
        
        [Required]
        public float Weight { get; set; } 
        
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}