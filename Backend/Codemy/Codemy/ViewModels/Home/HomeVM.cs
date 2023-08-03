using Codemy.Models;

namespace Codemy.ViewModels.Home
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}
