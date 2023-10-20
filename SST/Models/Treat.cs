using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SST.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    
    [Required(ErrorMessage = "Treat must have a name")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Allergen warnings are required. If no - type none.")]
    public string Allergen { get; set; }
    
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    
    public int Rate { get; set; }

    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; } 
  }
}