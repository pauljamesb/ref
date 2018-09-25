using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Granitehouse.Models 
{
    class SpecialTags 
    {
      public string Id { get; set; }
        
      [Required]  
      public string Name { get; set; }
    }
}


