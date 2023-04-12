using System;

namespace EntityCore.Models;

public class DriverMedia : BaseEntity
{
    public int DriverId { get; set; }
    public string Media { get; set; } = null!;
    public virtual Driver? Driver { get; set; }
}