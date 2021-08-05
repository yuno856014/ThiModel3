using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMagament.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(40)]
        public string StudentName { get; set; }
        [Required]
        public int DateOfBirth { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        public int ClassId { get; set; }
        public ClassRoom classRoom { get; set; }
    }
}
