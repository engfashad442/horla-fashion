using System.ComponentModel.DataAnnotations;

namespace ahmad.Models
{
    public class Feature
    
    {
        public int Id {get;set;}
        [Required]
        [StringLength(225)]
        public string Name {get;set;}
    }
}