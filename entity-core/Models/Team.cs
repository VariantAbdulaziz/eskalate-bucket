using System;

namespace EntityCore.Models;

public class Team : BaseEntity
{
    public Team()
    {
        Drivers = new HashSet<Driver>();
    }
    public string Name { get; set; } = null!;
    public int Year { get; set; }
    public virtual ICollection<Driver> Drivers { get; set; }
}