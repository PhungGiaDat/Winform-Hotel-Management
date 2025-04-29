using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
