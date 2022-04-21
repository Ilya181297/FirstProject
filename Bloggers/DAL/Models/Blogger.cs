using System.ComponentModel.DataAnnotations.Schema;

namespace Bloggers.Models
{
    public class Blogger
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Post { get; set; }
    }
}
