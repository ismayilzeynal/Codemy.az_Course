using BackendProject.Models;

namespace Codemy.Models
{
    public class ShortLesson : BaseEntity
    {
        public string EmbedYoutubeUrl { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
