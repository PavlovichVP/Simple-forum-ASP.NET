using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace forum.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "Date")]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:D}")]
        public DateTime CreatedDate { get; set; }
    }
}
