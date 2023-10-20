using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SST.Models
{
  public class Flavor
    {
        public int FlavorId { get; set; }
        
        [Required(ErrorMessage = "Creating a flavor requires a name")]
        public string Name { get; set; }
        
        public List<FlavorTreat> JoinEntities { get;}
    }
}