using Microsoft.AspNetCore.Identity;

namespace Codemy.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string? ConnectionId { get; set; }

        public List<ShortLesson> ShortLessons { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
