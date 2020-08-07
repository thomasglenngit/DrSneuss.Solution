using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Doctors = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Name { get; set; }

    public string Function { get; set; }
    
    public DateTime ConstructionDate { get; set; }

    public ICollection<EngineerMachine> Doctors { get; }
  }
}