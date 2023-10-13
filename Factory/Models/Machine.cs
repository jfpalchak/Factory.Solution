using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }


    // Collection Navigation Property
    public List<EngineerMachine> JoinEntities { get; }
  }
}