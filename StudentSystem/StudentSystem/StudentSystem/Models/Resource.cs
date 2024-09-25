using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    enum Type
    {
        Video,
        Presentation,
        Document
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public int Url { get; set; }

        public Type ResourceType{ get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }


    }
}
