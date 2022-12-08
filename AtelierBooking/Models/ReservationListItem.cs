namespace AtelierBooking.Models;

internal sealed class ReservationListItem
{
    public string Name { get; set; }
    
    public DateOnly Date { get; set; }
    
    public TimeOnly BookedFrom { get; set; }
    
    public TimeOnly BookedTo { get; set; }

    public string Contact { get; set; }

}
