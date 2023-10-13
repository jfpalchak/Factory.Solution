
namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }

    public int EngineerId { get; set; }
    public int MachineId { get; set; }

    // Reference Navigation Property
    public Engineer Engineer { get; set; }
    public Machine Machine { get; set; }
  }
}