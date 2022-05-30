using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [Column(TypeName = "Date")]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:f}")]
        public DateTime Created { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
