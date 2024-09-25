using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    [PrimaryKey(nameof(CourseId),nameof(StudentId))]
    internal class StudentCourse
    {
        
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Course course { get; set; }
        public Student student { get; set; }
    }
}
