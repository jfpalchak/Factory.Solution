using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "* Please enter a name for the engineer.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "* Please select a status for the engineer.")]
    public bool Active { get; set; }

    // Collection Navigation Property
    public List<EngineerMachine> JoinEntities { get; }
  }
}