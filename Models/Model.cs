using System.ComponentModel.DataAnnotations;

namespace ahmad.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        public Make make { get; set; }
        public int MakeId { get; set; }
    }
}