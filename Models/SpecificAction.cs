using System.ComponentModel.DataAnnotations;

namespace CYOA_Merchant_API.Models
{
  public class SpecificAction
  {

    public int SpecificActionId { get; set; }

    public string ActionName { get; set; }

    public bool EventTrigger { get; set; }

    public SpecificActionFunction OnClick { get; set; }

  }
}