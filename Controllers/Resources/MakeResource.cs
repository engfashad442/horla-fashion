using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using ahmad.Models;

namespace ahmad.Controllers.Resources
{
    public class MakeResource
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
        public MakeResource()
        {
          Models = new Collection<ModelResource>();  
        }

    }
}