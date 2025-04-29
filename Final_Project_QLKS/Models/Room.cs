using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int BranchId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string RoomType { get; set; } = null!;

    public decimal PricePerDay { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Branch Branch { get; set; } = null!;
}
