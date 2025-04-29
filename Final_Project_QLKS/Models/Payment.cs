using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int BookingId { get; set; }

    public decimal TotalRoomPrice { get; set; }

    public decimal TotalServicePrice { get; set; }

    public decimal TotalAmount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public int CreatedBy { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;
}
