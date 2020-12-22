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
    public string LocationTitle { get; set; }

    [Required]
    public string LocationDescription { get; set; }

    [Required]
    public SpecAction[] LocationSpecificActions { get; set; }

    [Required]
    public MoveAction[] LocationMovementActions { get; set; }

  }
}