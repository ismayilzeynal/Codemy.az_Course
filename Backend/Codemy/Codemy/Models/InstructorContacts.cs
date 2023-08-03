using BackendProject.Models;

namespace Codemy.Models
{
    public class InstructorContacts : BaseEntity
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Github { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Codemy { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
