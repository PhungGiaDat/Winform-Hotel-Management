using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
