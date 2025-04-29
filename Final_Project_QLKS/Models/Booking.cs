using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int CustomerId { get; set; }

    public int RoomId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckOutDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Room Room { get; set; } = null!;
}
