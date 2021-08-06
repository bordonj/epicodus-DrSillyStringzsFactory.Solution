using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<DoctorMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    public string DateCreated { get; set; }

    public virtual ICollection<DoctorMachine> JoinEntities { get;}
  }
}