using BackendProject.Models;

namespace Codemy.Models
{
    public class CourseDetail : BaseEntity
    {
        public string Detail { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
