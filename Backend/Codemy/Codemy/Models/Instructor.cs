using BackendProject.Models;

namespace Codemy.Models
{
    public class Instructor : BaseEntity
    {
        public string Fullname { get; set; }
        public string Field { get; set; }
        public string ImageUrl { get; set; }
        public string Desc { get; set; }

        public List<Course> Courses { get; set; }
        public InstructorContacts InstructorContacts { get; set; }
    }
}
