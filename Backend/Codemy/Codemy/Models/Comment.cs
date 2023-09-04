using BackendProject.Models;

namespace Codemy.Models
{
    public class Comment:BaseEntity
    {
        public string Message { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; } 

        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
