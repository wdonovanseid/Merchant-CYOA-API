using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CYOA_Merchant_API.Models
{
  public class Player
  {

    public int PlayerId { get; set; }

    public string Name { get; set; }

    public int Strength { get; set; }

    public int Dexterity { get; set; }

    public int Intelligence { get; set; }

    public int Charisma { get; set; }

    public int Gold { get; set; }

    public int Exp { get; set; }

    public int Level { get; set; }

    public int MaxHP { get; set; }

    public int CurrentHP { get; set; }

    public int MaxMP { get; set; }

    public int CurrentMP { get; set; }

    public int MaxStamina { get; set; }

    public int CurrentStamina { get; set; }

    public Dictionary<string, int> CurrentLocation { get; set; }

    public Item[] Inventory { get; set; }

    public string Id { get; set; }

  }
}