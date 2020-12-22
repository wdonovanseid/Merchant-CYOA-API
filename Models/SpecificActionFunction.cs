using System.ComponentModel.DataAnnotations;

namespace CYOA_Merchant_API.Models
{
  public class SpecificActionFunction
  {

    public int SpecificActionFunctionId { get; set; }

    public Player Player { get; set; }

    public SpecificAction Action { get; set; }

    public RefreshFunction RefreshFunc { get; set; }

  }
}