using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }

    // Collection Navigation Property
    public List<EngineerMachine> JoinEntities { get; }
  }
}