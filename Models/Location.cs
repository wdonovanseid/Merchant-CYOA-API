using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CYOA_Merchant_API.Models
{
  public class Location
  {

    [Required]
    public int LocationId { get; set; }

    [Required]
    public Dictionary<string, int> LocationCoordinates { get; set; }

    [Required]
    public string LocationMapIcon { get; set; }

    [Required]
    [StringLength(20)]
    public string LocationName { get; set; }

    [Required]
    public string LocationBreed { get; set; }

    [Required]
    [Range(0, 20, ErrorMessage = "Age must be between 0 and 20")]
    public int LocationAge { get; set; }

    [Required]
    public string LocationDetails { get; set; }

  }
}