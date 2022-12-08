using AtelierBooking.Models.Enums;
using Microsoft.VisualBasic;

namespace AtelierBooking.Models.ApiModels;

internal sealed class ReservationsAPIData
{
    public int Id { get; set; }

    public string Ip { get; set; }

    public string Created { get; set; }

    public string Start { get; set; }

    public string End { get; set; }

    public Status Status { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Note { get; set; }

    public bool Vip { get; set; }

    public Coupon? UsedCoupon { get; set; }

    public ReservationListItem ToReservatListItem()
    {
        return new ReservationListItem()
        {
            //BookedFrom = TimeOnly.Parse(Start, "yyyy-MM-dd HH:mm:ss:fff", out var bookedFrom) ? bookedFrom : TimeOnly.MinValue,
            BookedTo = TimeOnly.TryParse(End, out var bookedTo) ? bookedTo : TimeOnly.MinValue,
            Contact = $"Email: {Email} \nPhone: {Phone}",
            Date = DateOnly.TryParse(Start, out var bookedDate) ? bookedDate : DateOnly.MinValue,
            Name = Name
        };
    }
}

