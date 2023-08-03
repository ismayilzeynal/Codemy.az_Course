using BackendProject.Models;

namespace Codemy.Models
{
    public class Course : BaseEntity
    {
        public string ImageUrl {get; set;}
        public string Name { get; set; }
        public string Desc { get; set; }
        public string SyllabusUrl { get; set; }
        public string DemoUrl { get; set; }
        public string RegisterUrl { get; set; }
        public DateTime StartDate { get; set; }

        public List<CourseDetail> CourseDetails { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

    }
}
