namespace AtelierBooking.Models;

internal sealed class BookTime
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public DateOnly Date { get; set; }
    
    public TimeOnly BookedFrom { get; set; }
    
    public TimeOnly BookedTo { get; set; }

    public string Contact { get; set; }

}
