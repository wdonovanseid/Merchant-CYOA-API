using System.ComponentModel.DataAnnotations;

namespace CYOA_Merchant_API.Models
{
  public class MovementAction
  {

    public int MovementActionId { get; set; }

    public string ActionName { get; set; }

    public bool EventTrigger { get; set; }

    public OnClick { get; set; }

  }
}