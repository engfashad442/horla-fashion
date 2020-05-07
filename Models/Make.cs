using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ahmad.Models
{
    public class Make
    {
      
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public Make()
        {
          Models = new Collection<Model>();  
        }
    }
}