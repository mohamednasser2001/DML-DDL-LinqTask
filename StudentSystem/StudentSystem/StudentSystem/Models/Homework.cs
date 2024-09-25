using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public ContentType Content { get; set; }
       
        public DateTime  SubmissionTime { get; set; }
        // public DateTime   { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course course { get; set; }
        public int CourseId { get; set; }





    }
}
