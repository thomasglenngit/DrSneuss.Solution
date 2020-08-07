using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.Machines = new HashSet<EngineerMachine>();
      
    }

    public int EngineerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual ICollection<EngineerMachine> Machines { get; set; }
    
  }
}