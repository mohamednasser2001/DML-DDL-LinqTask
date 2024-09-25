using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Course
    {
        public int  CourseId { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
       // public ICollection<Student>Students { get; set; }
        public ICollection<StudentCourse>StudentCourses { get; set; }
      // public Student Student { get; set; }
        //public int StudentId { get; set; }
        public ICollection<Resource> resources { get; set; }
        public ICollection<Homework> homeworks { get;set; }









    }
}
