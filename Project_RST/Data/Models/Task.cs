using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Project_RST.Data.Models
{
    public class Task
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(150), Column(TypeName = "nvarchar(150)")]
        public string Title { get; set; } = "Title";

        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; } = "Description";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool Done { get; set; } = false;
        public bool Deleted { get; set; } = false;


    }
}
