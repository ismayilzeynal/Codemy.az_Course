using BackendProject.Models;

namespace Codemy.Models
{
    public class Event : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string? RegisterUrl { get; set; }
        public string Author { get; set; }


        public List<Comment> Comments { get; set; }
    }
}
