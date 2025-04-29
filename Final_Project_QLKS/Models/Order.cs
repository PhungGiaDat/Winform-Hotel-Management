using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int BookingId { get; set; }

    public int ServiceId { get; set; }

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
