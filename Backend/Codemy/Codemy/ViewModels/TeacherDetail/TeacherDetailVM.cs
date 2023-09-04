using Codemy.Models;

namespace Codemy.ViewModels.TeacherDetail
{
    public class TeacherDetailVM
    {
        public Instructor Instructor { get; set; }
        public List<Course> Courses { get; set; }
        //public List<Event> Courses { get; set; }

    }
}
