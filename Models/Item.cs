using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CYOA_Merchant_API.Models
{
  public class Item
  {

    public int ItemId { get; set; }

    public string ItemName { get; set; }

    public bool Consume { get; set; }

    public int Quantity { get; set; }

    public ItemUse OnUse { get; set; }

  }
}