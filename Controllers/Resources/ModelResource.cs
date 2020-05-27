using System.ComponentModel.DataAnnotations;
using ahmad.Models;

namespace ahmad.Controllers.Resources
{
    public class ModelResource
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
       // public Make make { get; set; }
       // public int MakeId { get; set; }
    }
}