using System;

namespace EntityCore.Models;

public class Driver : BaseEntity
{
    public int TeamId { get; set; }
    public string Name { get; set; } = null!;
    public int RacingNumber { get; set; }
    public string FavoriteColor { get; set; } = null!;
    public virtual Team Team { get; set; } = null!;
    public virtual DriverMedia DriverMedia { get; set; } = null!;
}